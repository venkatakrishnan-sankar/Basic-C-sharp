using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        int count=1;
        while(count<=25)
        {
            if(count %2 ==0)
            {
                Console.WriteLine(count);
            }
        count++;
        }

        Console.WriteLine("Enter the valid number");
        bool isValid=int.TryParse(Console.ReadLine(),out int output);
        while(!isValid)
        {
            Console.WriteLine("Invalid number. Enter again");
            isValid=int.TryParse(Console.ReadLine(),out output);

        }
    }
}