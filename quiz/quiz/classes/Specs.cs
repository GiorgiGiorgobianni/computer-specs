using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace quiz.classes
{
    public class Computer
    {
        #region private fields
        private int? _memoryCapacity;
        private decimal? _price;
        #endregion
        #region public properties
        public string Name { get; set; }

        public int? MemoryCapacity
        {
            get { return _memoryCapacity; }
            set
            {
                _memoryCapacity = value > 0 ? value : null;
            }
        }

        public decimal? Price
        {
            get { return _price; }
            set
            {
                _price = value > 0 ? value : null;
            }
        }
        #endregion
        #region constructor
        public Computer(string name, int? memoryCapacity, decimal? price)
        {
            Name = name;
            MemoryCapacity = memoryCapacity;
            Price = price;
        }
        #endregion
        #region method to find the pc with the highest price
        public static void FindComputerWithHighestPrice(params Computer[] computers)
        {
            Computer maxPriceComputer = computers[0];
            foreach (var computer in computers)
            {
                if (computer.Price > maxPriceComputer.Price)
                {
                    maxPriceComputer = computer;
                }
            }

            Console.WriteLine("\nComputer with the highest price:");
            DisplayComputerDetails(maxPriceComputer);
        }
        #endregion

        #region find pc with the shortest name
        public static void FindComputerWithShortestName(params Computer[] computers)
        {
            Computer shortestNameComputer = computers[0];
            foreach (var computer in computers)
            {
                if (computer.Name.Length < shortestNameComputer.Name.Length)
                {
                    shortestNameComputer = computer;
                }
            }

            Console.WriteLine("\nMemory of the computer with the shortest name:");
            DisplayComputerMemory(shortestNameComputer);
        }
        #endregion

        #region display details
        private static void DisplayComputerDetails(Computer computer)
        {
            Console.WriteLine($"Name: {computer.Name}");
            Console.WriteLine($"Memory Capacity: {computer.MemoryCapacity} GB");
            Console.WriteLine($"Price: ${computer.Price}");
        }
        #endregion

        #region display computer memory
        private static void DisplayComputerMemory(Computer computer)
        {
            Console.WriteLine($"Memory Capacity: {computer.MemoryCapacity} GB");
        }
        #endregion
    }
    

}
