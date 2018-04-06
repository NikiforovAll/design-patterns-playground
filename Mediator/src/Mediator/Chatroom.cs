using System.Collections.Generic;
namespace Mediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    public class Chatroom : AbstractChatroom
    {
        private Dictionary<string, User> _users = new Dictionary<string, User>();
        public override void Register(User user)
        {
            if (!_users.ContainsValue(user))
            {
                _users[user.Name] = user;
            }
            user.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            User participant = _users[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
            else
            {
                throw new KeyNotFoundException("User not found");
            }
        }
    }
}