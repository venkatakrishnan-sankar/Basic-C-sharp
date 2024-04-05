using System;
namespace TypeConvertion;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        String name= Console.ReadLine();
        Console.WriteLine("Enter age:");
        int age= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark of subject1:");
        double sub1= double.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark of subject2:");
        double sub2= double.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark of subject3:");
        double sub3= double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Grade:");
        char grade=char.Parse(Console.ReadLine());
        Console.WriteLine("Enter mobile number:");
        long mobileno=long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Mail id:");
        String mailId= Console.ReadLine();
        double average=(sub1+sub2+sub3)/3;
        double total=sub1+sub2+sub3;
        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine("Name:"+name);
        Console.WriteLine("Age:"+age);
        Console.WriteLine("Mobile:"+mobileno);
        Console.WriteLine("Marks1:"+sub1);
        Console.WriteLine("Marks2:"+sub2);
        Console.WriteLine("Marks3:"+sub3);
        Console.WriteLine("Total:"+total);
        Console.WriteLine("Average:"+average);
        Console.WriteLine("Grade:"+grade);
        Console.WriteLine("Mail id:"+mailId);
    }
}