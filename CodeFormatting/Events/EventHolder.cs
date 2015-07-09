using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Events
{
    internal class EventHolder
    {
        private readonly MultiDictionary<string, Event> _byTitle = new MultiDictionary<string, Event>(true);
        private readonly OrderedBag<Event> _byDate = new OrderedBag<Event>();

        /// <summary>
        /// Create object ofType(Event)
        /// and add it to OrderedBag and MultiDictionary
        /// </summary>
        /// <param name="date"></param>
        /// <param name="title"></param>
        /// <param name="location"></param>
        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            _byTitle.Add(title.ToLower(), newEvent);
            _byDate.Add(newEvent);
            Messages.EventAdded();
        }

        /// <summary>
        /// Delete Event from
        ///  OrderedBag and MultiDictionary
        /// </summary>
        /// <param name="titleToDelete"></param>
        public void DeleteEvents(string titleToDelete)
        {
            int removed = 0;
            string title = titleToDelete.ToLower();

            foreach (var eventToRemove in _byTitle[title])
            {
                removed++;
                _byDate.Remove(eventToRemove);
            }
            _byTitle.Remove(title);
            Messages.EventDeleted(removed);
        }


        /// <summary>
        /// Print Event
        /// </summary>
        /// <param name="date"></param>
        /// <param name="count"></param>
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View
            eventsToShow = _byDate.RangeFrom(new Event(date, "", ""), true);
            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }
                Messages.PrintEvent(eventToShow);
                showed++;
            }
            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
