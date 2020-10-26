using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Pagination<T>
    {
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; } = 10;
        public long Count { get; set; } = 0;
        public ICollection<T> Items { get; set; }
    }
}
