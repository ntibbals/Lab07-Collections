﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Cards
    {

        public string Value { get; set; }

        public Suits Suit { get; set; }

        public enum Suits { Hearts, Spades, Diamonds, Clubs }
      

        /// <summary>
        /// Constructor for Cards object
        /// </summary>
        /// <param name="suit">suit</param>
        /// <param name="val">value of card</param>
        public Cards(Suits suit, string val)
        {
            Value = val;
            Suit = suit;

        }

    }
}
