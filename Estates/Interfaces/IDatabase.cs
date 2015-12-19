using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Interfaces
{
    public interface IDatabase
    {
        ICollection<IEstate> AllEstates { get; }
        ICollection<IOffer> AllOffers { get; }
        void Add(IEstate estate);
        void Add(IOffer offer);
        void Remove(IEstate estate);
        void Remove(IOffer offer);
    }
}
