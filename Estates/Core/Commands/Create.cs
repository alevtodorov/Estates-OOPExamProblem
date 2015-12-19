using Estates.BaseClasses;
using Estates.Interfaces;
using Estates.Models.Estates;
using Estates.Models.Offers;
using System;

namespace Estates.Core.Commands
{
    public class Create : Command
    {
        private Estate e;
        private Offer o;

        public Create(IDatabase db) : base(db)
        {}

        public override void Creator(string[] userInput)
        {
            switch (userInput[1])
            {
                case "Apartment":
                    e = new Apartament(userInput[2], int.Parse(userInput[3]), userInput[4], bool.Parse(userInput[5]), int.Parse(userInput[6]), bool.Parse(userInput[7]));
                    AddToDatabase(e);
                    break;
                case "Office":
                    e = new Office(userInput[2], int.Parse(userInput[3]), userInput[4], bool.Parse(userInput[5]), int.Parse(userInput[6]), bool.Parse(userInput[7]));
                    AddToDatabase(e);
                    break;
                case "House":
                    e = new House(userInput[2], int.Parse(userInput[3]), userInput[4], bool.Parse(userInput[5]), int.Parse(userInput[6]));
                    AddToDatabase(e);
                    break;
                case "Garage":
                    e = new Garage(userInput[2], int.Parse(userInput[3]), userInput[4], bool.Parse(userInput[5]), int.Parse(userInput[6]), int.Parse(userInput[7]));
                    AddToDatabase(e);
                    break;
                case "RentOffer":
                    o = new Rent(db, userInput[2], decimal.Parse(userInput[3]));
                    AddToDatabase(o);
                    break;
                case "SaleOffer":
                    o = new Sale(db,userInput[2], decimal.Parse(userInput[3]));
                    AddToDatabase(o);
                    break;
                default:
                    throw new ArgumentException(string.Format("Invalid creator command."));
            }
        }

        private void AddToDatabase(object obj)
        {
            if(obj is Estate)
            {
                e = (Estate)obj;
                db.Add(e);
                e.PrintFeedback();
            }
            if(obj is Offer)
            {
                o = (Offer)obj;
                db.Add(o);
                o.PrintFeedback();
            }
        }
    }
}
