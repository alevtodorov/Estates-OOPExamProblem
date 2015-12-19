using Estates.BaseClasses;
using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Core.Commands
{
    public class FindSalesLocation : Command
    {
        private ICollection<IOffer> saleOffers;

        public FindSalesLocation(IDatabase db) : base(db)
        {
            saleOffers = new List<IOffer>();
        }

        public override void FindSales(string location)
        {
            foreach (var item in db.AllOffers)
            {
                if(item.GetType().Name == "Sale")
                {
                    saleOffers.Add(item);
                }
            }
            if(saleOffers.Count == 0)
            {
                Console.WriteLine("No offers");
            }
            else
            {
                foreach (var item in saleOffers)
                {
                    if(item.Location != location)
                    {
                        saleOffers.Remove(item);
                    }
                }
                var newList = saleOffers.OrderByDescending(a => a.Price).ToList();
                saleOffers = newList;
            }
            Console.WriteLine("Query Results:");
            foreach (var item in saleOffers)
            {
                item.QueryPrint();
            }
        }
    }
}
