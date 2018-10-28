using System;
using System.Collections.Generic;

namespace blackjack
{
    class Deck
    {
        // Decks should contain a collection of cards

        public List<Card> Cards;


        public Deck()
        {
            this.Cards = new List<Card>();
            Cards.Add(card.Name);
            
            {
                Card card = new Card();
                card.Suite = "Hearts";
                card.Name = "2 of Hearts";
                card.Value = 2;

                Console.WriteLine(card.Name);

            }

        }

        public void Print()
        {


        }

        // Add a method to shuffle the deck
        public void Shuffle()
        {

        }

        // Add a method to deal a card from the deck

        // public Card Deal()
        // {

        // }
    }
}