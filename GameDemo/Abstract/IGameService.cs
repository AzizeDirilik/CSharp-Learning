using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGameService
    {
        void Sale(Game game, Player player, Campaign campaign);
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);



    }
}
