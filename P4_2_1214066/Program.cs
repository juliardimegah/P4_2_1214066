using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214066
{
    internal class Program
    {
        static void Main(string[] args)
        {

            velg product1 = new velg("Velg", "Volk TE37", "6");
            velg product2 = new velg("Velg", "Watanabe", "6");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} spokes", product1.MyType, product1.myName, product1.Spoke);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} spokes", product2.MyType, product2.myName, product2.Spoke);

        }
    }
}
