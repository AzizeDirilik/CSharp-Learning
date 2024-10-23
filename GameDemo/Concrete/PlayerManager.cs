using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager (IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if (_playerCheckService.PlayerIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " isimli oyuncu eklendi");

            }else
            {
                throw new Exception("Hata");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " isimli oyuncu silindi");

        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " isimli oyuncu guncellendi");
        }
    }
}
