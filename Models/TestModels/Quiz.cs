using System.Collections.Generic;

namespace TestApp.Models.TestModels
{
    
    public class Quiz
    {
        public int Current { get; set; }
        public string Score { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Question> Questions  { get; set; }
        public Quiz(string title, string description, List<Question> questions)
        {
            Title = title;
            Questions = questions;
            Description = description;
            this.Current = 0;
        }
    }
}