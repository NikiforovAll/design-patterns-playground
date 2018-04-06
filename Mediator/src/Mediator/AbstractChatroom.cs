using System;

namespace Mediator
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class AbstractChatroom
    {
        public abstract void Register(User user);
        public abstract void Send(string from, string to, string message);

    }
}
