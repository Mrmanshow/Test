using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users() { UserName = "zhou", Password = "123qwe" };

            Console.WriteLine($"Hello { user.UserName }!");
        }
    }
}
