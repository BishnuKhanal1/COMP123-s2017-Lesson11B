using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Bishnu Khanal
 * DAte: July 27, 2017
 * Description: This is the abstract superclass for lesson 11
 * 
 * Verson: 0.1- 
 */
namespace COMP123_s2017_Lesson11B
{
    public abstract class CardList : List<Card>
    {
        //Private instance variables

        //Public properties

        //Constructors
        // CONSTRUCTOR
        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public CardList()
        {
            this._initialize();
        }

        //Private Methods
        protected abstract void _initialize();

        //Public Methods

    }
}