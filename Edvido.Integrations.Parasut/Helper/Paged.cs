using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edvido.Integrations.Parasut.Helper
{
    public class Paged<T> : IPaged<T>
    {
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalCount { get; set; } = 1;
        public IEnumerable<T> Items { get; set; }
    }
}
