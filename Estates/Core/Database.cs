using Estates.BaseClasses;
using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Core
{
    public class Database : IDatabase
    {
        private ICollection<IEstate> allEstates;
        private ICollection<IOffer> allOffers;

        public Database()
        {
            allEstates = new List<IEstate>();
            allOffers = new List<IOffer>();
        }

        public ICollection<IEstate> AllEstates { get { return allEstates; } }
        public ICollection<IOffer> AllOffers { get { return allOffers; } }

        public void Add(IEstate estate)
        {
            AllEstates.Add(estate);
        }
        public void Add(IOffer offer)
        {
            AllOffers.Add(offer);
        }

        public void Remove(IEstate estate)
        {
            AllEstates.Remove(estate);
        }
        public void Remove(IOffer offer)
        {
            AllOffers.Remove(offer);
        }
    }
}
