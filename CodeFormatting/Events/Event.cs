using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Event : IComparable
    {
        public DateTime date;
        public string title;
        public string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        /// <summary>
        /// CompareTo() for comparing
        /// Events by date,title and location
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> int </returns>
        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);

            int byLocation = this.location.CompareTo(other.location);
            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                return byTitle;
            }
            return byDate;
        }

        /// <summary>
        ///Overriding ToString() method
        /// to print event 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            stringBuilder.Append(" | " + title);
            if (!string.IsNullOrEmpty(location))
            {
                stringBuilder.Append(" | " + location);
            }
            return stringBuilder.ToString();
        }
    }
}
