
namespace Visitor
{
    public class SimpleLogEntry: LogEntry
    {
        public SimpleLogEntry() {
        }

        public SimpleLogEntry (LogEntry log): base(log)
	    {
	    }
        public string AdditionalInfo { get; set; }

        public override void Accept(ILogEntryVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}