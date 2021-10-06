using System.Collections.Generic;
using TestApp.Models.TestModels;

namespace TestApp.Resources
{
    public class QuizGenerator
    {
        public static List<Quiz> Quizzes()
        {
            List<Quiz> quizzes = new List<Quiz>();
            for (int i = 1; i < 50; i++)
            {
                quizzes.Add(new Quiz(
                    $"Test {i}", $"Description of Test {i}", questions
                    ));
            }
            return quizzes;
        }

        public static List<Question> questions = new List<Question>
        {
            new Question()
            {
                Title = "1+1",
                Answers = new List<Answer>
                {
                    new Answer {Text = "1", Result = false },
                    new Answer {Text = "2", Result = true },
                    new Answer {Text = "3", Result = false },
                }
            },
            new Question()
            {
                Title = "2+2",
                Answers = new List<Answer>
                {
                    new Answer {Text = "1", Result = false },
                    new Answer {Text = "4", Result = true },
                    new Answer {Text = "3", Result = false },
                }
            }
        };
    }
}
