using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}
