using System;
using System.Collections.Generic;
using System.DataAccess.Abstract;
using System.Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DataAccess.Concrete.EntitiyFrameWork
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,SystemContext>,ICategoryDal
    {


    }
}
