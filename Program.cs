using System;

namespace InvoiceWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            
            Console.WriteLine("Welcome to invoice workflow app!");

            //foreach
            Console.WriteLine("Choose your operation:");
            var mainMenu = actionService.GetMenuActionsByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }

            var userChoice = Console.ReadKey();
            switch (userChoice.KeyChar)
            {
                case '1':
                    AddNewInvoice()
                    break;
                case '2':
                    RemoveInvoice();
                    break;
                case '3':
                    Report();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add new invoice", "Main");
            actionService.AddNewAction(2, "Remove invoice", "Main");
            actionService.AddNewAction(3, "Reports", "Main");
            return actionService;
        }
    }
}
