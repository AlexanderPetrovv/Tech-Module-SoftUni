using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create a method that prints a blank cash receipt.
The method should invoke three other methods:
one for printingthe header, one for the body and one for the footer of the receipt. 
*/

namespace BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
