using System;
namespace Visitor
{
    public abstract class LogEntry
    {
        public DateTime Created { get; set;}
        public String Message { get; set;}
        
        public LogEntry(LogEntry log){
            log.CopyTo(this);
        }

        public LogEntry()
        {
        }

        public abstract void Accept(ILogEntryVisitor visitor);

        public void CopyTo(LogEntry log){
            log.Created = this.Created;
            log.Message = this.Message;
        }
    }
}