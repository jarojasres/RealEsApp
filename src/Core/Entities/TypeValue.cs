using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TypeValue : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public string Value { get; set; }

        public Guid TypeId { get; set; }

        public Type Type { get; set; }
    }
}
