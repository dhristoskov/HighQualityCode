using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReformatingMyCode
{
    public class Cards
    {
        private string _face;
        private string _suit;

        public Cards(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        public string Face
        {
            get { return this._face; }
            set { this._face = value; }
        }

        public string Suit
        {
            get { return this._suit; }
            set { this._suit = value; }
        }

        /// <summary>
        /// Calculate the value
        /// of card face
        /// </summary>
        /// <returns></returns>
        public int FaceValue()
        {
            int faceValue;
            switch (this.Face)
            {
                case "A": faceValue = 1;
                    break;
                case "J": faceValue = 11;
                    break;
                case "Q": faceValue = 12;
                    break;
                case "K": faceValue = 13;
                    break;
                default: faceValue = int.Parse(this.Face);
                    break;
            }
            return faceValue;
        }
    }
}
