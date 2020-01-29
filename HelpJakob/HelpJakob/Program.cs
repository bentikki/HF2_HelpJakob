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
            List<Message> msgList = new List<Message>();
            Message msgSMTP = new MessageSMTP(
                "from@mail.dk",
                "Body text",
                "Subject text",
                true
                );
            Message msgVMessage = new MessageVMessage(
                "from@mail.dk",
                "Body text",
                "Subject text",
                true
                );
            msgList.Add(msgSMTP);
            msgList.Add(msgVMessage);


            string toMail = "tomail@mail.dk";
            string[] toMailArray = new string[2] { "test@test.dk", "test2@mail.dk" };


            foreach (Message msg in msgList)
            {
                Console.WriteLine("Send to Single:");
                msg.SendTo(toMail);

                Console.WriteLine("Send to multiple:");
                msg.SendTo(toMailArray);

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
