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
        
        public GameData(int id, int score, DateTime date, GameType operation)
        {
            Id = id;
            Score = score;
            Date = date;
            Type = operation;
        }

    }
}
