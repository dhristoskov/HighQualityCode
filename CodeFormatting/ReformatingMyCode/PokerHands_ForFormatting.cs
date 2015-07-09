//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;

//namespace PokerHands
//{
//    class Cards
//    {
//        private string face;
//        private string suit;

//        public Cards(string face, string suit)
//        {
//            this.face = face;
//            this.suit = suit;
//        }
//        public string Face
//        {
//            get { return face; }
//        }
//        public string Suit
//        {
//            get { return suit; }
//        }
//        public int FaceValue()
//        {
//            int faceValue;
//            switch (face)
//            {
//                case "A": faceValue = 1; break;
//                case "J": faceValue = 11; break;
//                case "Q": faceValue = 12; break;
//                case "K": faceValue = 13; break;
//                default: faceValue = int.Parse(face); break;
//            }
//            return faceValue;
//        }

//    }
//    class PokerHands
//    {
//        static List<Cards> hand = new List<Cards>();
//        static string[] allSuits = { "C", "D", "H", "S" };
//        static string[] allFaces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

//        static void SortCards()
//        {
//            for (int a = hand.Count - 2; a >= 0; a--)
//            {
//                for (int b = 0; b <= a; b++)
//                {
//                    if (hand[b + 1].FaceValue() < hand[b].FaceValue())
//                    {
//                        Cards c = hand[b + 1];
//                        hand[b + 1] = hand[b];
//                        hand[b] = c;
//                    }
//                }
//            }
//        }
//        static bool Pair()
//        {
//            for (int a = 0; a < 4; a++)
//            {
//                if (hand[a].Face == hand[a + 1].Face)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//        static bool TwoPairs()
//        {
//            int counter = 0;
//            for (int a = 0; a < 4; a++)
//            {
//                if (hand[a].Face == hand[a + 1].Face)
//                {
//                    counter++;
//                }
//            }
//            if (counter == 2)
//            {
//                return true;
//            }
//            return false;
//        }
//        static bool ThreeOfAKind()
//        {
//            for (int a = 0; a < 3; a++)
//            {
//                if (hand[a].Face == hand[a + 1].Face && hand[a].Face == hand[a + 2].Face)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//        static bool FourOfAKind()
//        {
//            for (int a = 0; a < 2; a++)
//            {
//                if (hand[a].Face == hand[a + 1].Face &&
//                    hand[a].Face == hand[a + 2].Face &&
//                    hand[a].Face == hand[a + 3].Face)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//        static bool FullHouse()
//        {
//            int aCounter = 1;
//            int bCounter = 1;
//            for (int a = 1; a < 4; a++)
//            {
//                if (hand[a].Face == hand[0].Face)
//                {
//                    aCounter++;
//                }
//                else if (hand[a].Face == hand[4].Face)
//                {
//                    bCounter++;
//                }
//            }
//            if ((aCounter == 2 && bCounter == 3) || (aCounter == 3 && bCounter == 2))
//            {
//                return true;
//            }
//            return false;
//        }
//        static bool Flush()
//        {
//            if (hand[0].Suit == hand[1].Suit &&
//                hand[1].Suit == hand[2].Suit &&
//                hand[2].Suit == hand[3].Suit &&
//                hand[3].Suit == hand[4].Suit)
//            {
//                return true;
//            }
//            return false;
//        }
//        static bool Straight()
//        {
//            for (int a = 0; a < 4; a++)
//            {
//                if (hand[a + 1].FaceValue() - hand[a].FaceValue() == 1)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//        static bool StraightFlush()
//        {
//            if (Flush())
//            {
//                if (Straight())
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//        static bool RoyalFlush()
//        {
//            if (Flush())
//            {
//                if (hand[0].Face == "A" &&
//                    hand[1].Face == "10" &&
//                    hand[2].Face == "J" &&
//                    hand[3].Face == "Q" &&
//                    hand[4].Face == "K")
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//        static void PrintHands()
//        {
//            if (RoyalFlush()) { Console.WriteLine("Royal Flush"); }
//            else if (StraightFlush()) { Console.WriteLine("Straight Flush"); }
//            else if (FourOfAKind()) { Console.WriteLine("Four of a Kind"); }
//            else if (FullHouse()) { Console.WriteLine("Full House"); }
//            else if (Flush()) { Console.WriteLine("Flush"); }
//            else if (Straight()) { Console.WriteLine("Straight"); }
//            else if (ThreeOfAKind()) { Console.WriteLine("Three of a Kind"); }
//            else if (TwoPairs()) { Console.WriteLine("Two Pair"); }
//            else if (Pair()) { Console.WriteLine("Pair"); }
//            else { Console.WriteLine("High Cards"); }
//        }
//        static void MakeNewEntry()
//        {
//            string[] input = Console.ReadLine().Split();

//            for (int i = 0; i < input.Length; i++)
//            {
//                string[] card = input[i].Split('|');
//                string cardFace = card[0];
//                if (!allFaces.Contains(cardFace))
//                {
//                    Console.WriteLine("Incorrect card-face entry");
//                    Thread.Sleep(2000);
//                    Console.Clear();
//                    MakeNewEntry();
//                }
//                string cardSuit = card[1];
//                if (!allSuits.Contains(cardSuit))
//                {
//                    Console.WriteLine("Incorrect card-suits entry");
//                    Thread.Sleep(2000);
//                    Console.Clear();
//                    MakeNewEntry();
//                }
//                hand.Add(new Cards(cardFace, cardSuit));
//            }
//        }

//        static void Main(string[] args)
//        {
//            example input 10 | H J | C Q | H A | D 2 | S

//            MakeNewEntry();
//            SortCards();
//            PrintHands();
//        }
//    }
//}