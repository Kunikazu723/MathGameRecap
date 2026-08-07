namespace MathGameRecap.Models
{
    internal class DivisionGame : BaseGame
    {
        protected override Enums.GameType Type => Enums.GameType.Divide;

        protected override int PerformOperation(int a, int b) => a / b;
    }
}
