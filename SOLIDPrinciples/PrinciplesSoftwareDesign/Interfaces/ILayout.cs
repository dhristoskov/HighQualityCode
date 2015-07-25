using System;

namespace PrinciplesSoftwareDesign.Interfaces
{
    public interface ILayout
    {
        string Format(DateTime date, ReportLevel reportLevel, string message);
    }
}
