// See https://aka.ms/new-console-template for more information
using FileSystemConsoleApp;

System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
Console.WriteLine("Hello, World!");

// wirte and read operation
FileOperation.WirteReadFile();

// 文件系统信息获取
//FileInfomation.TestFileInfo();


// 借助堆栈对象
/*StackBasedIteration.TraverseTree("C:\\Users\\elixcun\\database");*/


// 适应性测试获取指定文件夹下面的文件内容
/*DirectoryInfo dir = new DirectoryInfo("C:\\Users\\elixcun\\drawio");
WalkDirectoryTreeTest.GetDirFiles(dir);*/


/*
 测试代码： 文档中介绍的demo，扫描的面积太大看不出效果

string[] drives = System.Environment.GetLogicalDrives();
Console.WriteLine("========== Drivers info ==========");
foreach (string drive in drives)
{ 
    Console.WriteLine(drive);
}

foreach (string dr in drives)
{
    System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

    // Here we skip the drive if it is not ready to be read. This
    // is not necessarily the appropriate action in all scenarios.
    if (!di.IsReady)
    {
        Console.WriteLine("The drive {0} could not be read", di.Name);
        continue;
    }
    System.IO.DirectoryInfo rootDir = di.RootDirectory;

    WalkDirectoryTree(rootDir);
}

// 循环方法进行查询子目录中得文件信息
void WalkDirectoryTree(DirectoryInfo root)
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
        foreach(FileInfo file in files)
        {
            Console.WriteLine(file.FullName);
        }

        subDirs = root.GetDirectories();

        foreach(DirectoryInfo subDir in subDirs)
        {
            WalkDirectoryTree(subDir);
        }
    }
}
 
 
 */