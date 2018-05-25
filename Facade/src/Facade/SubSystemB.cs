using System;

namespace Facade
{
    public class SubSystemB
    {
        public string MethodA()
        {
            return $"{nameof(SubSystemB)}.{nameof(MethodA)}";
        }

        public string MethodB()
        {
            return $"{nameof(SubSystemB)}.{nameof(MethodB)}";
        }


    }
}