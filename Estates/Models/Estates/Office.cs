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
    public class Office : Estate
    {
        private const TypeEstate estate = TypeEstate.Office;
        private int numOfRooms;

        public Office(string name, int area, string location,
            bool isfurnitured, int numOfRooms, bool hasElevator)
            :base(name,estate,area,location,isfurnitured)
        {

        }
        public int NumOfRooms
        {
            get { return numOfRooms; }
            set
            {
                o = value;
                Validator.Validation(o, "Office number of rooms");
                numOfRooms = value;
            }
        }
        public bool HasElevator { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Rooms: {0}, Elevator: {1}", NumOfRooms, HasElevator ? "Yes" : "No");
        }
    }
}
