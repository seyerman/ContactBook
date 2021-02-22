using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Model
{
    public class Contact
    {
        public string Name { get; }
        public string Phone { get; }

        public Contact(string na, string ph)
        {
            Name = na;
            Phone = ph;
        }
    }
}

