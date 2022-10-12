using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemConsoleApp
{
    public class WalkDirectoryTreeTest
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        public static void GetDirFiles(DirectoryInfo root)
        {
            FileInfo[] files = root.GetFiles("*.*");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName);
            }
        }

        public static void WalkDirectoryTree(DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            try
            {
                // 获取当前路径下的文件，可以设置获取文件名称的规则
                //files = root.GetFiles();
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            // 展示获取到的文件名称
            if (files != null)
            {
                Console.WriteLine($"=== 文件夹位置：{root.FullName}");
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.FullName);
                }

                subDirs = root.GetDirectories();

                foreach (DirectoryInfo subDir in subDirs)
                {
                    WalkDirectoryTree(subDir);
                }
            }
        }
    }
}
