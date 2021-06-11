using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transaction
{
    class Program
    {
        interface ITransaction
        {
            void showTransaction();
            double getAmount();
        }

        public class Transaction1 : ITransaction
        {
            private string tcode;
            private string date;
            private double amount;

            public Transaction1()
            {
                tcode = "";
                date = "";
                amount = 0.0;
            }

            public Transaction1(string c,string d, double a)
            {
                tcode = c;
                date = d;
                amount = a;

            }

            public double getAmount()
            {
                return amount;
            }

            public void showTransaction()
            {
                Console.WriteLine("Transaction "+tcode);
                Console.WriteLine("Date " + date);
                Console.WriteLine("Amount " + amount);
            }
        
        }
        static void Main(string[] args)
        {
            Transaction1 t1 = new Transaction1("001", "01/09/2018", 234.98);
            Transaction1 t2 = new Transaction1("002", "01/07/2019", 345.67);
            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }
    }
}
