using System;
namespace ArrayAssignment;
class Program
{
    public static void Main(string[] args)
    {
        String [] array1= new String [5]{"Mani","Ganesh","venkat","suresh","venkat"};
        
        for (int i=0;i<array1.Length;i++){
            Console.WriteLine(array1[i]);
        }
        Console.WriteLine("Enter the name");
        String name = Console.ReadLine();
        int flag=0;
        int temp;
        for (int i=0;i<array1.Length;i++){
            if(name==array1[i]){
             flag=1;
             temp=i;
            }
        }
        if (flag==1){
             Console.WriteLine("The name is present in array");
            Console.WriteLine("The index value of name is:"+temp);
        
        }
        else {
            Console.WriteLine("The name is not presnt in array");
        }    
        }
        
        
    }
