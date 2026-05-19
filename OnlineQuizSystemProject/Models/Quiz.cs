using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineQuizSystemProject.Models
{
    // ─── Quiz (one full quiz)
    public class Quiz
    {
        public string? QuizId { get; set; }
        public string? Title { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
