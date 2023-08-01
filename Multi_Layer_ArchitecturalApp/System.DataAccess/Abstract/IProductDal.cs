using System;
using System.Collections.Generic;
using System.Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
      

    }
}
