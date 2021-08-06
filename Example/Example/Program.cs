using System;

namespace Example
{
     class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari = new Ferrari();
            ferrari.Renk = "Kırmızı";
            ferrari.Model = "2018 Ferrari 812 Superfast";
            ferrari.LastikSay = "Ferrari'de 4 adet lastik var";
            ferrari.topSpeed();
            ferrari.ICbabriolet();
            Console.ReadLine();

            Mercedes mercedes = new Mercedes();
            mercedes.Renk = "Siyah";
            mercedes.Model = "GLA Serisi";
            mercedes.LastikSay = "Mercedes'de 4 adet lastik var";
            mercedes.topSpeed();
            
            Console.ReadLine();

            Bmw bmw = new Bmw();
            bmw.Renk = "Siyah";
            bmw.Model = "F44 ";
            bmw.LastikSay = "BMW'de 4 adet lastik var";
            bmw.topSpeed();
            bmw.ICbabriolet();
            Console.ReadLine();

            RangeRover rangeRover = new RangeRover();
            rangeRover.Renk = "Mavi";
            rangeRover.Model = "Range Rover Sport 2.0 ";
            rangeRover.LastikSay = "Range Rover' da 4 adet lastik var";
            rangeRover.FourWheelDrive = " Aracınız 4x4";
            rangeRover.topSpeed();
            Console.ReadLine();



        }
    }
 }

   public abstract class Araba
{
    public string Model { get; set; }
    public string Renk { get; set; }
    public string LastikSay { get; set; }
    public abstract void topSpeed();
}
