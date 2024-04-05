using System;
namespace DoWhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        String option=String.Empty;
        
        do{
           Console.WriteLine("Enter the number");
           int number=int.Parse(Console.ReadLine());
           if(number % 2 ==0){
            Console.WriteLine("The given number is even");
            
           }
           else {
            Console.WriteLine("The given number is odd");
           }
           
           Console.WriteLine("To check another number Yes or No ");
           option=Console.ReadLine();
           if (option !="yes" && option !="no")
           {
            Console.WriteLine("Input is wrong and enter valid input");
            option= Console.ReadLine();

           }
        }while(option=="yes");
    }
}