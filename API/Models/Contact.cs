using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        
        public int? PersonId { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }
        
        public int? ContactTypeId { get; set; }
        [JsonIgnore]
        public ContactType ContactType { get; set; }

    }
}
