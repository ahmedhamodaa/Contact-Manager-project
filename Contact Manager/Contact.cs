using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace Contact_Manager
{
    public class Contact : User
    {
        public int count { get; set; }
        User user1 = new User();
        public void AddUser()
        {
            try { 
            Console.WriteLine("Enter your new ID: ");
            user1.id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your first name: ");
            user1.firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            user1.lastname = Console.ReadLine();
            Console.WriteLine("Enter your gender: ");
            user1.gender = Console.ReadLine();
            Console.WriteLine("Enter your city: ");
            user1.city = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("User added successfully!");
            addadata(user1);
            }
            catch { 
                Exception e;
                Console.WriteLine("invalid format. Please try again!");
            }

            void addadata(User user1)
            {
                File.AppendAllText("list.txt",
                    "ID: " + user1.id + " / " + 
                    "Name: " + user1.firstname + " " + user1.lastname + " / " + 
                    "Gender: " + user1.gender + " / " + 
                    "City: " + user1.city + " / " + 
                    "Last updated: " + DateTime.Now + "\n");

            }
        }
        public int CountUsers()
        {
            try
            {
                List<string> lines = File.ReadAllLines("list.txt").ToList();
                return lines.Count;
            }
            catch
            {
                Console.WriteLine("invalid format. Please try again!");
                return 0;
            }
        }
        public void EditUser()
        {
            try
            {
                List<string> lines = File.ReadAllLines("list.txt").ToList();
                Console.WriteLine("Enter the ID of the user to edit: ");

                user1.id = Int32.Parse(Console.ReadLine());

                int userIndex = -1;
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].StartsWith($"ID: {user1.id}"))
                    {
                        userIndex = i;
                        break;
                    }
                }

                if (userIndex != -1)
                {
                    Console.WriteLine("Enter new first name: ");
                    string newFirstName = Console.ReadLine();
                    Console.WriteLine("Enter new last name: ");
                    string newLastName = Console.ReadLine();
                    Console.WriteLine("Enter new gender: ");
                    string newGender = Console.ReadLine();
                    Console.WriteLine("Enter new city: ");
                    string newCity = Console.ReadLine();

                    lines[userIndex] = $"" +
                        $"ID: {user1.id} / " +
                        $"Name: {newFirstName} {newLastName} / " +
                        $"Gender: {newGender} / " +
                        $"City: {newCity} / " +
                        $"Last updated: {DateTime.Now}";

                    File.WriteAllLines("list.txt", lines);
                    Console.WriteLine("User updated successfully!");
                }
                else
                {
                    Console.WriteLine("Id of User is not found");
                }
            }
            catch
            {
                Console.WriteLine("Invalid format");
            }
        }
        public void SearchUser()
        {
            int counter = 0;
            string line;

            Console.Write("Input your search text: ");
            var text = Console.ReadLine();

            System.IO.StreamReader file =
                new System.IO.StreamReader("list.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(text))
                {
                    break;
                }

                counter++;
            }

            Console.WriteLine("Line number: {0}", counter);
            Console.WriteLine($"{line}");

            file.Close();

            Console.ReadLine();
        }
        public void DeleteUser()
        {
            try
            {
                Console.Write("Enter ID of user to delete: ");
                user1.id = Int32.Parse(Console.ReadLine());

                List<string> lines = File.ReadAllLines("list.txt").ToList();
                int userIndex = -1;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].StartsWith($"ID: {user1.id}"))
                    {
                        userIndex = i;
                        break;
                    }
                }

                if (userIndex != -1)
                {
                    lines.RemoveAt(userIndex);
                    File.WriteAllLines("list.txt", lines);
                    Console.WriteLine("User deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Id not found");
                }
            }
            catch
            {
                Console.WriteLine("Invalid format");
            }
        }
        public void ShowAll()
        {
            try
            {
                List<string> lines = File.ReadAllLines("list.txt").ToList();

                if (lines.Count > 0)
                {
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("No users found in the list.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid format or file not found.");
            }
        }
    }
}
