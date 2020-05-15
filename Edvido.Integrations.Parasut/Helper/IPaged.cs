using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edvido.Integrations.Parasut.Helper
{
    public interface IPaged<T>
    {
        int CurrentPage { get; set; }
        int TotalPages { get; set; }
        int TotalCount { get; set; }
        IEnumerable<T> Items { get; set; }
    }
}
