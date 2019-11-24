using DataAccessLayer.Context;
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
            if(await _db.Database.EnsureDeletedAsync())
            {
                //БД существовала и была успешно удалена
            }
        }
    }
}
