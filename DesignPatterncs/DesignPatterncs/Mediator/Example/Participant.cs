using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Mediator.Example
{
    //Abstract Colleague
    public class Participant
    {
        public string Name { get; set; }
        private ChatRoom _chatroom;

        public Participant(ChatRoom chat, string name)
        {
            _chatroom = chat;
            Name = name;
        }

        public virtual void Receive(string from,string message)
        {
            Console.WriteLine("("+Name+") " + " Received a message from " + from + " : " + message);
        }

        public void Send(string to, string message)
        {
            _chatroom.Send(Name, to, message);
        }
    }
}
