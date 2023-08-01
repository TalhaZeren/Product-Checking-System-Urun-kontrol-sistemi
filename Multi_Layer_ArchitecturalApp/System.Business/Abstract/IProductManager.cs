using System;
using System.Collections.Generic;
using System.Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Business.Abstract
{
    public interface IProductManager
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductsBySelectedCategory(int categoryId);
        List<Product> GetProductsByWritenProduct(string productName);
        void Update(Product product);
     

    }
}
