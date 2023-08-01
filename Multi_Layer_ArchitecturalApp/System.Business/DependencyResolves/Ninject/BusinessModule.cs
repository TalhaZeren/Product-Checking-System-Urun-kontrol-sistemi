//using Ninject.Modules;
//using System;
//using System.Business.Abstract;
//using System.Business.Concrete;
//using System.Collections.Generic;
//using System.DataAccess.Abstract;
//using System.DataAccess.Concrete.EntitiyFrameWork;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace System.Business.DependencyResolves.Ninject
//{
//    public class BusinessModule : NinjectModule
//    {
//        public override void Load()
//        {
//            Bind<IProductManager>().To<ProductManager>();
//            Bind<IProductDal>().To<EfProductDal>();

//            Bind<ICategoryManager>().To<CategoryManager>();   
//            Bind<ICategoryDal>().To<EfCategoryDal>(); 

//        }
//    }
//}
