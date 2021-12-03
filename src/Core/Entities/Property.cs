using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Property : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid TypeId { get; set; }

        public TypeValue Type { get; set; }

        public decimal Price { get; set; }

    }
}
