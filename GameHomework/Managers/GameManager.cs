using GameHomework.Entities;
using GameHomework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework.Managers
{
    internal class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " : Oyun kaydedildi!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " : Oyuncu silindi!");
        }

        public void List()
        {
            Console.WriteLine("Oyunlar:");
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName);
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " : Oyuncu güncellendi!");
        }
    }
}
