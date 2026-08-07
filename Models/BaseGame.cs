using Spectre.Console;
using static MathGameRecap.Enums;

namespace MathGameRecap.Models
{
    internal abstract class BaseGame
    {
        protected static int Rounds { get; } = 5;

        protected abstract GameType Type { get; }

        protected abstract int PerformOperation(int a, int b);
        protected abstract (int, int) GenerateOperands();


        public void RunGame()
        {
            int score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < Rounds; i++)
            {
                AnsiConsole.MarkupLine(Helpers.RoundHeader("Addition Game", i + 1));

                (firstNumber, secondNumber) = GenerateOperands();

                int result = PerformOperation(firstNumber, secondNumber);
                int userResult = AnsiConsole.Ask<int>($"[blue]{firstNumber}[/] [cyan]{Enums.GameTypeToSymbol(Type)}[/] [blue]{secondNumber}[/] [cyan]=[/] ");

                if (Helpers.IsResultCorrect(userResult, result)) score++;

                Helpers.Intermission();
            }
            Helpers.EndGameMessage(score);
            MockDatabase.AddGame(
                id: MockDatabase.GetNextId(),
                score: score,
                operation: Type
                );

        }
    }
}
