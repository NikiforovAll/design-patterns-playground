using System;

namespace SingletonThreadSafe
{


    // This implementation is thread-safe. The thread takes out a lock on a shared object, and then checks whether or not the instance has been created before creating the instance. This takes care of the memory barrier issue (as locking makes sure that all reads occur logically after the lock acquire, and unlocking makes sure that all writes occur logically before the lock release) and ensures that only one thread will create an instance (as only one thread can be in that part of the code at a time - by the time the second thread enters it,the first thread will have created the instance, so the expression will evaluate to false). Unfortunately, performance suffers as a lock is acquired every time the instance is requested.

    // Note that instead of locking on typeof(Singleton) as some versions of this implementation do, I lock on the value of a static variable which is private to the class. Locking on objects which other classes can access and lock on (such as the type) risks performance issues and even deadlocks. This is a general style preference of mine - wherever possible, only lock on objects specifically created for the purpose of locking, or which document that they are to be locked on for specific purposes (e.g. for waiting/pulsing a queue). Usually such objects should be private to the class they are used in. This helps to make writing thread-safe applications significantly easier.
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
    // As you can see, this is really is extremely simple - but why is it thread-safe and how lazy is it? Well, static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain. Given that this check for the type being newly constructed needs to be executed whatever else happens, it will be faster than adding extra checking as in the previous examples. There are a couple of wrinkles, however:

    // It's not as lazy as the other implementations. In particular, if you have static members other than Instance, the first reference to those members will involve creating the instance. This is corrected in the next implementation.
    // There are complications if one static constructor invokes another which invokes the first again. Look in the .NET specifications (currently section 9.5.3 of partition II) for more details about the exact nature of type initializers - they're unlikely to bite you, but it's worth being aware of the consequences of static constructors which refer to each other in a cycle.
    // The laziness of type initializers is only guaranteed by .NET when the type isn't marked with a special flag called beforefieldinit. Unfortunately, the C# compiler (as provided in the .NET 1.1 runtime, at least) marks all types which don't have a static constructor (i.e. a block which looks like a constructor but is marked static) as beforefieldinit. Also note that it affects performance, as discussed near the bottom of the page.
    public sealed class Singleton1
    {
        private static readonly Singleton1 instance = new Singleton1();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton1()
        {
        }

        private Singleton1()
        {
        }

        public static Singleton1 Instance
        {
            get
            {
                return instance;
            }
        }
    }

    // Here, instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance. This means the implementation is fully lazy, but has all the performance benefits of the previous ones. Note that although nested classes have access to the enclosing class's private members, the reverse is not true, hence the need for instance to be internal here. That doesn't raise any other problems, though, as the class itself is private. The code is a bit more complicated in order to make the instantiation lazy, however.


    public sealed class Singleton2
    {
        private Singleton2()
        {
        }

        public static Singleton2 Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton2 instance = new Singleton2();
        }
    }
    // It's simple and performs well. It also allows you to check whether or not the instance has been created yet with the IsValueCreated property, if you need that.
    public sealed class Singleton3
    {
        private static readonly Lazy<Singleton3> lazy =
            new Lazy<Singleton3>(() => new Singleton3());

        public static Singleton3 Instance { get { return lazy.Value; } }

        private Singleton3()
        {
        }
    }
}
