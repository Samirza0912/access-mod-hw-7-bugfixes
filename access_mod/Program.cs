using System;
using access_mod.Models;

namespace access_mod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //UserClass user = new UserClass();
            //user.age; user.username; user.password;
            //user.age = 20;
            //user.username = "bukayoooooo";
            //user.password = "Bukayoooooo7";
            //user.username = "abcd";
            Console.WriteLine("Please write your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please write your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write your password");
            string password = Console.ReadLine();
            UserClass user = new UserClass(username, password);
            user.Info();





        }
    }
}
