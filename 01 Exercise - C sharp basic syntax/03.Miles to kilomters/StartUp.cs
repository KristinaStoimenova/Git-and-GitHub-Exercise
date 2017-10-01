
namespace _03.Miles_to_kilomters
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double kilometers = double.Parse(Console.ReadLine()); 
            double miles = kilometers * 1.60934;
            Console.WriteLine("{0:F2}", miles);
        }
    }
}
