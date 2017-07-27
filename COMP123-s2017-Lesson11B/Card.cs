using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Bishnu Khanal
 * DAte: July 25, 2017
 * Description: This is the Card class
 * Verson: 0.2 -Added the Override method
 */
namespace COMP123_s2017_Lesson11B
{
    /// <summary>
    /// This is the card class
    /// </summary>
    public class Card : ICloneable
    {
        //Private instance variables
        private Face _face;
        private Suit _suit;

        // Public Properties
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }
        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }
        //Constructors
        /// <summary>
        /// This isa main constructor
        /// It takes two parameter -face(Face) and -suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        //* PRIVATE METHODS
        /// <summary>
        /// This methods overide the buult in Clone method
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }
        // PUBLIC METHODS
        /// <summary>
        /// This method overrides the firstcard with the second card
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
       public static void OverWrite(Card first, Card second)
        {
            first.Face = second.Face;
            first.Suit = second.Suit;
        } 
    }
}
