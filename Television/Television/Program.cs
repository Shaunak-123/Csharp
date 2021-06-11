using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Television
{
    abstract class TeleVision1
    {
        public abstract void Viewing();
        public abstract void ChannelChange();
        public void Switch()
        {
            Console.WriteLine("TV is getting switched on");
        }
    }

     class Videocon : TeleVision1
    {
        public override void Viewing()
        {
            Console.WriteLine("I am viewing the channel on Videocon");
        }
        public override void ChannelChange()
        {
            Console.WriteLine("I can change the channel on Videocon");
        }
    }

    class Panasonic : TeleVision1
    {
        public override void Viewing()
        {
            Console.WriteLine("I am viewing the channel on Panasonic");
        }
        public override void ChannelChange()
        {
            Console.WriteLine("I can change the channel on Panasonic");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Videocon v1 = new Videocon();
            v1.Switch();
            v1.Viewing();
            v1.ChannelChange();
            Panasonic p1 = new Panasonic();
            p1.Switch();
            p1.Viewing();
            p1.ChannelChange();
            Console.ReadKey();
        }
    }
}
