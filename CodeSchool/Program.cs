// MOL Tutorials
using System;
class Program
{
    static void Main(string[] args)
    {
        string userName;
        string userAge;
        Console.WriteLine("Please provide your name below:");
        userName = Console.ReadLine();
        Console.WriteLine("Please "+userName+" provide your age below:");
        userAge = Console.ReadLine();
        string messageResponse = "Hello "+userName+", You are "+userAge+" years old";
        Console.WriteLine(messageResponse);


        
    }


}
