using System;
namespace IfCondition;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter mark: ");
        double mark=double.Parse(Console.ReadLine());
        if(mark>80 && mark<101){
          Console.WriteLine("Grade A");
        }
        else if(mark>60 && mark<81){

          Console.WriteLine("Grade B"); 
        }
        else if(mark>35 && mark<61){
          Console.WriteLine("Grade C"); 
        }
        else if(mark<36 && mark>0){
          Console.WriteLine("Grade D"); 
        }
        
        else {
           Console.WriteLine("Invalid Input");

        }      
        }
    }
