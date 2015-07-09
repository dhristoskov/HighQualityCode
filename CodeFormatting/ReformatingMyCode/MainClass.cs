using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReformatingMyCode
{
    class MainClass
    {

        static void Main(string[] args)
        {
            PokerHand hand = new PokerHand();
            hand.MakeNewEntry();
            hand.SortCards();
            PrintHands(hand);
        }

        static void PrintHands(PokerHand hand)
        {
            if (hand.IsRoyalFlush())
            {
                Console.WriteLine("Royal Flush");
            }
            else if (hand.IsStraightFlush())
            {
                Console.WriteLine("Straight Flush");
            }
            else if (hand.IsFourOfAKind())
            {
                Console.WriteLine("Four of a Kind");
            }
            else if (hand.IsFullHouse())
            {
                Console.WriteLine("Full House");
            }
            else if (hand.IsFlush())
            {
                Console.WriteLine("Flush");
            }
            else if (hand.IsStraight())
            {
                Console.WriteLine("Straight");
            }
            else if (hand.IsThreeOfAKind())
            {
                Console.WriteLine("Three of a Kind");
            }
            else if (hand.IsTwoPairs())
            {
                Console.WriteLine("Two Pair");
            }
            else if (hand.IsPair())
            {
                Console.WriteLine("Pair");
            }
            else
            {
                Console.WriteLine("High Cards");
            }
        }        
    }
}
