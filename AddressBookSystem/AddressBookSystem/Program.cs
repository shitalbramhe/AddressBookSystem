using System;

namespace AddressBookSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Contact newcontact = new Contact();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Enter Number to Execute the Address book Program \n1. Create contacts \n2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
 