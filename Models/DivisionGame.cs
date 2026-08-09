using System.CodeDom.Compiler;

namespace MathGameRecap.Models
{
    internal class DivisionGame : BaseGame
    {
        internal override Enums.GameType Type => Enums.GameType.Divide;

        internal override (int, int) GenerateOperands()
        {
            int a = Helpers.Rng.Next(0, 100);
            int b = GenerateDenominator(a);

            return (a, b);
        }

        internal override int PerformOperation(int a, int b) => a / b;

        private int GenerateDenominator(int a)
        {
            if (a == 0)
            {
                return 1;
            }

            var availableDenominators = new List<int>();
            for (int i = 1; i <= a; i++) 
            {
                if (a % i == 0)
                {
                    availableDenominators.Add(i);
                }
            }

            int randomIndex = Helpers.Rng.Next(availableDenominators.Count);

            return availableDenominators[randomIndex];
        }
    }
}
