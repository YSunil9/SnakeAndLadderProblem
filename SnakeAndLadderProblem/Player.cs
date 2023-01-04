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
                Random random = new Random();
                int dice = random.Next(6);
                dice = dice + 1;
                Console.WriteLine("The Player Rolls The Dice & Get Number:" + dice);
            }
        
    }
}
