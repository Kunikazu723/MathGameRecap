using MathGameRecap.Interfaces;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameRecap.Models
{
    internal class SubtractionGame : BaseGame, IGame
    {
        public void RunGame()
        {
            int score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < Rounds; i++)
            {
                AnsiConsole.MarkupLine(Helpers.RoundHeader("Subtraction Game", i + 1));

                (firstNumber, secondNumber) = GenerateTwoNumbers(1, 100);

                int result = firstNumber - secondNumber;
                int userResult = AnsiConsole.Ask<int>($"[blue]{firstNumber}[/] [cyan]-[/] [blue]{secondNumber}[/] [cyan]=[/] ");

                if (IsResultCorrect(userResult, result)) score++;

                Helpers.Intermission();
            }
            Helpers.EndGameMessage(score);

        }
    }
}
