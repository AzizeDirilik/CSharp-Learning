using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool PlayerIfRealPerson(Player player)
        {

            return true;
        }
    }
}
