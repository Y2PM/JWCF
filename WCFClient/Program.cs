using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDemo;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //            J 11566             C    11697             A   11699    ada 11675    abel 11603

            //EndpointAddress endpoint = new EndpointAddress("http://trnlon11699:11675");//ada

            //EndpointAddress endpoint = new EndpointAddress("http://trnlon11697:8081/BookShop");//Cemal

            //EndpointAddress endpoint = new EndpointAddress("http://trnlon11603:8081/BookShop");//abel

            EndpointAddress endpoint = new EndpointAddress("http://trnlon11566:8081/ChatService");//Joe


            IChatService proxy = ChannelFactory<IChatService>.CreateChannel(new BasicHttpBinding(), endpoint);
            //             Contract                                               Binding            Address
            List<Chat> books = proxy.GetBooks();

            foreach (Chat book in books)
            {
                Console.WriteLine(book.name);
            }
            Console.ReadLine();
        }
    }
}
