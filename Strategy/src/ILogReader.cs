using System;
using System.Collections.Generic;

namespace Strategy
{
    public interface ILogReader
    {
        List<LogEntry> Read();
    }
}
