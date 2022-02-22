using System;
using NLog;
using NLog.Targets;

namespace TestNlogEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            NLog.LogManager.GetLogger("ApplicationEventLog").Error("Kilroy was here");
        }
    }
}
