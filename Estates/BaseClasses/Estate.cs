using System;
using Estates.Interfaces;
using Estates.Other;
using Estates.Other.Enums;

namespace Estates.BaseClasses
{
    public abstract class Estate : IEstate, IPrintable
    {
        protected object o; // for validation

        private string name;
        private TypeEstate typeEstate;
        private int area;
        private string location;

        protected Estate(string name, TypeEstate estate, int area, string location, bool isfurnitured)
        {
            Name = name;
            Area = area;
            Location = location;
            IsFurnitured = isfurnitured;
        }

        public string Name
        {
            get { return name; }
            set
            {
                o = value;
                Validator.Validation(o, "Estate name");
                name = value;
            }
        }
        public int Area
        {
            get { return area; }
            set
            {
                o = value;
                Validator.Validation(o, "Estate area");
                area = value;
            }
        }
        public string Location
        {
            get { return location; }
            set
            {
                o = value;
                Validator.Validation(o, "Estate location");
                location = value;
            }
        }
        public bool IsFurnitured { get; set; }

        public virtual void PrintFeedback()
        {
            //Prints feedback after creation.
            Console.WriteLine("{0} created.", GetType().Name);
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("{4}: Name: {0}, Area = {1}, Location = {2}, Furnitured = {3}", 
                Name, Area, Location, 
                IsFurnitured ? "Yes" : "No", GetType().Name);
        }

    }
}
