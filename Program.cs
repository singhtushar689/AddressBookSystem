namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBoook");
            Console.WriteLine("Enter Number of Contacts you want to enter");
            int n =Convert.ToInt32(Console.ReadLine());
            Person.addList(n);
            Person.addNewContact("name","address","city","state","zipCode","phoneNum");
            Person.printList();
        }         
    }
}