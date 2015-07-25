using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrinciplesSoftwareDesign.Interfaces;

namespace PrinciplesSoftwareDesign.Models.Layouts
{
    class SimpleLayout:ILayout
    {
        private const string LogSimpleFormat = "{0} - {1} - {2}";

        public string Format(DateTime date, ReportLevel reportLevel, string message)
        {
            string formattedLog = string.Format(LogSimpleFormat + Environment.NewLine, date, reportLevel, message);

            return formattedLog;
        }
    }
}
