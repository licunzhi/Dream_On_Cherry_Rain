using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemConsoleApp
{
    internal class FileOperation
    {
        public static void WirteReadFile()
        {
            string[] lines = new string[] { "First line", "Second line" ,"Third line" };
            // write string info to file
            File.WriteAllLines(@"c:\elixcun\test-folder\wirteLines.txt", lines);

            // write text information to file
            string text = @"A class is the most powerful data type in C#. Like a structure,
            a class defines the data and behavior of the data type.";
            File.WriteAllText(@"c:\elixcun\test-folder\writeText.txt", text);

            // Append text to current file
            using (StreamWriter streamWriter = new(@"c:\elixcun\test-folder\writeText.txt", append: true))
            {
                streamWriter.WriteLine("Append some new txt to this file !");
            }

            // Read from file information
            // Read the file as one string
            string strResult = File.ReadAllText(@"c:\elixcun\test-folder\writeText.txt");
            Console.WriteLine("Read file as one string: {0}", strResult);

            // Read by each line
            string[] fileLines = File.ReadAllLines(@"c:\elixcun\test-folder\writeText.txt");
            Console.WriteLine("Read by line way");
            foreach (string line in fileLines)
            {
               Console.WriteLine(line);
            }

            Console.WriteLine("Read line by line way");
            int counter = 0;
            // Read the file and display it line by line.  
            foreach (string line in File.ReadLines(@"c:\elixcun\test-folder\writeText.txt"))
            {
                System.Console.WriteLine(line);
                counter++;
            }

            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();

        }
    }
}
