using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOwner
{
    class Program
    {
        public void BedRoom(String nameandcolor)
        {
            Console.WriteLine(nameandcolor);
        }

        public void BedRoom(String Mname, String color)
        {
            Console.WriteLine(Mname + " Likes " + color + " Colour ");
        }
        static void Main(string[] args)
        {
            Program h1 = new Program();
            h1.BedRoom("Name is Shan and favorite color is Red");
            h1.BedRoom("Ramu", "Pink");
            Console.ReadLine();
        }
    }
}
