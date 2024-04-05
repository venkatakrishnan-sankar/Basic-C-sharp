using System;
namespace SwitchCase;
class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter the data1:");
      double data1=double.Parse(Console.ReadLine());
      Console.WriteLine("Enter the data2:");
      double data2=double.Parse(Console.ReadLine()); 
      Console.WriteLine("Enter the Operation:");
      char option=char.Parse(Console.ReadLine());
      switch(option)
      {
        case '+':
        {
           double result=data1+data2;
           Console.WriteLine(result);
           break;
        }
        case '-':
        {
           double result=data1-data2;
           Console.WriteLine(result);
           break;
        }
        case '*':
        {
           double result=data1*data2;
           Console.WriteLine(result);
           break;
        }
        case '/':
        {
           double result=data1/data2;
           Console.WriteLine(result);
           break;
        }
        case '%':
        {
           double result=data1%data2;
           Console.WriteLine(result);
           break;
    
        }
        default :
        {
            Console.WriteLine("Operation is Invalid");
            break;
        }
         
      }
      

    }
}