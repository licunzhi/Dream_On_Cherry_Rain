// See https://aka.ms/new-console-template for more information
using System;
using OperatorConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Box box1 = new Box();
        Box box2 = new Box();
        Box box3 = new Box();

        // create box1
        box1.SetLength(6.0);
        box1.SetBreadth(7.0);
        box1.SetHeight(5.0);

        // box2
        box2.SetLength(12.0);
        box2.SetBreadth(13.0);
        box2.SetHeight(10.0);

        double volume1 = box1.GetVolume();
        Console.WriteLine($"box1 volume value is : {volume1}");

        double volume2 = box2.GetVolume();
        Console.WriteLine($"box2 volume value is : {volume2}");


        // 18 * 20 * 15 = 5400
        // Got a error action about this , set menthod need to change params name to make
        // the operation success
        box3 = box1 + box2;
        Console.WriteLine($"{box3.GetLength()} - {box3.GetBreadth()} - {box3.GetHeight()}");
        double volume3 = box3.GetVolume();
        Console.WriteLine($"box3 volume value is : {volume3}");

        Console.WriteLine("Test regex fucntion ");
        RegexOperation.TestRegexFunction();
        NumberChanger nc = new NumberChanger(DelegateTest.AddNum);
        int delegateresult = nc(123);
        Console.WriteLine($"delegate result : {delegateresult}");

        NumberChanger nc1 = new NumberChanger(DelegateTest.MinusNum);
        nc += nc1;
        int multiBoardcastResult = nc(12);
        Console.WriteLine($"Multi result is : {multiBoardcastResult}");
    }
}

//delegate method code test
delegate int NumberChanger(int n);
