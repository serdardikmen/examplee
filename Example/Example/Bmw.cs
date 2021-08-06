using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class Bmw : Araba , ICabriolet
    {
        public void ICbabriolet()
        {
            Console.WriteLine("BMW'nin Üstü Açılıyor");
        }

        public override void topSpeed()
        {
            Console.WriteLine("BMW Maksimim 290 km/h hızla gidiyor...");
            Console.WriteLine("Renk: {0}", Renk);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Lastik Sayısı: {0}", LastikSay);
            

        }

    }
}
