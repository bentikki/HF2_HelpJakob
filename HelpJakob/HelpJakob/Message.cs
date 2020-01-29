using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public abstract class Message
    {
        protected string to, from, body, subject, cc;
        protected string[] toAll;
        protected bool html;

        public string To { get { return this.to; } }
        public string From { get { return this.from; } }
        public string Body { get { return this.body; } }
        public string Subject { get { return this.subject; } }
        public string Cc { get { return this.cc; } }
        public bool HTML { get { return this.html; } }
        public string[] ToAll { get { return this.toAll; } }

        public Message(string from, string body, string subject, bool html, string cc = null)
        {
            this.to = to;
            this.from = from;
            this.subject = subject;
            this.cc = cc;
            this.html = html;
            if (html)
            {
                ConvertText convert = new ConvertText();
                body = convert.ToHTML(body);
            }
            this.body = body;

        }

        public virtual void SendTo(string to)
        {
            this.to = to;
            sendMessageOut(to);
        }

        public virtual void SendTo(string[] to)
        {
            this.toAll = to;
            for (int i = 0; i < to.Length; i++)
            {
                sendMessageOut(to[i]);
            }
        }

        protected abstract void sendMessageOut(string sendTo);

    }
}
