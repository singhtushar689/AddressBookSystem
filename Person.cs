using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string city;
        private string state;
        private string zipCode;
        private string email;

        public Person(string firstName, string lastName, string address, string phoneNumber,
            string city, string state, string zipCode, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.email = email;
        }

        public Person(string name, string address, string city, string state, string zipCode, string phoneNum)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNum = phoneNum;
        }

        private static List<Person> personList = new List<Person>();
        private string name;
        private string phoneNum;

        public static void addList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the First name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter the Address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter the PhoneNumber");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter the City Name");
                string city = Console.ReadLine();
                Console.WriteLine("Enter the State Name");
                string state = Console.ReadLine();
                Console.WriteLine("Enter the ZipCode");
                string zipCode = Console.ReadLine();
                Console.WriteLine("Enter the E-mail");
                string email = Console.ReadLine();
            }
        }
        public static void addNewContact(string name, string address, string city, string state, string zipCode, string phoneNum)
        {
            Person addressList = new Person(name, address, city, state, zipCode, phoneNum);
            personList.Add(addressList);
        }
        public static void printList()
        {
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine("firstName" + personList[i].firstName);
                Console.WriteLine("lastName" + personList[i].lastName);
                Console.WriteLine("Address" + personList[i].address);
                Console.WriteLine("PhoneNumber" + personList[i].phoneNumber);
                Console.WriteLine("City" + personList[i].city);
                Console.WriteLine("State" + personList[i].state);
                Console.WriteLine("E-Mail" + personList[i].email);
                Console.WriteLine("ZipCode" + personList[i].zipCode);
            }
        }
    }
}
