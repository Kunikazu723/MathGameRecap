using MathGameRecap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameRecap.Models
{
    internal class DivisionGame : BaseGame, IGame
    {
        protected override Enums.GameType Type => Enums.GameType.Divide;

        protected override int PerformOperation(int a, int b) => a / b;
    }
}
