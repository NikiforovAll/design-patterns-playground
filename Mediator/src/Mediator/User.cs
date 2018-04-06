using System.Collections.Generic;

namespace Mediator
{
    public class User
    {
        public User(string name)
        {
            Name = name;
        }
        public Chatroom Chatroom {get; set;} 
        public string Name {get;}

        public Stack<(string source, string message)> MessageCache {get; private set;} = new Stack<(string source, string message)>();

        // it is also possible to create interface for recipient aka 'AbstractColleague'
        public void Receive(string from, string message){
            MessageCache.Push((source: from, message: message));
        }
    }
}