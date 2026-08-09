using static MathGameRecap.Enums;
namespace MathGameRecap.Models
{
    internal class MultiplicationGame : BaseGame
    {
        internal override Enums.GameType Type => Enums.GameType.Multiply;

        internal override (int, int) GenerateOperands(Difficulty difficulty)
        {
            int a;
            int b;
            switch (difficulty)
            {
                case Difficulty.Easy:
                    a = Helpers.Rng.Next(1, 10);
                    b = Helpers.Rng.Next(1, 10);
                    break;
                case Difficulty.Medium:
                    a = Helpers.Rng.Next(10, 101);
                    b = Helpers.Rng.Next(1, 10);
                    break;
                case Difficulty.Hard:
                    a = Helpers.Rng.Next(1, 101);
                    b = Helpers.Rng.Next(1, 101);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return (a, b);
        }

        internal override int PerformOperation(int a, int b) => a * b;
    }
}
