using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize_First_Letter_of_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> formattedNames = new List<string>();

            Console.WriteLine("Enter 6 full names:");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Name {i + 1}: ");
                string name = Console.ReadLine().Trim();

                while (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    Console.Write($"Name {i + 1}: ");
                    name = Console.ReadLine().Trim();
                }
                names.Add(name);
            }
            foreach (string name in names)
            {
                string[] parts = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Length > 0)
                    {                      
                        parts[i] = char.ToUpper(parts[i][0]) +
                                  (parts[i].Length > 1 ? parts[i].Substring(1).ToLower() : "");
                    }
                }
                formattedNames.Add(string.Join(" ", parts));
            }
            Console.WriteLine("\nFormatted Names (Title Case):");
            foreach (string formattedName in formattedNames)
            {
                Console.WriteLine(formattedName);
            }
        }
    }
}
