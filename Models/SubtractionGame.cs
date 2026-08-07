using static MathGameRecap.Enums;

namespace MathGameRecap.Models
{
    internal class SubtractionGame : BaseGame
    {
        protected override GameType Type => GameType.Subtract;

        protected override (int, int) GenerateOperands()
        {
            int a = Helpers.Rng.Next(1, 100);
            int b = Helpers.Rng.Next(1, 100);
            return (a, b);
        }

        protected override int PerformOperation(int a, int b) => a - b;
    }
}
