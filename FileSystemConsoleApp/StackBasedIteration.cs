using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemConsoleApp
{
    public class StackBasedIteration
    {
        public static void TraverseTree(string root)
        {
            Stack<string> dirs = new Stack<string>(20);
            Stack<string> allDirs = new Stack<string>(20);

            if(!Directory.Exists(root))
            {
                throw new ArgumentException();
            }

            dirs.Push(root);
            allDirs.Push(root);

            while (dirs.Count > 0)
            { 
                string currentDir = dirs.Pop();
                string[] subDirs;
                // 获取当前文件夹下面的所有文件夹
                try
                {
                    subDirs = Directory.GetDirectories(currentDir);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                string[] files = null;
                try
                {
                    files = Directory.GetFiles(currentDir);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                foreach (string file in files)
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        Console.WriteLine("{0} : {1}, {2}", fileInfo.FullName, fileInfo.Length, fileInfo.CreationTime);
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }

                foreach (string dir in subDirs)
                {
                    dirs.Push(dir);
                    allDirs.Push(dir);
                }
            }

            // 打印检索到的文件夹的信息
            Console.WriteLine("All directory count ：{0}", dirs.Count);
            foreach (string dir in allDirs)
            {
                Console.WriteLine(dir);
            }
        }

    }
}
