using System;
using System.Collections.Generic;
using System.Entities.Abstract;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
