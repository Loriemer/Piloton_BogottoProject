using System;

namespace Piloton_BogottoProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstItemPrice;
            int secondItemPrice;
            double discountedPrice;
            double totalPrice;

            Console.Write("Enter the price of the first item: ");
            firstItemPrice = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of the second item:  ");
            secondItemPrice = int.Parse(Console.ReadLine());

            if (firstItemPrice < secondItemPrice)
            {
                discountedPrice = firstItemPrice / 2;
                totalPrice = discountedPrice + secondItemPrice;
            }
            else
            {
                discountedPrice = secondItemPrice / 2;
                totalPrice = discountedPrice + firstItemPrice;
            }
            Console.WriteLine($"The total amount of customer owes: {totalPrice}");
        }
    }
}