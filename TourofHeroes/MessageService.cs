using System.Collections.Generic;

namespace TourofHeroes
{
    public class MessageService
    {
        public List<string> Messages { get; }

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
