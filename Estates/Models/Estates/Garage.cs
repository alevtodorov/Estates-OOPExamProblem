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
    public class Garage : Estate
    {
        private const TypeEstate estate = TypeEstate.Garage;

        private int width;
        private int height;

        public Garage(string name, int area, string location, bool isfurnitured, int width, int height)
            :base(name,estate,area,location,isfurnitured)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get { return width; }
            set
            {
                o = value;
                Validator.Validation(o, "Garage width");
                width = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                o = value;
                Validator.Validation(o, "Garage height");
                height = value;
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Width: {0}, Height: {1}", Width, Height);
        }
    }
}
