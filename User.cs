using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class User
    {
        public string Name { get; }
        private readonly IChatMediator _mediator;
        private readonly List<string> _messageHistory;

        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            _messageHistory = new List<string>();
            mediator.AddUser(this);
        }

        public void SendMessage(string message, string recipientName)
        {
            Console.WriteLine($"{Name} отправляет сообщение '{message}' пользователю {recipientName}");
            _mediator.SendMessage(message, this, recipientName);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            Console.WriteLine($"{Name} получил сообщение от {senderName}: '{message}'");
            _messageHistory.Add($"От {senderName}: {message}");
        }

        public void ShowMessageHistory()
        {
            Console.WriteLine($"История сообщений для {Name}:");
            foreach (var msg in _messageHistory)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
