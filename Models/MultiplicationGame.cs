namespace MathGameRecap.Models
{
    internal class MultiplicationGame : BaseGame
    {
        protected override Enums.GameType Type => Enums.GameType.Multiply;

        protected override int PerformOperation(int a, int b) => a * b;
    }
}
