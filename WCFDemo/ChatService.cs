using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFDemo
{
    public class ChatService : IChatService
    {
        private List<Chat> _books = new List<Chat>()
        {
            new Chat { name = "This is a message."}
        };

        public List<Chat> GetBooks()
        {
            return _books;
        }
    }
}
