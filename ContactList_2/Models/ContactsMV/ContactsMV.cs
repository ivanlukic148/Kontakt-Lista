using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactList_2.Models.ContactsMV
{
    public class ContactsMV
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string[] Email { get; set; }
        public string[] PhoneNumbers { get; set; }
        public string[] Tags { get; set; }
    }
}