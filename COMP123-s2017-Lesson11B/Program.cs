using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Bishnu Khanal
 * DAte: July 25, 2017
 * Description: This is a demo for lesson 11
 * It inherits from the List generic and uses cards
 * Verson: 0.3 Test Shuffle method of the Deck class
 */
namespace COMP123_s2017_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("Origional Deck  Number of Cards: "+deck.Count);
            Console.WriteLine("==================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled Deck  Number of Cards: "+ deck.Count);
            Console.WriteLine("==================================");
            Console.WriteLine(deck.ToString());
        }
    }
}
