using MathGameRecap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameRecap
{
    internal class MockDatabase
    {
        public static List<GameData> Database { get; private set; } = new();
        public static int LastId { get; private set; } = 0;
        public static void AddGame(GameData game)
        {
            if (Database.Any(x => x.Id == game.Id))
            {
                throw new ArgumentException();
            }

            Database.Add(game);
            LastId = game.Id;
        }
    }
}


