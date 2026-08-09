using static MathGameRecap.Enums;

namespace MathGameRecap.Models
{
    internal class SubtractionGame : BaseGame
    {
        internal override GameType Type => GameType.Subtract;

        internal override (int, int) GenerateOperands()
        {
            int a = Helpers.Rng.Next(1, 100);
            int b = Helpers.Rng.Next(1, 100);
            return (a, b);
        }

        internal override int PerformOperation(int a, int b) => a - b;
    }
}
