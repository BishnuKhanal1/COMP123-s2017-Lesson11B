using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Bishnu Khanal
 * DAte: July 27, 2017
 * Description: This is a Hand class
 * It inherits from the CardList Abstract class
 * Verson: 0.2- Added HighestCards() Method that sorts and displays the sorted top five cards
 */
namespace COMP123_s2017_Lesson11B
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            // STUB
            // this method is empty
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

            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
        /// <summary>
        /// This is the HighestCard() Method that takes one parameter - hand(Hand)
        /// This sorts the top five cards in descending order and displays the topfive cards in order
        /// </summary>
        /// <param name="hand"></param>
        public void HighestCards(Hand hand)
        {
            var sortedHand = from cards in hand orderby cards.Face descending select cards.Suit;
            Console.WriteLine("The Highest cards in descending order: ");
            foreach (var item in sortedHand)
            {
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                Console.WriteLine("The Highest value cards");
                foreach (var cards in sortedHand)
                {
                    if (cards == sortedHand.Max())
                    {
                        Console.WriteLine(cards);
                    }
                }
               
            }
        }
    }
}