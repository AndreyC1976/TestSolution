using Books;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class StockManagement
    {
        public void BooksIncome(BookCatalog catalog, UserDialog dialog)
        {
            string choiceIncome = dialog.UserChoiceIncome();
            if (choiceIncome == "0") { return; }
            catalog.BookQuantityAdd(1, 1000);
        }
        public void BooksSell(BookCatalog catalog, UserDialog dialog)
        {
            do
            {
                string choiceSell = dialog.UserChoiceSell();
                if (choiceSell == "0")
                { 
                    return; 
                }
                
                double sellResult = catalog.BookQuantityRemove(1, 500);

                if (sellResult < 0)
                {
                    dialog.IncorrectSell();
                    continue;
                }
                else { return; }
            } while (true);
        }

    } // Окончание класса StockManagement
}  // Окончание namespace Books 

