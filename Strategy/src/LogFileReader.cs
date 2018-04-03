using System;
using System.Collections.Generic;

namespace Strategy
{
    public class LogFileReader: ILogReader
    {
        public List<LogEntry> Read() {
            System.Console.WriteLine("LogFileReader invoked");
            return new List<LogEntry>{
                new LogEntry {Message = "LogFileReader.m1"},
                new LogEntry {Message = "LogFileReader.m2"}
            };
        }
    }
}
