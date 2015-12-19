using Estates.BaseClasses;
using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Core.Commands
{
    public class Status : Command
    {
        public Status(IDatabase db) : base(db)
        {}

        public override void Statis()
        {
            Console.WriteLine("Estates:");
            if(db.AllEstates.Count == 0)
            {
                Console.WriteLine("No estates");
                return;
            }
            else
            {
                foreach (var item in db.AllEstates)
                {
                    item.PrintInfo();
                }
            }
            
            if(db.AllOffers.Count == 0)
            {
                Console.WriteLine("No offers");
                return;
            }
            else
            {
                foreach (var item in db.AllOffers)
                {
                    item.PrintInfo();
                }
            }
        }
    }
}
