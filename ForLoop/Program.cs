using System;
namespace ForLoop;
class Program
{
      public static void Main(string[] args)
      { 
        Console.WriteLine("Enter the start number");
        int start=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the end number");
        int end=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=start;i<=end;i++)
        {
           sum=sum+(i*i);
        }
        Console.WriteLine(sum);
      }
}