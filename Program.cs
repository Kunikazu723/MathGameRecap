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
        }
    }
}
