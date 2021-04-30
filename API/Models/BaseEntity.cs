using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace API.Models
{
    [Serializable]
    [KnownType(typeof(Contact))]
    [KnownType(typeof(ContactType))]
    [DataContract(IsReference = true)]
    public class BaseEntity
    {
        public int Id { get; set; }
    }

}