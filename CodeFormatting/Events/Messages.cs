using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{  
    internal static class Messages
    {
        static StringBuilder output = new StringBuilder();

        /// <summary>
        /// Add event to the list
        /// </summary>
        public static void EventAdded()
        {
            output.Append("Event added\n");
        }

        /// <summary>
        /// Delete event from the list
        /// </summary>
        /// <param name="x"></param>
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted\n", x);
            }
        }

        /// <summary>
        /// Append "No event"
        /// if there is no added event
        /// </summary>
        public static void NoEventsFound()
        {
            output.Append("No events found\n");
        }

        /// <summary>
        /// Print whole event list
        /// </summary>
        /// <param name="eventToPrint"></param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + "\n");
            }
        }
    }
}
