using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceWorkflow
{
    class InvoiceService
    {
        public List<Invoice> Invoices { get; set; }

        public InvoiceService()
        {
            Invoices = new List<Invoice>();
        }

        public ConsoleKeyInfo AddNewInvoiceView(MenuActionService actionService)
        {
            var addNewInvoiceMenu = actionService.GetMenuActionsByMenuName("InvoiceCategoryMenu");
            Console.WriteLine("Select invoice type:");
            for (int i = 0; i < addNewInvoiceMenu.Count; i++)
            {
                Console.WriteLine($"{addNewInvoiceMenu[i].Id}. {addNewInvoiceMenu[i].Name}");
            }

            var userChoice = Console.ReadKey();
            return userChoice;

        }
    }
}
