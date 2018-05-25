using System;

namespace Facade
{
    public class SubSystemA
    {
        public string MethodA()
        {
            return $"{nameof(SubSystemA)}.{nameof(MethodA)}";
        }

        public string MethodB()
        {
            return $"{nameof(SubSystemA)}.{nameof(MethodB)}";
        }


    }
}