// HW1a Sales Total

// Your Name: Jaime Ramirez
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            double price;
            double quantity;
            double subtotal;
            double total;
            const double multiplier = .085;

            string ProductName;
            string QuantityProduct;
            string ProductPrice;

            Console.WriteLine("What is the name of the product you are purchasing?");
            ProductName = Console.ReadLine();
            Console.WriteLine("How many " + ProductName +"(s)" + " would you like to purchase?");
            QuantityProduct = Console.ReadLine();
            Console.WriteLine("What is the price for each " + ProductName + "?");
            ProductPrice = Console.ReadLine();

            price = Convert.ToDouble(ProductPrice);
            quantity = Convert.ToDouble(QuantityProduct);

            subtotal = price * quantity;
            
            Console.WriteLine("Your subtotal is " + "$" + subtotal);

            total = subtotal + (multiplier * subtotal);

            Console.WriteLine("The total for your purchase is " + "$" + total);
        }
    }
}
