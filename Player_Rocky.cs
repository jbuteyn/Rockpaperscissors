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
        private string fullResponse = "Rock";
        private string name = "Rocky";

        public Player_Rocky()
        {



        }
        
        public char Roshambo()
        {
            return response;
        }

        public string returnname()
        {
            return name;
        }
        public string returnfullplay()
        {
            return fullResponse;
        }
    }
}
