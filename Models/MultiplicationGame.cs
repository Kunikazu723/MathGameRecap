namespace MathGameRecap.Models
{
    internal class MultiplicationGame : BaseGame
    {
        protected override Enums.GameType Type => Enums.GameType.Multiply;

        protected override (int, int) GenerateOperands()
        {
            int a = Helpers.Rng.Next(1, 12);
            int b = Helpers.Rng.Next(1, 12);
            return (a, b);
        }

        protected override int PerformOperation(int a, int b) => a * b;
    }
}
