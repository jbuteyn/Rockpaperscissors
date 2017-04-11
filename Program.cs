using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rock/Paper/Scissors Game\nPlease enter your name");
            string username = Console.ReadLine();
            Console.WriteLine("Please choose which opponent to face \n(1) for Rocky\n(2) for Ivan");
            int opponentchoice = int.Parse(Console.ReadLine());
            Console.WriteLine("What would you like to throw \n press 'r' for Rock \n press 'p' for paper\n press 's' for Scissors");
            string userinput = Console.ReadLine();
            char userplay = userinput[0];

            Player_User user = new Player_User(username, userplay);
            Player_Ivan one = new Player_Ivan();
            Player_Rocky two = new Player_Rocky();
            Console.WriteLine(username);
            Console.WriteLine(userplay);
            

            
        }
    }
}
