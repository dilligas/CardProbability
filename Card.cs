using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProbability
{
    [DebuggerDisplay("{LetterOne}{LetterTwo}{LetterThree}")]
    public class Card
    {
        public LetterOne LetterOne { get; private set; }
        public LetterTwo LetterTwo { get; private set; }
        public LetterThree LetterThree { get; private set; }

        public Card(LetterOne letterOne, LetterTwo letterTwo, LetterThree letterThree)
        {
            this.LetterOne = letterOne;
            this.LetterTwo = letterTwo;
            this.LetterThree = letterThree;
        }
    }
}
