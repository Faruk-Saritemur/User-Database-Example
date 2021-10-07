using System;

namespace GameProjectDB
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Add(new User { BirthYear = 1995, FirstName = "Faruk", LastName = "Sarıtemur" });
            userManager.Add(new User { BirthYear = 1989, FirstName = "Kadir", LastName = "Akman" });
        }
    }
}
