using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users;

        public ChatMediator()
        {
            _users = new List<User>();
        }

        public void SendMessage(string message, User sender, string recipientName)
        {
            User recipient = _users.Find(u => u.Name == recipientName);
            if (recipient != null)
            {
                recipient.ReceiveMessage(message, sender.Name);
            }
            else
            {
                Console.WriteLine($"Пользователь {recipientName} не найден");
            }
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"{user.Name} присоединился к чату");
        }
    }
}
