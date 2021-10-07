using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDB
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.BirthYear == 1995 && user.FirstName == "Faruk" 
                && user.LastName == "Sarıtemur")
            {
                return true;
            }
            else
            {
                Console.Write("Doğrulama başarısız ");
                return false;
            }
        }
    }
}
