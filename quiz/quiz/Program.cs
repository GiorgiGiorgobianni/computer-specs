using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using quiz.classes;


namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details for Computer 1:");
            Computer comp1 = CreateComputerFromUserInput();

            Console.WriteLine("\nEnter details for Computer 2:");
            Computer comp2 = CreateComputerFromUserInput();

            Console.WriteLine("\nEnter details for Computer 3:");
            Computer comp3 = CreateComputerFromUserInput();

            
            Console.WriteLine("\nDetails of Computer 1:");
            DisplayComputerDetails(comp1);

            Console.WriteLine("\nDetails of Computer 2:");
            DisplayComputerDetails(comp2);

            Console.WriteLine("\nDetails of Computer 3:");
            DisplayComputerDetails(comp3);

            
            Computer.FindComputerWithHighestPrice(comp1, comp2, comp3);

            
            Computer.FindComputerWithShortestName(comp1, comp2, comp3);
        }

        static Computer CreateComputerFromUserInput()
        {
            Console.Write("Enter computer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter memory capacity (in GB): ");
            int memoryCapacity = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            return new Computer(name, memoryCapacity, price);
        }

        static void DisplayComputerDetails(Computer computer)
        {
            Console.WriteLine($"Name: {computer.Name}");
            Console.WriteLine($"Memory Capacity: {computer.MemoryCapacity} GB");
            Console.WriteLine($"Price: ${computer.Price}");
        }
    }
}
