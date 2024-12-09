using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            User alice = new User("Alice", chatMediator);
            User bob = new User("Bob", chatMediator);

            alice.SendMessage("Привет, Боб!", "Bob");

            bob.SendMessage("Привет, Алиса! Как дела?", "Alice");

            alice.ShowMessageHistory();

            bob.ShowMessageHistory();

            Console.WriteLine($"{alice.Name} вышел из чата.");

            Console.ReadLine();
        }
    }
}
