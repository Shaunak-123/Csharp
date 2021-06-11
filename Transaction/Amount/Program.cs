using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amount
{
    public delegate double Delegate_Prod(int a,int b);
    class Program
    {
        static double cost(int amount, int servicecharges)
        {
            return amount + servicecharges;
        }
        static void Main(string[] args)
        {
            Delegate_Prod delobj = new Delegate_Prod(cost);
            Console.WriteLine("Cost of the car is: ");
            int v1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Charges of the car");
            int v2 = Int32.Parse(Console.ReadLine());
            double res = delobj(v1,v2);
            Console.WriteLine("Total cost is "+res);
            Console.ReadKey();
        }
    }
}
