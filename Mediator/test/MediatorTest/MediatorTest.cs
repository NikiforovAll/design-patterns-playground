using System;
using Xunit;
using Mediator;

namespace MediatorTest
{
    public class MediatorTest
    {
        [Fact]
        public void Test1()
        {
            var users = new[]
            {
                new User(name: "Foo1"),
                new User(name: "Foo2"),
                new User(name: "Foo3")
            };

            (string from, string to, string message)[] messagePlan =
            {
                ("Foo1", "Foo2", "msg1"),
                ("Foo2", "Foo3", "msg2"),
                ("Foo3", "Foo1", "msg3")
            };

            Chatroom room = new Chatroom();
            foreach (var user in users)
            {
                room.Register(user);
            }

            foreach (var message in messagePlan)
            {
                room.Send(message.from, message.to, message.message);
            }
            var userUnderTest = users[0];
            Assert.Equal(1, userUnderTest.MessageCache.Count);
            Assert.Contains("msg3", userUnderTest.MessageCache.Peek().message);
        }
    }
}
