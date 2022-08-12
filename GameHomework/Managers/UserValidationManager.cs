using GameHomework.Entities;
using GameHomework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework.NewFolder
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "ABDULKADİR" && gamer.LastName == "PARLAK" && gamer.NationalityId == 12345 && gamer.BirthYear == 2003)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
