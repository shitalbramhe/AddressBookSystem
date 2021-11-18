using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        List<Contact> AddressList = new List<Contact>();
        public void AddContact(Contact newcontact)
        {
            AddressList.Add(newcontact);
        }
        public void Display()
        {
            foreach (var contact in AddressList)
            {
                Console.WriteLine("\nfirstname: " + contact.firstname + "\nlastname: " + contact.lastname + "\naddress: " + contact.address + "\ncity: " + contact.city + "\nstate: " + contact.state + "\nzip: " + contact.zip + "\nphoneno: " + contact.phonenumber + "\nemail: " + contact.emailid);
            }
        }
    }
}
