using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Roshambo
    {
        static void Main(string[] args)
        {
            Player_User user = new Player_User();
            string name = user.newname();
            bool retry = true;
            while(retry == true)
            {
                int opponentchoice = 10;
                bool test = false;
                char userplay = 'u';
                Console.WriteLine("Welcome to the Rock/Paper/Scissors Game!");

                
                Player_Ivan one = new Player_Ivan();
                Player_Rocky two = new Player_Rocky();
                string fullplay;

                while ((test == false))
                {
                    Console.WriteLine("Please choose which opponent to face \n(1)" + one.returnname() + "\n(2)" + two.returnname());
                    test = int.TryParse(Console.ReadLine(), out opponentchoice);

                }

                do
                {

                    userplay = user.Roshambo();
                    fullplay = user.returnfullplay();

                } while ((userplay != 'r') && (userplay != 's') && (userplay != 'p'));


                Game(userplay, opponentchoice, name, fullplay);
                retry = Continue();
            }
        }

        public static Boolean Continue()
        {
            Console.WriteLine("Play again? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }

        public static void Game(char userplay, int opponentchoice, string name, string fullplay)
        {

            //this is the method that runs through all the different scenerios and sends the output to the console

            Player_User user = new Player_User();
            Player_Ivan one = new Player_Ivan();
            Player_Rocky two = new Player_Rocky();
            string standResponse;
            Console.Clear();



            if (opponentchoice == 2)
            {
                standResponse = name + ", You played " + fullplay + "\n" + two.returnname() + " played " + two.returnfullplay();
                if (two.Roshambo() == userplay)
                {
                    Console.WriteLine(standResponse + "\nit's a draw!");
                }

                if (two.Roshambo() == 'r' && userplay == 's')
                {
                    Console.WriteLine(standResponse + "\n Rock smashes Scissors!\nYou Lose! Sorry!");
                }
                if (two.Roshambo() == 's' && userplay == 'r')
                {

                    Console.WriteLine(standResponse + "\n Scissors cut paper!\nYou Lose! Sorry!");
                }
                if (two.Roshambo() == 's' && userplay == 'p')
                {

                    Console.WriteLine(standResponse + "\nscissors cut paper\nYou Lose! Sorry!");

                }
                if (two.Roshambo() == 'r' && userplay == 'p')
                {
                    Console.WriteLine(standResponse + "\npaper covers rock\nYou Win! Good Job!");
                }
                if (two.Roshambo() == 'p' && userplay == 's')
                {

                    Console.WriteLine(standResponse + "\nscissors cut paper\n You Win! Good Job!");
                }
                if (two.Roshambo() == 'p' && userplay == 'r')
                {

                    Console.WriteLine(standResponse + "\npaper covers rock\n You lose! Sorry!");

                }
                

            }
            if (opponentchoice == 1)
            {
                char onePlay = one.Roshambo();
                string oneFullPlay = null;
                if (onePlay == 'r')
                {
                    oneFullPlay = "Rock";
                }
                if (onePlay == 's')
                {

                    oneFullPlay = "Scissors";

                }
                if (onePlay == 'p')
                {
                    oneFullPlay = "Paper";

                }
                standResponse = name + ", You played " + fullplay + "\n" + one.returnname() + " played " + oneFullPlay;


                if (onePlay == userplay)
                {
                    Console.WriteLine(standResponse + "\nit's a draw!");
                }

                if (onePlay == 'r' && userplay == 's')
                {
                    Console.WriteLine(standResponse + "\nit Rock smashes Scissors!\nYou Lose! Sorry!");
                }
                if (onePlay == 's' && userplay == 'r')
                {

                    Console.WriteLine(standResponse + "\nit Rock smashes Scissors!\nYou Win! Good Job!");
                }
                if (onePlay == 's' && userplay == 'p')
                {

                    Console.WriteLine(standResponse + "\nscissors cut paper\nYou Lose! Sorry!");

                }
                if (onePlay == 'r' && userplay == 'p')
                {
                    Console.WriteLine(standResponse + "\npaper covers rock\nYou Win! Good Job!");
                }
                if (onePlay == 'p' && userplay == 's')
                {

                    Console.WriteLine(standResponse + "\nscissors cut paper\n You Win! Good Job!");
                }
                if (onePlay == 'p' && userplay == 'r')
                {

                    Console.WriteLine(standResponse + "\npaper covers rock\n You lose! Sorry!");

                }



            }
        }
    }
}

