using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class ListItemDto<TKey, TValue>
    {
        public TKey Id { get; set; }

        public TValue Value { get; set; }
    }
}
