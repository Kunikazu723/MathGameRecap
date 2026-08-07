using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameRecap
{
    public class Enums
    {
        public enum GameType
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            MainMenu
        }

        public enum MenuChoice
        {
            Play,
            History
        }

        public static char GameTypeToSymbol(GameType type) => type switch 
        {
            GameType.Add => '+',
            GameType.Subtract => '-',
            GameType.Multiply => '*',
            GameType.Divide => '/',
            _ => throw new NotImplementedException()

        };
    }
}
