using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Interfaces
{
    public interface IOffer
    {
        string EstateName { get; set; }
        string Location { get; set; }
        decimal Price { get; set; }
        void PrintInfo();
        void QueryPrint();
    }
}
