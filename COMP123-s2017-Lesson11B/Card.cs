using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Bishnu Khanal
 * DAte: July 25, 2017
 * Description: This is a demo for week 11
 * Verson: 0.1 Created the Card clas
 */
namespace COMP123_s2017_Lesson11B
{
    class Card
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
        /// It takes two parameter -face(Face) and suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        //Private methods

        //Public methods

    }
}
