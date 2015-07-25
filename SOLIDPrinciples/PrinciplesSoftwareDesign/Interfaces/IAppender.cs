using System;

namespace PrinciplesSoftwareDesign.Interfaces
{
    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        ILayout Layout { get; }

        void AppendMessage(DateTime date, ReportLevel reportLevel, string message);
    }
}
