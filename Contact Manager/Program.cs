using Contact_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        string s;
        do
        {
            Contact contact = new Contact();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("****** Contact Manager Menu ******");
            Console.WriteLine("1 - Add User");
            Console.WriteLine("2 - Edit User");
            Console.WriteLine("3 - Delete User");
            Console.WriteLine("4 - Search Users");
            Console.WriteLine("5 - Show All Users");

            Contact countusers = new Contact();
            int userCount = countusers.CountUsers();
            Console.WriteLine("===> Number of users: " + userCount + " <===");

            Console.WriteLine();

            Console.Write("Enter number of choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (choice)
            {
                case 1:
                    contact.AddUser();
                    break;
                case 2:
                    contact.EditUser();
                    break;
                case 3:
                    contact.DeleteUser();
                    break;
                case 4:
                    contact.SearchUser();
                    break;
                case 5:
                    contact.ShowAll();
                    break;
                default:
                    Console.WriteLine("Unavailable choice. Please try again.");
                    break;
            }
            Console.WriteLine("Do you want to back to Menu ? \n (y/n)");
            s = Console.ReadLine();
        }while (s == "y");
    }
}