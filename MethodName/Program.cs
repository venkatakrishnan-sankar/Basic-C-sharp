using System;
namespace MethodName;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine(multiply(5,10));
        divide(10.4F,4.0588F);
    }
    static double multiply(int a,int b)
    {
        double c=a*b;
        return c;
    }
    static void divide(float a, float b){
        float c=a/b;
        Console.WriteLine(c);  
         
    }
}