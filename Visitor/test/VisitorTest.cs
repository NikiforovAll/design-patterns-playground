using System;
using Xunit;
using Visitor;
namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_All()
        {
            var baseEntry = new SimpleLogEntry(){
                Created = DateTime.Now,
                Message = "test"
            };

            var simpleEntry = new SimpleLogEntry(baseEntry)
            {
                AdditionalInfo = "additional"
            };

            var exceptionEntry = new ExceptionLogEntry(baseEntry)
            {
                ExceptionCode = 111
            };
            //it is possible to declare multiple visitors for particular hierarchy of objects
            // for example: PersistentLogEntryVisitors that allows to process LogEntries and save them to storage
            var visitor = new LogEntryVisitor();
            visitor.ProcessLogEntry(simpleEntry);
            Assert.Contains("simple", visitor.State);
            visitor.ProcessLogEntry(exceptionEntry);
            Assert.Contains("exception", visitor.State);
        }
    }
}
