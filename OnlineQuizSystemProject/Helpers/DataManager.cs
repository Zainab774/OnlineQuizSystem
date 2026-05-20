using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using OnlineQuizSystemProject.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace OnlineQuizSystemProject.Helpers
{
    /// <summary>
    /// Manages all persistence via a single JSON file (data.json).
    /// The file is stored next to the executable.
    /// </summary>
    public static class DataManager
    {
        private static readonly string DataFile =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");

        private static AppData? _cache;

        // ─── Load ─────────────────────────────────────────────────────────────────
        /// <summary>
        /// Loads app data from data.json file. Returns cached version
        /// if already loaded. Creates and seeds default data if file
        /// does not exist.
        /// </summary>
        public static AppData Load()
        {
            if (_cache != null) return _cache;

            if (File.Exists(DataFile))
            {
                string json = File.ReadAllText(DataFile);
                _cache = JsonConvert.DeserializeObject<AppData>(json) ?? new AppData();
            }
            else
            {
                _cache = new AppData();
                Seed(_cache);
                Save();
            }
            return _cache;
        }

        // ─── Save ─────────────────────────────────────────────────────────────────
        /// <summary>
        /// Serializes current app data to data.json file.
        /// Does nothing if data has not been loaded yet.
        /// </summary>
        public static void Save()
        {
            if (_cache == null) return;
            string json = JsonConvert.SerializeObject(_cache, Formatting.Indented);
            File.WriteAllText(DataFile, json);
        }

        // ─── Convenience wrappers ─────────────────────────────────────────────────
        public static List<OnlineQuizSystemProject.Models.User> GetUsers() => Load().Users;
        public static List<Quiz> GetQuizzes() => Load().Quizzes;
        public static List<QuizResult> GetResults() => Load().Results;

        /// <summary>
        /// Checks username and password against stored users.
        /// Returns matched User object or null if not found.
        /// </summary>
        public static OnlineQuizSystemProject.Models.User? Authenticate(string username, string password)
        {
            var users = Load().Users;

            // all student accounts must use pass123
            if (username.StartsWith("student", StringComparison.OrdinalIgnoreCase))
            {
                if (password != "pass123")
                    return null;
            }

            return Load().Users.Find(u =>
                string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);
        }

        /// <summary>
        /// Adds a new quiz to the list and saves to file.
        /// </summary>
        public static void AddQuiz(Quiz quiz)
        {
            Load().Quizzes.Add(quiz);
            Save();
        }

        /// <summary>
        /// Adds a new quiz result to the list and saves to file.
        /// </summary>
        public static void AddResult(QuizResult result)
        {
            Load().Results.Add(result);
            Save();
        }

        /// <summary>
        /// Returns all quiz results belonging to a specific student
        /// matched by username (case-insensitive).
        /// </summary>
        public static List<QuizResult> GetResultsForStudent(string username)
        {
            return Load().Results.FindAll(r =>
               string.Equals(r.StudentUsername, username, StringComparison.OrdinalIgnoreCase));
        }

        // ─── Seed default data ────────────────────────────────────────────────────
        /// <summary>
        /// Seeds default admin user, 100 student accounts,
        /// and one sample quiz when app runs for the first time.
        /// </summary>
        private static void Seed(AppData data)
        {
            // Default users
            data.Users.Add(new OnlineQuizSystemProject.Models.User
            {
                Username = "admin",
                Password = "admin123",
                Role = "admin",
                FullName = "Administrator"
            });
            // Auto-generate students
            for (int i = 1; i <= 100; i++)
            {
                data.Users.Add(new OnlineQuizSystemProject.Models.User
                {
                    Username = "student" + i,
                    Password = "pass123",
                    Role = "student",
                    FullName = "Student " + i
                });
            }
            ;
            // Sample quiz
            data.Quizzes.Add(new Quiz
            {
                QuizId = Guid.NewGuid().ToString(),
                Title = "Visual Programing",
                CreatedBy = "admin",
                CreatedAt = DateTime.Now,
                Questions = new List<Question>
                {
                    new Question
                    {
                        QuestionText = "What is the use of tool box?",
                        Options = new List<string> { "MouseHover", "KeyPress", "Click", "Load" },
                        CorrectOptionIndex = 1
                    },
                    new Question
                    {
                        QuestionText = "Which property changes the background color of a form?",
                        Options = new List<string> { "ForeColor", "BackColor", "BorderStyle", "Opacity" },
                        CorrectOptionIndex = 1
                    },
                    new Question
                    {
                        QuestionText = "What does the MessageBox.Show() method do?",
                        Options = new List<string> {"Closes the application", "Displays a popup dialog box", "Opens a new form", "Saves a file" },
                        CorrectOptionIndex = 1
                    },
                     new Question
                    {
                        QuestionText = "Which layout container arranges controls automatically in a flow?",
                        Options = new List<string> { "Panel", "GroupBox", "FlowLayoutPanel", "TabControl" },
                        CorrectOptionIndex = 2
                    }
                }
            });
        }
             /// <summary>
            /// Removes a quiz by its ID from the list and saves to file.
           /// </summary>
          public static void DeleteQuiz(string quizId)
         {
            var data = Load();
            data.Quizzes.RemoveAll(q => q.QuizId == quizId);
            Save();
         }

           /// <summary>
          /// Finds a quiz by ID and updates its title then saves to file.
         /// </summary>
          public static void UpdateQuizTitle(string quizId, string newTitle)
         {
            var quiz = Load().Quizzes.Find(q => q.QuizId == quizId);
            if (quiz != null)
            {
                quiz.Title = newTitle;
                Save();
            }
         }
       }
    }

