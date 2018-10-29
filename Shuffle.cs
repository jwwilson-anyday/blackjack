using System;
using System.Collections.Generic;

namespace blackjack
{
    static class Shuffle
    {
       
       
            public static void ShuffleDeck<T>(this IList<T> list)
            {
                Random rng = new Random();
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    T value = list[k];
                    list[k] = list[n];
                    list[n] = value;
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