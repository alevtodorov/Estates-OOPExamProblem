using Estates.Core.Commands;
using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Core
{
    public class Engine : IEngine
    {
        private readonly IDatabase db;
        private ICommand command;

        public Engine(IDatabase db)
        {
            this.db = db;
        }

        public void Run()
        {
            string userInput = Console.ReadLine();
            while(userInput != "end")
            {
                string[] ui = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (ui[0])
                {
                    case "create":
                        command = new Create(db);
                        command.Creator(ui);
                        break;
                    case "status":
                        command = new Status(db);
                        command.Statis();
                        break;
                    case "find-sales-by-location":
                        command = new FindSalesLocation(db);
                        command.FindSales(ui[1]);
                        break;
                    default:
                        break;
                }

                userInput = Console.ReadLine();
            }
        }
    }
}
