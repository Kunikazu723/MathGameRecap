using System;
using System.Collections.Generic;
using System.Numerics;
using static MathGameRecap.Enums;

namespace MathGameRecap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameEngine = new GameEngine();
            var userInterface = new UserInterface(gameEngine);
            userInterface.MainMenu();

            // Challenges

            // TODO - Try to implement levels of difficulty.

            // TODO - Add a timer to track how long the user takes to finish the game.

            // TODO - Create a 'Random Game' option where the players will be presented with questions from random operations

            // TODO - To follow the DRY Principle, try using just one method for all games. Additionally, double check your project and try to find
            //opportunities to achieve the same functionality with less code, avoiding repetition when possible.

        }
    }
}
