namespace Visitor 
{
    public class ExceptionLogEntry : LogEntry
    {
        public ExceptionLogEntry(LogEntry log):base(log)
	    {
	    }

        public int ExceptionCode { get; set; }

        public override void Accept(ILogEntryVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
