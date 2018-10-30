using System;
using System.Collections.Generic;

namespace blackjack
{
   public class Deck
    {
        // Decks should contain a collection of cards
        List<Card> Cards; // crates a list called Cards of objects (a card)

        public Deck()
        {
            this.Cards = new List<Card>();


        }
        public void Print()
        {
            {
                int s = 0;
                List<string> Suits = new List<string> { "Hearts", "Diamonds", "Clubs", "Spades" };
                for (s = 0; s < 4; s++)
                {
                    for (int i = 0; i < 13; i++)
                    {

                        Card card = new Card();
                        int CardValue = i + 2;
                        string CardNameValue = CardValue.ToString();

                        if (CardValue == 11)
                        { CardNameValue = "Jack"; }
                        if (CardValue == 12)
                        { CardNameValue = "Queen"; }
                        if (CardValue == 13)
                        { CardNameValue = "King"; }

                        if (CardValue > 10 && CardValue < 14)
                        { CardValue = 10; }

                        if (CardValue == 14)
                        {
                            CardValue = 11;
                            CardNameValue = "Ace";
                        }

                        card.Suit = Suits[s];
                        card.Value = CardValue;
                        card.Name = ($"{CardNameValue} of {card.Suit}");
                        Cards.Add(card);
                        
                    }
                }
                int NumOfCards = Cards.Count;
                Console.WriteLine(NumOfCards);
                // for (int c = 0; c < 52; c++)
                // { Console.WriteLine($"{Cards[c].Name} : A Value of {Cards[c].Value}"); }
                foreach (Card card in Cards)
                {
                    Console.WriteLine($"{card.Name} : A Value of {card.Value}");
                 
                }

            }
        }

        

    }
}
