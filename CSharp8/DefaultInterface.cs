using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{ // esaly extend interface 
    // allow 
    interface IShoppingCart
    {
        public static void setDefaultName(string name)
        {
            defaultName = name;
        }
        private static string defaultName = "shopping";
        void CalculateTotal();
        void CalculateSubTotal()
        {
            Console.WriteLine($"this CalculateSubTotal {defaultName} implementation ");
        }
    }
    class ShoppingCart : IShoppingCart
    {
        public void CalculateTotal()
        {
            Console.WriteLine("this CalculateTotal from shopping Class ");
        }
        public void CalculateSubTotal() { 
            Console.WriteLine("this CalculateSubTotal  implementation from shopping Class ");
        }
    }

}
