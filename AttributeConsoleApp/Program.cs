// See https://aka.ms/new-console-template for more information
using AttributeConsoleApp;
using System.Data;

Console.WriteLine("Hello, World!");

MyClass my = new MyClass();
Type type = my.GetType();
Object[] obj = type.GetCustomAttributes(false);

foreach (Attribute a in obj)
{
    // 关键字as， 功能为强制类型转换。as关键字在转换失败的时候会返回null
    MyAttributeAttribute? attr = a as MyAttributeAttribute;
    if (attr != null)
    {
        Console.WriteLine("Description : {0}", attr.Description);
        Console.WriteLine("ver : {0}", attr.Version);
        Console.WriteLine("review: {0}", attr.Reviewer);
    }
}