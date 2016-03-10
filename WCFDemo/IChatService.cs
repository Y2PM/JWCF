using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFDemo
{
    [ServiceContract]//Makes even more public
    public interface IChatService
    {
        [OperationContract]//Can be used as part of contract
        List<Chat> GetBooks();
    }
}
