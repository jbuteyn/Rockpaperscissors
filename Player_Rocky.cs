using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Player_Rocky : IPlayer
    {
        private char response = 'r';
        private string name = "Rocky";

        public Player_Rocky()
        {



        }
        
        public char output()
        {
            return response;
        }

        public string returnname()
        {
            return name;
        }
    }
}
