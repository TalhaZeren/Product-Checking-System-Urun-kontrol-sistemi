using System;
using System.Business.Abstract;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.DataAccess.Abstract;
using System.Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Business.Concrete
    
{
    public class ProductManager : IProductManager
    {
        

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal) {
        
        _productDal = productDal;

        }

        public void Add(Product product)
        {
            
        //    ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);   
        }

      

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Deleting did not Occurated.");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsBySelectedCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByWritenProduct(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));  
        }

        public void Update(Product product)
        {
           // ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);

        }
    }
}
