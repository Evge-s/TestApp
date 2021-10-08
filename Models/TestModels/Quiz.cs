using System.Collections.Generic;

namespace TestApp.Models.TestModels
{
    
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Question> Questions  { get; set; }

        public Quiz() { }

        public Quiz(string title, string description, List<Question> questions)
        {
            Title = title;
            Questions = questions;
            Description = description;
        }
    }
}