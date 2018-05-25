using System;

namespace Facade
{
    public class Facade
    {
        private SubSystemA _module1 = new SubSystemA();
        private SubSystemB _module2 = new SubSystemB();
        
        public string[] MethodA()
        {
            return new string[]{
                _module1.MethodA(),
                _module2.MethodA()
            };
        }

        public string[] MethodB()
        {
            return new string[]{
                _module1.MethodA(),
                _module1.MethodB(),
                _module2.MethodB()
            };
        }
    }
}
