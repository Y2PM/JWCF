using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFDemo
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string name { get; set; }//serialisable

        //[DataMember]
        //public int numberOfPages { get; set; }

        
    }
}
