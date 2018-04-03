using System;
using System.Collections.Generic;
using Xunit;
using Strategy;
namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_All()
        {
            ILogReader logReader;
            logReader = new LogFileReader();
            List<LogEntry> logEntryList1 = logReader.Read();
            Assert.Equal(2, logEntryList1.Count);
            Assert.Contains("LogFileReader", logEntryList1[0].Message);
            //changed behavior at runtime
            logReader = new WindowsEventLogReader();
            List<LogEntry> logEntryList2 = logReader.Read();
            Assert.Single(logEntryList2);
            Assert.Contains("LogFileReader", logEntryList1[0].Message);
        }
    }
}
