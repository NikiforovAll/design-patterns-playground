using System;
using System.Collections.Generic;

namespace Strategy
{
    public class WindowsEventLogReader: ILogReader
    {
        public List<LogEntry> Read() {
            System.Console.WriteLine(" WindowsEventLogReader invoked");
            return new List<LogEntry>{
                new LogEntry {Message = "WindowsEventLogReader.m1"}
            };
        }
    }
}
