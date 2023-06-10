using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return firstName.ToString() + " " + lastName.ToString() + " " + address.ToString() + " " + city.ToString() + " " + state.ToString() +
             " " + zipcode.ToString() + " " + phoneNumber.ToString() + " " + email.ToString();
        }
        public override bool Equals(Object obj)
        {
            if (obj == null) return false;
            Contact objAsPart = obj as Contact;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(Contact contact)
        {
            if (contact == null) return false;
            return (this.firstName.Equals(contact.firstName));
        }
    }
}