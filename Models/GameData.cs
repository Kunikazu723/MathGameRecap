using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathGameRecap.Enums;
namespace MathGameRecap.Models
{
    public class GameData
    {
        public int Id { get; init; }
        public int Score { get; init; }
        public DateTime Date { get; init; }
        public GameType Type { get; init; }
        public TimeSpan Duration { get; init; }
        public Difficulty Difficulty { get; init; }

        public GameData(int id, int score, DateTime date, GameType operation, TimeSpan duration, Difficulty difficulty)
        {
            Id = id;
            Score = score;
            Date = date;
            Type = operation;
            Duration = duration;
            Difficulty = difficulty;
        }

    }
}
