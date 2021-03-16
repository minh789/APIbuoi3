using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _DAO_KHAI_MINH_5951071058_.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "fullname")]

        public string Fullname { get; set; }

        [DataMember(Name = "MSV")]

        public long MSV { get; set; }

        [DataMember(Name = "dataTime")]

        public DateTime DateTime { get; set; }
    }
}