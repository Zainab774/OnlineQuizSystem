using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineQuizSystemProject.Models
{
    //  Quiz Question 
    public class Question
    {
        public string? QuestionText { get; set; }
        public List<string> Options { get; set; } = new List<string>();
        public int CorrectOptionIndex { get; set; }   // 0-based
    }
}
