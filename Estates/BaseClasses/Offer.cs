using Estates.Interfaces;
using Estates.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.BaseClasses
{
    public abstract class Offer : IOffer, IPrintable
    {
        private object o;
        protected IDatabase db;
        protected string estateName;
        protected static string location;
        private decimal price;

        protected Offer(IDatabase db, string estateName, string location, decimal price)
        {
            this.db = db;
            EstateName = estateName;
            Location = FindEstateLocation();
            Price = price;
        }

        public string EstateName
        {
            get { return estateName; }
            set
            {
                o = value;
                Validator.Validation(o, "Offer estate name");
                estateName = value;
            }
        }
        public string Location
        {
            get { return location; }
            set
            {
                o = value;
                Validator.Validation(o, "Offer location");
                location = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                o = value;
                Validator.Validation(o, "Offer price");
                price = value;
            }
        }

        protected string FindEstateLocation()
        {
            IEstate e = null;

            foreach (var item in db.AllEstates)
            {
                if (item.Name == estateName)
                {
                    e = item;
                    return e.Location;
                }
            }
            if (e == null)
            {
                throw new ArgumentException("Estate with name {0} does not exist.", estateName);
            }
            return null;
        }

        public virtual void PrintFeedback()
        {
            Console.WriteLine("{0} created", GetType().Name);
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("{0}: Estate = {1}, Location = {2}, Price = {3:F2}", GetType().Name, EstateName, Location, Price);
        }

        public void QueryPrint()
        {
            Console.WriteLine("[Estate = {0}, Location = {1}, Price = {2:F2}]", EstateName, Location, Price);
        }
    }
}
