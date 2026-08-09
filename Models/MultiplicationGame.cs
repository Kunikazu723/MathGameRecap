namespace MathGameRecap.Models
{
    internal class MultiplicationGame : BaseGame
    {
        internal override Enums.GameType Type => Enums.GameType.Multiply;

        internal override (int, int) GenerateOperands()
        {
            int a = Helpers.Rng.Next(1, 12);
            int b = Helpers.Rng.Next(1, 12);
            return (a, b);
        }

        internal override int PerformOperation(int a, int b) => a * b;
    }
}
