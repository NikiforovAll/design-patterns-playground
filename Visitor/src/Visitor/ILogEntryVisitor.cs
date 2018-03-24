using System;
namespace Visitor
{
    public interface ILogEntryVisitor
    {
        void Visit(ExceptionLogEntry logEntry);
        void Visit(SimpleLogEntry logEntry);
    }
}
