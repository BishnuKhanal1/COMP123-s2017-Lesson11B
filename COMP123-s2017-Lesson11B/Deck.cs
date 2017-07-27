using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Bishnu Khanal
 * DAte: July 25, 2017
 * Description: This is a Deck class
 * It inherits from the List generic and uses Card as the base type
 * Verson: 0.6- Returned top card from the deck
 */
namespace COMP123_s2017_Lesson11B
{
    public class Deck : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;

        // PRIVATE PROPERTIES
        private Random Random
        {

            get
            {
                return this._random;
            }
        }

        // PUBLIC PROPERTIES

        

        // PRIVATE METHODS

        /// <summary>
        /// This is the Initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
        protected override void _initialize()
        {
            // initialize the pseudo-random number generator
            this._random = new Random();

            // This builds the deck - fills it with cards
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "The Deck Contains Number of Cards: " + this.Count + "\n";
            outputString += "===========================================================";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
        /// <summary>
        /// This method shuffles the deck by using random indices to select two cards at a time
        /// It uses a Fisher-Yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);

                tempCard = (Card)this[secondCard].Clone();
                Card.OverWrite(this[secondCard], this[firstCard]);
                Card.OverWrite(this[secondCard], tempCard);
            }
        }
        /// <summary>
        /// this methods returns the top from from the deck
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0);//this removes the top card from the deck
            return topCard;
        }
    }
}