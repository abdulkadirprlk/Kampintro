using GameHomework.Entities;
using GameHomework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework.NewFolder
{
    
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        List<Gamer> gamers = new List<Gamer>();
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " : Oyuncu kaydedildi!");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " : Oyuncu silindi!");
        }

        public void List()
        {
            Console.WriteLine("Mevcut Oyuncular:");
            foreach (var gamer in gamers)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName);
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " : Oyuncu güncellendi!");
        }

    }
}
