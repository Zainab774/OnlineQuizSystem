using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineQuizSystemProject.Models
{
    public class QuizResult
    {
        public string? ResultId { get; set; }
        public string? StudentUsername { get; set; }
        public string? StudentFullName { get; set; }
        public string? QuizId { get; set; }
        public string? QuizTitle { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }
        public double Percentage { get; set; }
        public DateTime SubmittedAt { get; set; }
    }
}
