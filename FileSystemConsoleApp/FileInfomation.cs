using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemConsoleApp
{
    internal class FileInfomation
    {
        public static void TestFileInfo()
        {
            // You can also use System.Environment.GetLogicalDrives to
            // obtain names of all logical drives on the computer.
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");
            Console.WriteLine(di.TotalFreeSpace);
            Console.WriteLine(di.VolumeLabel);

            // Get the root directory and print out some information about it
            DirectoryInfo rootDirInfo = di.RootDirectory;
            Console.WriteLine(rootDirInfo.Attributes.ToString());

            // Get the files in the directory and print out some information about them.
            System.IO.FileInfo[] fileNames = rootDirInfo.GetFiles("*.*");

            foreach (System.IO.FileInfo fi in fileNames)
            {
                Console.WriteLine("{0}: {1}: {2}", fi.Name, fi.LastAccessTime, fi.Length);
            }

            // Validate folder exist and create a new folder
            if (!Directory.Exists(@"C:\elixcun\test-folder"))
            {
                Directory.CreateDirectory(@"C:\elixcun\test-folder");
            }
            string currentDirName = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirName);

            string filePrefix = @"C:\elixcun\test-folder";
            // Combine path method
            string mossPath = Path.Combine(filePrefix, "moss01");
            if (!Directory.Exists(mossPath))
            {
                Directory.CreateDirectory(mossPath);
            }
            else
            {
                Console.WriteLine("Dir already exist");
            }

            // Validate file exist and create a new file
            string filePath = Path.Combine(filePrefix, "moss.txt");
            if (!File.Exists(filePath))
            {
                using(FileStream fs = File.Create(filePath))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("File already exist");
            }

            // Read context from file 
            byte[] bytes = File.ReadAllBytes(filePath);
            foreach (byte b in bytes)
            {
                Console.Write(b + " ");
            }

            // Copy file ： File.Copy() 
            // Set overwrite param, or else get erroe message
            File.Copy(filePath, Path.Combine(filePrefix, "moss01.txt"), true);
            
            // Create a template file and move it to other Directoty or rename file
            File.Copy(filePath, Path.Combine(filePrefix, "moss_wait_move.txt"));
            // If exist file , delete file firstly and move
            if (File.Exists(Path.Combine(filePrefix, "moss02.txt")))
            {
                File.Delete(Path.Combine(filePrefix, "moss02.txt"));
            }
            // move file
            File.Move(Path.Combine(filePrefix, "moss_wait_move.txt"), Path.Combine(filePrefix, "moss02.txt"));

            // Create Directory Info
            Directory.CreateDirectory(Path.Combine(filePrefix, "moss-dir-01"));
            Directory.CreateDirectory(Path.Combine(filePrefix, "moss-dir-02"));

            if (Directory.Exists(Path.Combine(filePrefix, "moss-dir-01")))
            {
                Console.WriteLine("Delete Dir info....");
                Directory.Delete(Path.Combine(filePrefix, "moss-dir-01"));
            }
        }
    }
}
