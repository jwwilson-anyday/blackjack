using System;
using System.Collections.Generic;

namespace blackjack
{
    class Program
    {
        static public Player player;
        static public Player bank;


        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Print();

            Card card = new Card();
            List<Card> Cards = new List<Card>();
            Shuffle.ShuffleDeck(Cards);
            
           foreach (Card mycard in Cards)
                {
                    Console.WriteLine($"{mycard.Name} : A Value of {mycard.Value}");
                    //Console.WriteLine(Cards);
                }
          
           
            player = new Player();
            bank = new Player();

            // player.Chips = 100;



            // while(player.Chips > 0)
            // {
            //     PlayHand();
            // }

            // Let's make a blackjack program using a Deck, Card and Player class that we will create

            // First give the user an amount of chips they can use to bet

            // For each hand, ask the user how much they want to be first

            // Use the Deck and Card classes to deal two cards to the user and two cards to the bank

            // Ask the user if they want to hit or stay

            // If the user stays, then deal cards to the bank until they reach 17 or they go over 21 and bust

            // Award our user their bet if they won and take that money away if they lost

            // Repeat
        }

        static void PlayHand()
        {
            Console.ReadLine();
        }
    }
}