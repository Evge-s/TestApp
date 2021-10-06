using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models.TestModels
{
    [Serializable]
    public class Question
    {
        public string Title { get; set; }
        public List<Answer> Answers { get; set; }

        public Question() { }
    }
}
