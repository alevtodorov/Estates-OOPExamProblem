using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Models.Estates
{
    using BaseClasses;
    using Other;
    using Other.Enums;

    public class Apartament : Estate
    {
        private const TypeEstate estate = TypeEstate.Apartament;
        private int numOfRooms;

        public Apartament(string name, int area, string location, bool isfurnitured, int numOfRooms, bool hasElevator)
            :base(name, estate,area,location, isfurnitured)
        {
            NumOfRooms = numOfRooms;
            HasElevator = hasElevator;
        }

        public int NumOfRooms
        {
            get { return numOfRooms; }
            set
            {
                o = value;
                Validator.Validation(o, "Apartament number of rooms");
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
