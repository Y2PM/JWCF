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
            //            J 11566                C    11697                A   11699
            EndpointAddress endpoint = new EndpointAddress("http://trnlon11699:8081/BookShop");
            //EndpointAddress endpoint = new EndpointAddress("http://trnlon11566:8081/BookService");//


            IBookService proxy = ChannelFactory<IBookService>.CreateChannel(new BasicHttpBinding(), endpoint);
            //             Contract                                               Binding            Address
            List<Book> books = proxy.GetBooks();

            foreach (Book book in books)
            {
                Console.WriteLine(book.name);
            }
            Console.ReadLine();
        }
    }
}
