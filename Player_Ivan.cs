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
        string response;
        string responseNorm;
        public Player_Ivan()
        {
            

        }

        public char Roshambo()
        {
            string[] arrayR = new string[] { "Rock", "Paper", "Scissors" };
            int rand = rnd.Next(0,3);
            string responseNorm = arrayR[rand];
            response = responseNorm.ToLower();
            char play = response[0];
            return play;
        }
        public string returnname()
        {
            return name;


        }
        public string returnfullplay()
        {

            return responseNorm;

        }




    }
}
