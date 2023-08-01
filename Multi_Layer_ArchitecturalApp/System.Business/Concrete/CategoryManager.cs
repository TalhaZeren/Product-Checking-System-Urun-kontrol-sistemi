using System;
using System.Business.Abstract;
using System.Collections.Generic;
using System.DataAccess.Abstract;
using System.Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Business.Concrete
{
   
    public class CategoryManager : ICategoryManager
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) {
        _categoryDal = categoryDal; 
        }
        
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
            
        }
    }
}
