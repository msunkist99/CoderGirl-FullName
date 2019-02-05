using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();

            // TODO: Call a method called FullName that returns their full name.
            string fullName = FullName(firstName, lastName);

            // TODO: Output their full name.
            Console.WriteLine("Your full name is -- " + fullName);

            Console.ReadLine();
        }

        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.

        private static string FullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
    }
}
