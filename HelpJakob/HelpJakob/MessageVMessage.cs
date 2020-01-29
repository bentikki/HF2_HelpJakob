using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public class MessageVMessage : Message
    {
        public MessageVMessage(string from, string body, string subject, bool html, string cc = null) : base(from, body, subject, html, cc)
        {
        }

        protected override void sendMessageOut(string to)
        {
            Console.WriteLine("Sending VMessage from " + this.From + " to " + to);
        }

    }
}
