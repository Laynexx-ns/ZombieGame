using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieGame.Classes;

namespace ZombieGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Zombie zombie = new Zombie();

            //подписка на событие
            zombie.Roared += player.ReactionOnZombieRoar;


            //активация
            zombie.Roar();

        }
    }
}
