using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework.Services
{
    internal interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
        void List();
    }
}
