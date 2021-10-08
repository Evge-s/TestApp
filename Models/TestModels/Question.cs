using System;
using System.Collections.Generic;

namespace TestApp.Models.TestModels
{
    [Serializable]
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public string Title { get; set; }
        public List<Answer> Answers { get; set; }

        public Question() { }
    }
}
