using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment002
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Product p1 = new Product { Code = 20, Prod_name = "Samsung", Prod_price = 25000};
          p1.CalculateDiscount();
            Console.WriteLine(p1.ToString());
        }
    }
}
