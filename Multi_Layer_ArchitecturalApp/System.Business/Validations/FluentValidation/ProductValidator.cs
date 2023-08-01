//using FluentValidation;
//using System;
//using System.Collections.Generic;
//using System.Entities.Concrete;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace System.Business.Validations.FluentValidation
//{
//    public class ProductValidator : AbstractValidator<Product>
//    {

//        public ProductValidator()
//        {
                
//            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product name cannot be empty."); 
//            RuleFor(p => p.CategoryId).NotEmpty();
//            RuleFor(p => p.UnitPrice).NotEmpty();
//            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);  // For Int16 
//            RuleFor(p => p.QuantityPerUnit).NotEmpty();
//            RuleFor(p => p.UnitPrice).GreaterThan(0);

//            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);

//            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ProductName Start with 'A'"); // takes a value true or false.


//        }
//        private bool StartWithA(string arg)
//        {
//            return arg.StartsWith("A");
//        }

//    }

//}
