using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.DataAccess.Abstract;
using System.Entities.Concrete;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace System.DataAccess.Concrete.EntitiyFrameWork
{
    public class EfProductDal : EfEntityRepositoryBase<Product, SystemContext>, IProductDal
    {
        
    }
}
