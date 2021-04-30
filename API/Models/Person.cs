using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
            Contacts = new List<Contact>();
        }

        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public DateTime BirthDay { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }

}