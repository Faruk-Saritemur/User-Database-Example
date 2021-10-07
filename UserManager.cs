using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDB
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user))
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
            
        }
        public void Delete(User user)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
