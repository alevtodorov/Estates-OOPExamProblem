using Estates.BaseClasses;
using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Models.Offers
{
    public class Sale : Offer
    {
        private static string location;

        public Sale(IDatabase db, string estateName, decimal price) :
            base(db, estateName, location, price)
        {
            location = FindEstateLocation();
        }

        public override void PrintFeedback()
        {
            Console.WriteLine("{0} created", GetType().Name + "Offer");
        }
    }
}
