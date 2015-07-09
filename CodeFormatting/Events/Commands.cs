using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal static class Commands
    {
        static EventHolder events = new EventHolder();

        /// <summary>
        /// Main command method
        /// </summary>
        /// <returns></returns>
        public static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command[0] == 'A')
            {
                AddEvent(command); return true;
            }
            if (command[0] == 'D')
            {
                DeleteEvents(command); return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command); return true;
            }
            if (command[0] == 'E')
            {
                return false;
            }
            return false;
        }

        /// <summary>
        /// Print events
        /// </summary>
        /// <param name="command"></param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);
            events.ListEvents(date, count);
        }


        /// <summary>
        /// Delete event from lists
        /// </summary>
        /// <param name="command"></param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            events.DeleteEvents(title);
        }

        /// <summary>
        /// Add new Event
        /// </summary>
        /// <param name="command"></param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;
            GetParameters(command, "AddEvent", out date, out title, out location);
            events.AddEvent(date, title, location);
        }

        /// <summary>
        /// Get parameters from command line
        /// </summary>
        /// <param name="commandForExecution"></param>
        /// <param name="commandType"></param>
        /// <param name="dateAndTime"></param>
        /// <param name="eventTitle"></param>
        /// <param name="eventLocation"></param>
        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = "";
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        /// <summary>
        /// Get DateTime from command line
        /// </summary>
        /// <param name="command"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }
    }
}
    

