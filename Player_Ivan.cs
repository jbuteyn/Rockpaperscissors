using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Player_Ivan : IPlayer
    {
        Random rnd = new Random();
        private string name = "Ivan";
        

        public Player_Ivan()
        {
            

        }

        public char output()
        {
            string response = "RPS";
            int rand = rnd.Next(1,3);
            char play = response[rand];

            return play;
        }
        public string returnname()
        {
            return name;


        }




    }
}
