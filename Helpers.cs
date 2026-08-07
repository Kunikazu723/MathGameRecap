using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameRecap
{
    internal static class Helpers
    {
        public static Random Rng { get; } = new Random();
        public static void Intermission(bool clearConsole = true)
        {
            AnsiConsole.MarkupLine("Press [blue]Any Key[/] to [green]Continue[/]");
            Console.ReadKey();
            if (clearConsole) Console.Clear();
        }
        public static string RoundHeader(string gameType, int round)
        {
            return $"[green]{gameType}[/] {new string('-', 10)} [bold yellow]ROUND {round}[/]";
        }

        public static void EndGameMessage(int score)
        {
            AnsiConsole.MarkupLine($"Game finished \nFinal Score: {score}");
            Intermission();
        }

        public static (int, int) GenerateTwoNumbers(int lowerBound, int upperBound) => (Rng.Next(lowerBound, upperBound), Rng.Next(lowerBound, upperBound));
        public static bool IsResultCorrect(int userResult, int result)
        {
            if (userResult == result)
            {
                AnsiConsole.MarkupLine($"\n[bold green]YES!! {userResult} is correct!!![/]");
                return true;
            }

            AnsiConsole.MarkupLine($"\n[bold red]NO!![/] [red]{userResult} is inccorrect!!![/]\n[bold yellow]The answer is {result}[/]");
            return false;
        }
    }
}
