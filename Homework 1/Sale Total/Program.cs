// @author Lauren Watson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_Total
{
    class Program
    {
        static void Main(string[] args)
        {
            string productNameAsString;
            double salesPrice;
            int quantity;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            productNameAsString = Console.ReadLine();

            Console.WriteLine($"How many {productNameAsString}'s do you want to buy?");
            quantity = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"What is the price for each {productNameAsString}?");
            salesPrice = Convert.ToDouble(Console.ReadLine());

            const double tax = .085;
            double subTotal = quantity * salesPrice;
            double totalTax = subTotal * tax;
            double totalAmount = subTotal + totalTax;

            Console.WriteLine($"\tYour subtotal for your bill is {subTotal.ToString("C2")}.");
            Console.WriteLine($"\tYour sales tax for your bill is {totalTax.ToString("C2")}.");
            Console.WriteLine($"\tYour total for your bill is {totalAmount.ToString("C2")}.");


            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
        }
    }
}
