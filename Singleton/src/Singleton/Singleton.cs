using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        // Constructor is 'protected'
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
