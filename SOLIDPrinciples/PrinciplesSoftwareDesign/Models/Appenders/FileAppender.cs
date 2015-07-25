using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrinciplesSoftwareDesign.Interfaces;

namespace PrinciplesSoftwareDesign.Models.Appenders
{
    internal class FileAppender : Appender
    {
        public FileAppender(ILayout layout)
            : base(layout)
        {
        }

        public string File { get; set; }

        public override void AppendMessage(DateTime date, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string formattedLogEntry = this.GetFormattedLogEntry(date, reportLevel, message);

                System.IO.File.AppendAllText(File, formattedLogEntry);
            }
        }
    }
}
