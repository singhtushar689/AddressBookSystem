using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
       List<Contact> addressList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            addressList.Add(contact);
        }
        public void Display(string text)
        {
            foreach (Contact contact in addressList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
                Console.WriteLine(contact.Address + " " + contact.Address);
                Console.WriteLine(contact.City + " " + contact.City);
                Console.WriteLine(contact.State + " " + contact.State);
                Console.WriteLine(contact.MobileNumber + " " + contact.MobileNumber);
                Console.WriteLine(contact.Email+ " " + contact.Email);
                Console.WriteLine(contact.ZipCode+ " " + contact.ZipCode);
                Console.WriteLine("Contact is added Successfully");
            }
        }

        internal void Display()
        {
            throw new NotImplementedException();
        }
    }
}
