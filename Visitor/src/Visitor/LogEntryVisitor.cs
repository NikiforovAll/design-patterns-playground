using System;
namespace Visitor { 
    public class LogEntryVisitor: ILogEntryVisitor
    {
        public string State { get; set; }
        public void ProcessLogEntry(LogEntry logEntry)
        {
            logEntry.Accept(this);
        }
        void ILogEntryVisitor.Visit(ExceptionLogEntry exceptionLogEntry)
        {
            State = $"LogEntryVisitor[{nameof(exceptionLogEntry)}]";
        }
        void ILogEntryVisitor.Visit(SimpleLogEntry simpleLogEntry)
        {
            State = $"LogEntryVisitor[{nameof(simpleLogEntry)}]";
        }
    }
}