using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class Program
    {
        static void Main(string[] args)
        {

            Message msgSMTP = new MessageSMTP(
                "from@mail.dk",
                "Body text",
                "Subject text",
                true
                );
            string toMail = "tomail@mail.dk";
            msgSMTP.SendTo(toMail);

            Console.WriteLine("Send to multiple:");
            string[] toMailArray = new string[2] { "test@test.dk", "test2@mail.dk" };
            msgSMTP.SendTo(toMailArray);

            Console.WriteLine();
            Console.WriteLine();

            Message msgVMessage = new MessageVMessage(
                "from@mail.dk",
                "Body text",
                "Subject text",
                true
                );
            toMail = "tomail@mail.dk";
            msgVMessage.SendTo(toMail);

            Console.WriteLine("Send to multiple:");
            toMailArray = new string[2] { "test@test.dk", "test2@mail.dk" };
            msgVMessage.SendTo(toMailArray);
            Console.ReadKey();

        }
    }
}
