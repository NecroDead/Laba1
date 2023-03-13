using System;

namespace YP_l1
{
    class Program
    {
        static void Main(string[] args)
        {
            Guns guns = new Guns(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            guns.Print();
            Console.ReadKey();
        }
        class Guns
        {
            string name;
            double caliber;
            double range;
            public void Print()
            {
                Console.WriteLine($"название: {name}\nкалибр: {caliber.ToString()}\nдальность: {range.ToString()}");
            }
            public Guns(string n, double c, double r)
            {
                name = n;
                caliber = c;
                range = r;
            }
        }
    }
}
