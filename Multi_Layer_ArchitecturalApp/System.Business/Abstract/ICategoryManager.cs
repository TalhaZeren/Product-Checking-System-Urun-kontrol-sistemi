using System;
using System.Collections.Generic;
using System.Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Business.Abstract
{
    public interface ICategoryManager
    {
        List<Category> GetAll();
       
    }
}
