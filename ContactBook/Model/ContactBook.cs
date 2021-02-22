using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Model
{
    public class ContactBook
    {
        public List<Contact> Contacts { get; }

        public ContactBook()
        {
            Contacts = new List<Contact>();
        }

        public void AddContact(string name,string phone)
        {
            Contact c = new Contact(name,phone);
            Contacts.Add(c);
        }
    }
}
