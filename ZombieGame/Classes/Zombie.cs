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
        public event Action<string> Ran;

        string type;


        public Zombie(string ztype)
        {
            type = "a";
        }

        //Активатор Roared
        public void Roar()
        {
            if (Roared != null)//кто-то подписан на событие
            {
                Roared();
            }
        }
        
        //активатор Ran
        public void Run()
        {
            if (Ran != null)
            {
                Ran(type);
            }
        }
    }
}
