using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class Mercedes : Araba
    {
        public override void topSpeed()
        {
            Console.WriteLine("Mercedes Maksimim 270 km/h hızla gidiyor...");
            Console.WriteLine("Renk: {0}", Renk);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Lastik Sayısı: {0}", LastikSay);
        }

    }
}
