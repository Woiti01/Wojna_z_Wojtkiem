using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Wojna
{
    class Deck
    {
        private List<Card> deck;

        public Deck()
        {
            deck = new List<Card>();
        }

        public Deck(string word)
        {
            if (word == "base")
            {
                for (var i = 1; i <= 4; i++)
                {
                    deck.Add(new Card(1, 14, i));
                    for (var x = 2; x <= 13; x++)
                    {
                        deck.Add(new Card(x, x, i));
                    }
                }
            }

        }

        public void AddCard(Card card)
        {
            deck.Add(card);
        }
        public void ShuffleDeck(int amount)
        {
            var rand = new Random();
            for (int i = 0; i < amount; i++)
            {
                var x = rand.Next(deck.Count - 1);
                deck.Insert(x, deck[0]);
                deck.RemoveAt(0);
            }
        }
        public void ShuffleDeck()
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var x = rand.Next(deck.Count - 1);
                deck.Insert(x, deck[0]);
                deck.RemoveAt(0);
            }
        }

        public Card GetTopCard()
        {
            return (deck[0]);
        }

        public Card GetCardXFromTop(int n)
        {
            return (deck[0 + n]);
        }

        public void RemoveTopCard()
        {
            deck.RemoveAt(0);
        }
    }
}
