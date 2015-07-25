using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrinciplesSoftwareDesign.Interfaces;

namespace PrinciplesSoftwareDesign.Models.Appenders
{
    internal class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void AppendMessage(DateTime date, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string formattedLogEntry = this.GetFormattedLogEntry(date, reportLevel, message);

                Console.Write(formattedLogEntry);
            }
        }
    }
}
