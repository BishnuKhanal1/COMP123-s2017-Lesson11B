﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Bishnu Khanal
 * DAte: July 25, 2017
 * Description: This is a demo for lesson 11
 * It inherits from the List generic and uses cards
 * Verson: 0.4 Tested the new Deck class
 */
namespace COMP123_s2017_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();
            /*
            Console.WriteLine("Origional Deck  Number of Cards: "+deck.Count);
            Console.WriteLine("==================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled Deck  Number of Cards: "+ deck.Count);
            Console.WriteLine("==================================");
            Console.WriteLine(deck.ToString());


            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine("==================================");
            Console.WriteLine(hand.ToString());

            Console.WriteLine();
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            Console.WriteLine();
            Console.WriteLine(deck.ToString());*/

            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());
            Console.WriteLine("Dealt Top Five Cards");
            Console.WriteLine("==================================");
            Console.WriteLine();
           
            //Console.WriteLine(deck.ToString());
            hand = deck.Deal5(); //moves top five cards from the deck to the  
            Console.WriteLine(hand);

            deck.HighestCards();
            Console.WriteLine(hand.HighestCards());


            
        }
    }
}
