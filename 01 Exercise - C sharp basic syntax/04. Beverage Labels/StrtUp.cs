


namespace _04.Beverage_Labels
{
    using System;
    public class StrtUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());      
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());
            double totalEnergyContent = (energyContent * volume) / 100;
            double totalSugarContent = (sugarContent * volume) / 100;
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergyContent, totalSugarContent);
        }
    }
}
