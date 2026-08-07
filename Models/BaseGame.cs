using Spectre.Console;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameRecap.Models
{
    internal class BaseGame
    {
        protected static Random Rng = new Random();
        protected static int Rounds { get; } = 5;
        protected (int, int) GenerateTwoNumbers(int lowerBound, int upperBound) => (Rng.Next(lowerBound, upperBound), Rng.Next(lowerBound, upperBound));
        protected bool IsResultCorrect(int userResult, int result)
        {
            if (userResult == result)
            {
                AnsiConsole.MarkupLine($"[green]Hooray!! {userResult} is correct!!![/]");
                return true;
            }
            
            AnsiConsole.MarkupLine($"[bold red]NO!![/] [red]{userResult} is inccorrect!!![/]");
            return false;
        }
    }
}
