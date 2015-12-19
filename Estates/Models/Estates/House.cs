using Estates.BaseClasses;
using Estates.Other;
using Estates.Other.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Models.Estates
{
    public class House : Estate
    {
        private const TypeEstate estate = TypeEstate.House;
        private int numberOfFloors;

        public House(string name, int area, string location, bool isfurnitured, int numberOfFloors)
            :base(name,estate,area,location,isfurnitured)
        {
            NumberOfFloors = numberOfFloors;
        }

        public int NumberOfFloors
        {
            get { return numberOfFloors; }
            set
            {
                o = value;
                Validator.Validation(o, "House number of floors");
                numberOfFloors = value;
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Floors: {0}", NumberOfFloors);
        }
    }
}
