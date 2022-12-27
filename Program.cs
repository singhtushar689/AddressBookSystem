namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBoook");
            //Person person1= new Person("name", "address", "city", "state", "zipCode", "phoneNum");
            Console.WriteLine("Enter initial num of Address");
            int n =Convert.ToInt32(Console.ReadLine());
            Person.addList(n);
            Person.printList();
        }   
           
    }
}