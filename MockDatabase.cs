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
        public static List<Game> Database { get; private set; } = new();

        public void AddGame(Game game)
        {
            if (Database.Any(x => x.Id == game.Id))
            {
                throw new IndexOutOfRangeException();
            }

            Database.Add(game);
        }
    }
}


