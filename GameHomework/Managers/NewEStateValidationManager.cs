using GameHomework.Entities;
using GameHomework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework.NewFolder
{
    internal class NewEStateValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            Console.WriteLine("Oyuncu yeni sisteme göre değerlendirildi!");
            return true;
        }
    }
}
