using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDB
{
    interface IUserValidationService
    {
        bool Validate(User user);
    }
}
