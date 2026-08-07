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
        public int Id { get; }
        public int Score { get; }
        public DateTime Date { get; }
        public GameType Operation { get; }
        
        public GameData(int id, int score, DateTime date, GameType operation)
        {
            Id = id;
            Score = score;
            Date = date;
            Operation = operation;
        }

    }
}
