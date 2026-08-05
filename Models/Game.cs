using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathGameRecap.Enums;
namespace MathGameRecap.Models
{
    public class Game
    {
        public int Id { get; }
        public int Score { get; }
        public DateTime Date { get; }
        public MathOperation Operation { get; }
        
        public Game(int id, int score, DateTime date, MathOperation operation)
        {
            Id = id;
            Score = score;
            Date = date;
            Operation = operation;
        }

    }
}
