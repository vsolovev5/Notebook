using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ContactType
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
