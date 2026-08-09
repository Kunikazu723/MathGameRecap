using Spectre.Console;
using static MathGameRecap.Enums;

namespace MathGameRecap.Models
{
    internal abstract class BaseGame
    {
        protected static int Rounds { get; } = 5;

        internal abstract GameType Type { get; }

        internal abstract int PerformOperation(int a, int b);
        internal abstract (int, int) GenerateOperands();


        public GameData RunGame()
        {
            int score = 0;
            GameType gameDataType = Type; // Type might change if it's a RandomGame
            for (int i = 0; i < Rounds; i++)
            {
                AnsiConsole.MarkupLine(Helpers.RoundHeader("Addition Game", i + 1));

                (int firstNumber, int secondNumber) = GenerateOperands();

                int result = PerformOperation(firstNumber, secondNumber);
                int userResult = AnsiConsole.Ask<int>($"[blue]{firstNumber}[/] [cyan]{Enums.GameTypeToSymbol(Type)}[/] [blue]{secondNumber}[/] [cyan]=[/] ");

                if (Helpers.IsResultCorrect(userResult, result)) score++;

                Helpers.Intermission();
            }
            Helpers.EndGameMessage(score);

            return new GameData(
                id: MockDatabase.GetNextId(),
                score: score,
                date: DateTime.Now,
                operation: gameDataType
                );
        }
    }
}
