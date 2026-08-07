using MathGameRecap.Models;
using static MathGameRecap.Enums;
namespace MathGameRecap
{
    internal class GameEngine
    {

        private readonly Random random = new();
        private readonly Dictionary<GameType, BaseGame> gameRunner = new()
        {
            [GameType.Add] = new AdditionGame(),
            [GameType.Subtract] = new SubtractionGame(),
            [GameType.Multiply] = new MultiplicationGame(),
            [GameType.Divide] = new DivisionGame(),
        };

        public void RunGame(GameType operation)
        {
            gameRunner[operation].RunGame();
        }


    }
}
