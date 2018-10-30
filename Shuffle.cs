using System;
using System.Collections.Generic;

namespace blackjack
{
    public static class Shuffle
    {


        public static void ShuffleDeck<T>(this IList<T> list)
        {
            Console.WriteLine("I am here");

            List<Card> Cards = new List<Card>();
            Card card = new Card();

            Random rng = new Random(52);
            int cardRandom = rng.Next(1, 52);
            Console.WriteLine(cardRandom);

            int n = Cards.Count;

            Console.WriteLine(n);

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
                Console.WriteLine(k);
            }

        }


        // Each player should have properties for their total chip count and current hand
        // public string PlayerName;
        //     public int Chips;
        //     public string PlayerCurrentHand;

        // The bank should be a Player as well

        // public void PrintHand()
        // {

        // }

    }
}