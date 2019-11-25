using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SargeStore.Data
{
    public class SargeStoreContexInitializer
    {
        private readonly SargeStoreDB _db;
        public SargeStoreContexInitializer(SargeStoreDB db) => _db = db;

        public async Task InitializeAsync()
        {
            var db = _db.Database;
            //if(await _db.Database.EnsureDeletedAsync())
            //{
            //    //БД существовала и была успешно удалена
            //}

            //await _db.Database.EnsureCreatedAsync();

            await db.MigrateAsync(); //Автоматическое создание и миграция до последней версии

            if (await _db.Products.AnyAsync()) return;

            using (var transaction = await db.BeginTransactionAsync())
            {
                await _db.Sections.AddRangeAsync(TestData.Sections);

                await db.ExecuteSqlCommandAsync("SET IDENTITY_INSERT [dbo].[Sections] ON");
                await _db.SaveChangesAsync();
                await db.ExecuteSqlCommandAsync("SET IDENTITY_INSERT [dbo].[Sections] OFF");
                transaction.Commit();
            }

            using (var transaction = await db.BeginTransactionAsync())
            {
                await _db.Brands.AddRangeAsync(TestData.Brands);

                await db.ExecuteSqlCommandAsync("SET IDENTITY_INSERT [dbo].[Brands] ON");
                await _db.SaveChangesAsync();
                await db.ExecuteSqlCommandAsync("SET IDENTITY_INSERT [dbo].[Brands] OFF");
                transaction.Commit();
            }

            using (var transaction = await db.BeginTransactionAsync())
            {
                await _db.Products.AddRangeAsync(TestData.Products);

                await db.ExecuteSqlCommandAsync("SET IDENTITY_INSERT [dbo].[Products] ON");
                await _db.SaveChangesAsync();
                await db.ExecuteSqlCommandAsync("SET IDENTITY_INSERT [dbo].[Products] OFF");
                transaction.Commit();
            }
        }
    }
}
