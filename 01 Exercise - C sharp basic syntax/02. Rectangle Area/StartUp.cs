
namespace _02.Rectangle_Area
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double area = width * hight;
            Console.WriteLine("{0:F2}", area);

        }
    }
}
