using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrinciplesSoftwareDesign.Interfaces;

namespace PrinciplesSoftwareDesign.Models.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ILayout Layout { get; private set; }
    
        public ReportLevel ReportLevel { get; set; }

        public abstract void AppendMessage(DateTime date, ReportLevel reportLevel, string message);

        protected string GetFormattedLogEntry(DateTime date, ReportLevel reportLevel, string message)
        {
            return this.Layout.Format(date, reportLevel, message);
        }
    }
}
