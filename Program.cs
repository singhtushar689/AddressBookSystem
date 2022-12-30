namespace AddressBookSystem
{
    public class Program
    {
        private static string? FirstName;
        private static string? LastName;
        private static string? Address;
        private static string? City;
        private static string? MobileNumber;
        private static string? State;
        private static string? ZipCode;
        private static string? Email;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Welcome to AddressBook");
                Console.WriteLine("Choose options given below: /n 1. Create Contacts /n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the FirstName,Lastname,Address,City,State,Mobile,Email & zip");
                        Contact contact = new Contact();
                        {
                            FirstName = Console.ReadLine();
                            LastName = Console.ReadLine();
                            Address = Console.ReadLine();
                            City = Console.ReadLine();
                            MobileNumber = Console.ReadLine();
                            State = Console.ReadLine();
                            ZipCode = Console.ReadLine();
                            Email = Console.ReadLine();
                        };
                        break;
                        case 2:
                        flag = false;
                        break;
                }
            }
        }         
    }
}