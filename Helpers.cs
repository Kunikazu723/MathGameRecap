using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameRecap
{
    internal class Helpers
    {
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
    }
}
