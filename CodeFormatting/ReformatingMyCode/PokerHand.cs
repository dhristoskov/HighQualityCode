using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReformatingMyCode
{
    public class PokerHand
    {
        //List with all hands in the game
        private readonly List<Cards> _hands;
   
        //List with all posible suits in the game
        private static readonly string[] AllSuits = { "C", "D", "H", "S" };

        //List with all posible faces in the game
        private static readonly string[] AllFaces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public PokerHand()
        {
             this._hands=new List<Cards>();   
        }

        /// <summary>
        /// Sorting cards in hand
        /// </summary>
        public void SortCards()
        {
            for (int a = _hands.Count - 2; a >= 0; a--)
            {
                for (int b = 0; b <= a; b++)
                {
                    if (_hands[b + 1].FaceValue() < _hands[b].FaceValue())
                    {
                        Cards temporaly = _hands[b + 1];
                        _hands[b + 1] = _hands[b];
                        _hands[b] = temporaly;
                    }
                }
            }
        }

        /// <summary>
        /// Check if hand conatin
        /// one pair
        /// </summary>
        /// <returns></returns>
        public bool IsPair()
        {
            for (int a = 0; a < 4; a++)
            {
                if (_hands[a].Face == _hands[a + 1].Face)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check if hand conatin
        /// two pairs
        /// </summary>
        /// <returns></returns>
        public bool IsTwoPairs()
        {
            int counter = 0;
            for (int a = 0; a < 4; a++)
            {
                if (_hands[a].Face == _hands[a + 1].Face)
                {
                    counter++;
                }
            }
            return counter == 2;
        }

        /// <summary>
        /// Check if hand conatin
        /// three cards of same kind
        /// </summary>
        /// <returns></returns>
        public bool IsThreeOfAKind()
        {
            for (int a = 0; a < 3; a++)
            {
                if (_hands[a].Face == _hands[a + 1].Face && _hands[a].Face == _hands[a + 2].Face)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check if hand conatin
        /// four cards of same kind
        /// </summary>
        /// <returns></returns>
        public bool IsFourOfAKind()
        {
            for (int a = 0; a < 2; a++)
            {
                if (_hands[a].Face == _hands[a + 1].Face &&
                    _hands[a].Face == _hands[a + 2].Face &&
                    _hands[a].Face == _hands[a + 3].Face)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check if hand conatin
        /// two cards of
        /// same kind and another
        /// three cards of same kind
        /// </summary>
        /// <returns></returns>
        public bool IsFullHouse()
        {
            int firstCounter = 1;
            int secondCounter = 1;
            for (int a = 1; a < 4; a++)
            {
                if (_hands[a].Face == _hands[0].Face)
                {
                    firstCounter++;
                }
                else if (_hands[a].Face == _hands[4].Face)
                {
                    secondCounter++;
                }
            }
            return (firstCounter == 2 && secondCounter == 3) 
                   || (firstCounter == 3 && secondCounter == 2);
        }

        /// <summary>
        /// Check if five cards have 
        /// same suit color
        /// </summary>
        /// <returns></returns>
        public bool IsFlush()
        {
            return _hands[0].Suit == _hands[1].Suit &&
                   _hands[1].Suit == _hands[2].Suit &&
                   _hands[2].Suit == _hands[3].Suit &&
                   _hands[3].Suit == _hands[4].Suit;
        }

        /// <summary>
        /// Check if hand contain
        /// cards with increasing value
        /// </summary>
        /// <returns></returns>
        public bool IsStraight()
        {
            for (int a = 0; a < 4; a++)
            {
                if (_hands[a + 1].FaceValue() - _hands[a].FaceValue() != 1)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Check if hand is
        /// Straight and Flush
        /// same time
        /// </summary>
        /// <returns></returns>
        public bool IsStraightFlush()
        {
            if (IsFlush())
            {
                if (IsStraight())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check if hand is Flush 
        /// and contain Straight highest
        /// card in the game
        /// </summary>
        /// <returns></returns>
        public bool IsRoyalFlush()
        {
            if (IsFlush())
            {
                if (_hands[0].Face == "A" &&
                    _hands[1].Face == "10" &&
                    _hands[2].Face == "J" &&
                    _hands[3].Face == "Q" &&
                    _hands[4].Face == "K")
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Make cards entry
        /// split by '|'
        /// </summary>
        public void MakeNewEntry()
        {
            string readLine = Console.ReadLine();
            if (readLine != null)
            {
                string[] input = readLine.Split();

                foreach (string card in input)
                {
                    string[] cards = card.Split('|');
                    string cardFace = cards[0];
                    if (!AllFaces.Contains(cardFace))
                    {
                        Console.WriteLine("Incorrect card-face entry");
                        Thread.Sleep(2000);
                        Console.Clear();
                        MakeNewEntry();
                    }
                    string cardSuit = cards[1];
                    if (!AllSuits.Contains(cardSuit))
                    {
                        Console.WriteLine("Incorrect card-suits entry");
                        Thread.Sleep(2000);
                        Console.Clear();
                        MakeNewEntry();
                    }
                    _hands.Add(new Cards(cardFace, cardSuit));
                }
            }
        }
    }
}
