using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class RangeRover : Araba
    {
        public string FourWheelDrive { get; set; }
        public override void topSpeed()
        {

            Console.WriteLine("Range Rover Maksimim 300 km/h hızla gidiyor...");
            Console.WriteLine("Renk: {0}", Renk);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Lastik Sayısı: {0}", LastikSay);
            Console.WriteLine("Four-Wheel Drive (4x4):", FourWheelDrive);
        }

    }
}
