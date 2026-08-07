using MathGameRecap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathGameRecap.Enums;

namespace MathGameRecap
{
    internal class MockDatabase
    {
        public static List<GameData> Database { get; private set; } = new();
        private static int LastId { get; set; } = 0;
        public static void AddGame(int id, int score, GameType operation)
        {
            if (Database.Any(gameData => gameData.Id == id))
            {
                throw new ArgumentException();
            }

            var date = DateTime.Now;

            Database.Add(
                new GameData(
                    id: id,
                    score: score,
                    date: date,
                    operation: operation
                    )
                );

            
            LastId = id;
        }

        public static int GetNextId() => LastId + 1;

        public static void ViewHistory()
        {
            foreach ( var gameData in Database)
            {
                Console.WriteLine(gameData.ToString());
            }
            Helpers.Intermission();
        }
    }
}


