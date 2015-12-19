using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.BaseClasses
{
    public abstract class Command : ICommand
    {
        protected IDatabase db;

        protected Command(IDatabase db)
        {
            this.db = db;
        }

        public virtual void Creator(string[] ui){}
        public virtual void FindSales(string location){}
        public virtual void Statis(){}
    }
}
