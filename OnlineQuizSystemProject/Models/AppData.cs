using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineQuizSystemProject.Models
{
    public class AppData
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Quiz> Quizzes { get; set; } = new List<Quiz>();
        public List<QuizResult> Results { get; set; } = new List<QuizResult>();
    }
}

