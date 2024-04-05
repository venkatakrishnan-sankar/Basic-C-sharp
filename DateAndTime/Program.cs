using System;
namespace DateAndTime;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Parse(Console.ReadLine());
                Console.WriteLine(date.ToString("yyyy"));
    
        DateTime date= DateTime.TryParse(Console.ReadLine(),out date);
       Console.WriteLine(date.Year);
       Console.WriteLine(date.Date);
       Console.WriteLine(date.ToString("MM"));
       Console.WriteLine(date.ToString("dd"));
       Console.WriteLine(date.ToString("hh"));
       Console.WriteLine(date.ToString("mm"));
       Console.WriteLine(date.ToString("ss"));
       Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm:ss tt"));
       DateTime date= DateTime.TryParse(Console.ReadLine() out date);
    }
}