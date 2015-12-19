using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Interfaces
{
    public interface IEstate
    {
        string Name { get; set; }
        int Area { get; set; }
        string Location { get; set; }
        bool IsFurnitured { get; set; }
        void PrintInfo();
    }
}
