using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProbability
{
    [DebuggerDisplay("{cards}")]
    public class Hand
    {
        private IEnumerable<Card> cards;

        public Hand(IEnumerable<Card> cards)
        {
            this.cards = cards;
        }

        public bool HasAll
        {
            get
            {
                return this.HasAllABC && this.HasAllDEFG && this.HasAllHIJKL;
            }
        }

        private bool HasA
        {
            get
            {
                return this.cards.Any(p => p.LetterOne == LetterOne.A);
            }
        }

        private bool HasB
        {
            get
            {
                return this.cards.Any(p => p.LetterOne == LetterOne.B);
            }
        }

        private bool HasC
        {
            get
            {
                return this.cards.Any(p => p.LetterOne == LetterOne.C);
            }
        }

        private bool HasD
        {
            get
            {
                return this.cards.Any(p => p.LetterTwo == LetterTwo.D);
            }
        }

        private bool HasE
        {
            get
            {
                return this.cards.Any(p => p.LetterTwo == LetterTwo.E);
            }
        }

        private bool HasF
        {
            get
            {
                return this.cards.Any(p => p.LetterTwo == LetterTwo.F);
            }
        }

        private bool HasG
        {
            get
            {
                return this.cards.Any(p => p.LetterTwo == LetterTwo.G);
            }
        }

        private bool HasH
        {
            get
            {
                return this.cards.Any(p => p.LetterThree == LetterThree.H);
            }
        }

        private bool HasI
        {
            get
            {
                return this.cards.Any(p => p.LetterThree == LetterThree.I);
            }
        }

        private bool HasJ
        {
            get
            {
                return this.cards.Any(p => p.LetterThree == LetterThree.J);
            }
        }

        private bool HasK
        {
            get
            {
                return this.cards.Any(p => p.LetterThree == LetterThree.K);
            }
        }

        private bool HasL
        {
            get
            {
                return this.cards.Any(p => p.LetterThree == LetterThree.L);
            }
        }

        private bool HasAllABC
        {
            get
            {
                return this.HasA && this.HasB && this.HasC;
            }
        }

        private bool HasAllDEFG
        {
            get
            {
                return this.HasD && this.HasE && this.HasF && this.HasG;
            }
        }

        private bool HasAllHIJKL
        {
            get
            {
                return this.HasH && this.HasI && this.HasJ && this.HasK && this.HasL;
            }
        }
    }
}
