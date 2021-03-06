﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProbability
{
    public class Deck
    {
        private static Deck instance = null;
        private static Random rand = new Random();

        private List<Card> cards = new List<Card>();

        private Deck() { }

        public static Deck Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Deck();

                    foreach (LetterOne l1 in new LetterOne[] { LetterOne.A, LetterOne.B, LetterOne.C })
                    {
                        foreach (LetterTwo l2 in new LetterTwo[] { LetterTwo.D, LetterTwo.E, LetterTwo.F, LetterTwo.G })
                        {
                            foreach (LetterThree l3 in new LetterThree[] { LetterThree.H, LetterThree.I, LetterThree.J, LetterThree.K, LetterThree.L })
                            {
                                instance.AddCard(new Card(l1, l2, l3));
                            }
                        }
                    }

                    //Console.WriteLine("New deck created.  Card count: " + instance.Count.ToString());
                }

                return instance;
            }
        }

        private void AddCard(Card c)
        {
            this.cards.Add(c);
        }

        public Hand GetHand(int numCards)
        {
            List<Card> handCards = new List<Card>();

            this.Shuffle();

            handCards.AddRange(this.cards.Take(numCards));

            Hand hand = new Hand(handCards);
            return hand;
        }

        private void Shuffle()
        {
            for (int i = 0; i < this.Count; i++)
            {
                int index = rand.Next(0, this.cards.Count);
                Card temp = this.cards[i];
                this.cards[i] = this.cards[index];
                this.cards[index] = temp;
            }
        }

        private int Count
        {
            get
            {
                return this.cards.Count;
            }
        }
    }
}
