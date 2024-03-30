using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieGame.Classes
{
    public class Zombie
    {
        public event Action Roared;

        public void Roar()
        {
            if (Roared != null)//кто-то подписан на событие
            {
                Roared();
            }
        }
    }
}
