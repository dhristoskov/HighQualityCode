﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrinciplesSoftwareDesign.Interfaces;

namespace PrinciplesSoftwareDesign
{
    class Logger:ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public ICollection<IAppender> Appenders { get; private set; }

        public void Info(string message)
        {
            this.LogMessage(ReportLevel.Info, message);
        }

        public void Warn(string message)
        {
            this.LogMessage(ReportLevel.Warning, message);
        }

        public void Error(string message)
        {
            this.LogMessage(ReportLevel.Error, message);
        }

        public void Critical(string message)
        {
            this.LogMessage(ReportLevel.Critical, message);
        }

        public void Fatal(string message)
        {
            this.LogMessage(ReportLevel.Fatal, message);
        }

        private void LogMessage(ReportLevel reportLevel, string message)
        {
            DateTime date = DateTime.Now;

            foreach (var appender in this.Appenders)
            {
                appender.AppendMessage(date, reportLevel, message);
            }
        }
    }
}
