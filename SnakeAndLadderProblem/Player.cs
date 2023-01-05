using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class Player
    {
        public static void Pos1()
        {
            Console.WriteLine("Welcome To Snake And Ladder Problem");
            int position = 0, player1;
            Console.WriteLine("Single player at start position", +position);
        }
        public static void RollDice()
        {
            int position = 0;
            while (position < 100)
            {               
            Random random = new Random();
            int dice = random.Next(6);
            dice = dice + 1;
            Console.WriteLine("The Player Rolls The Dice & Get Number:" + dice);          
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 1:
                        position += dice;
                        Console.WriteLine("Ladder");
                        if (position > 100)
                        {
                            position -= dice;
                        }
                        break;
                    case 2:
                        position -= dice;
                        Console.WriteLine("Snake");                      
                        if (position < 0)
                        {
                            position = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("No Play");
                        break;
                }
                Console.WriteLine("Current Position of player is " + position);
            }
        }
    }
}
