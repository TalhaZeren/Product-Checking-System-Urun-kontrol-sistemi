//using FluentValidation;
//using System;
//using System.Business.Validations.FluentValidation;
//using System.Collections.Generic;
//using System.Entities.Concrete;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace System.Business.Utilities
//{
//    public static class ValidationTool 
//    {
//        public static void Validate(IValidator validator,object entity)
//        { 
//            var result  = validator.Validate((IValidationContext)entity);

//            if (result.Errors.Count > 0)
//            {

//                throw new ValidationException(result.Errors);
//            }

//        }


//    }
//}
