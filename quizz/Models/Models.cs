using System.Collections.Generic;
using quizz.Models;
namespace quizz.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }

    public class Question
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int TimeLimitSeconds { get; set; }
        public Category Category { get; set; }
        public List<Answer> Answers { get; set; }
    }

    public class Answer
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class GameResult
    {
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public int DurationSeconds { get; set; }
    }
}
