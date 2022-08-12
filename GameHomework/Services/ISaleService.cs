using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework.Services
{
    internal interface ISaleService
    {
        void Sell(Game game, Gamer gamer,Campaign campaign);
    }
}
