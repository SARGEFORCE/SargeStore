using SargeStore.Data;
using SargeStore.Infrastructure.Interfaces;
using SargeStoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SargeStore.Infrastructure.Services
{
    public class InMemoryProductData : IProductData
    {
        public IEnumerable<Brand> GetBrands() => TestData.Brands;
        public IEnumerable<Section> GetSections() => TestData.Sections;
    }
}
