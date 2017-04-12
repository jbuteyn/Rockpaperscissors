using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
    {
    class Player_User : IPlayer
    {
        string name;
        char roshambo;
        string response;
        public Player_User()
        {
            


        }
        public string newname()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            return name;
        }
        public char Roshambo()
        {
            Console.WriteLine("What would you like to throw?\nRock, Paper, or Scissors");
            response = Console.ReadLine();
            string responseTwo = response.ToLower();
            roshambo = responseTwo[0];
            return roshambo;
        }
        public string returnname()
        { 

            return name;
        }
        public char returninput()
        {

            return roshambo;

        }
        public string returnfullplay()
        {
            return response;

        }
        
 


    }

    }

