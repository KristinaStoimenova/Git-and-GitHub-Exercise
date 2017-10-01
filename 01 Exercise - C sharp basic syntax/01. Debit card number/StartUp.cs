


namespace _01.Debit_card_number
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            var digitOne = int.Parse(Console.ReadLine());
            var digitTwo = int.Parse(Console.ReadLine());
            var digitThree = int.Parse(Console.ReadLine());
            var digitFour = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", digitOne, digitTwo, digitThree, digitFour);
        }
    }
}
