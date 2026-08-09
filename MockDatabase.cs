using MathGameRecap.Models;
using Spectre.Console;
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

        public static void ViewGamesHistory()
        {
            var table = new Table();
            table.AddColumns(new string[] { 
                "Id", "Type", "Date", "Score"
            });

            foreach ( var gameData in Database)
            {
                var id = gameData.Id.ToString();
                var type = gameData.Type.ToString();
                var date = gameData.Date.ToString();
                var score = gameData.Score.ToString();

                table.AddRow(new string[] { 
                    id, type, date, score
                });
            }

            AnsiConsole.Write(table);
            Helpers.Intermission();
        }
    }
}


