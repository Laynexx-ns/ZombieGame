using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ZombieGame.Classes
{
    public class Player
    {
        //обработчики событий
        public void ReactionOnZombieRoar()
        {
            Console.WriteLine("Player: АА!");
        }
        public void ReactionOnZombieRun(string zombieType)
        {
            Console.WriteLine($"Player: Зомби идет, тип: {zombieType}");
        }

        public void RactionOnZombieStop(Zombie zombie)
        {
            Console.WriteLine("Player: zombie has been stoped");
        }

    }
}
