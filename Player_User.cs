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
        char input;
        public Player_User(string name, char input)
        {
            this.name = name;
            this.input = input;


        }
        public char output()
        {
            return input;
        }
        public string returnname()
        { 

            return name;
        }

    }
}
