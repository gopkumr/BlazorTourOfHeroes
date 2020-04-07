using System.Collections.Generic;

namespace TourofHeroes
{
    public class MessageService
    {
        public MessageService()
        {
            Messages = new List<string>();
        }

        public List<string> Messages { get; set; }

        public void Add(string message)
        {
            Messages.Add(message);
        }

        public void Clear()
        {
            Messages.Clear();
        }

    }
}
