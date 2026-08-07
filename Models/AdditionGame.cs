using MathGameRecap;
using MathGameRecap.Interfaces;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathGameRecap.Enums;
namespace MathGameRecap.Models
{
    internal class AdditionGame : BaseGame
    {
        protected override GameType Type { get; } = GameType.Add;
        protected override int PerformOperation(int a, int b) => a + b;
        
    }
}
