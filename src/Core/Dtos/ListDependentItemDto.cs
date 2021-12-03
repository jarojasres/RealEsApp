using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class ListDependentItemDto<TParentKey, TKey, TValue>
    {
        public TParentKey ParentId { get; set; }

        public TKey Id { get; set; }

        public TValue Value { get; set; }
    }
}
