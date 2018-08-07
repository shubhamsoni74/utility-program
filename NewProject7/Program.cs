using System;
using System.Collections.Generic;   
using System.Linq;          
using System.Text;
using System.Threading.Tasks;

namespace NewProject7
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name; int Age; float Marks;

            Console.Write(" Your Name is:");
            Name = Console.ReadLine();
            Console.WriteLine("---");
            Console.Write(" Your Age is:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("---");
            Console.Write(" Your Marks Are:");
            Marks = float.Parse(Console.ReadLine());
            Console.WriteLine("----");
            Console.WriteLine("First Type");
            Console.WriteLine("Your Name is: {0} Your Age is: {1} And your Marks are: {2 }", Name, Age, Marks);
            Console.WriteLine("----");
            Console.WriteLine("Second Type");
            Console.WriteLine("Your Name is:" + Name + "Your Age is:" + Age + "Your Marks are:" + Marks);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();  
        }
    }
}
