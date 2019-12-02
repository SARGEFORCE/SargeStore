using SargeStoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SargeStore.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();
        IEnumerable<Brand> GetBrands();
        IEnumerable<Product> GetProducts(ProductFilter Filter = null);

        Product GetProductById(int id);
    }
}
