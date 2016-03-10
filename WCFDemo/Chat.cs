using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFDemo
{
    [DataContract]
    public class Chat
    {
        [DataMember]
        public string name { get; set; }//serialisable
    }
}
