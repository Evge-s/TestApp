using System.Collections.Generic;
using System.Linq;
using TestApp.Models.DataModels;
using TestApp.Models.TestModels;

namespace TestApp.Resources
{
    public class QuizGenerator
    {
        public async static void InitializeQuizzes(DataContext db)
        {
            if (db.Quizzes.FirstOrDefault() == null)
            {
                for (int i = 1; i < 200; i++)
                {
                    db.Quizzes.Add(new Quiz(
                        $"Test {i}", $"Description of Test {i}", Questions(i)
                        ));
                }
                await db.SaveChangesAsync();
            }
        }

        public static List<Question> Questions(int i)
        {
            return new List<Question>()
            {
               new Question()
                {
                    Title = $"{i} + {i}",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = $"{i}", Result = false },
                            new Answer { Text = $"{i + i}", Result = true },
                            new Answer { Text = $"{i+i/2}", Result = false },
                        }
                },
                new Question()
                {
                    Title = $"{i} * {i}",
                    Answers = new List<Answer>
                    {
                            new Answer { Text = $"{i + i - i/2}", Result = false },
                            new Answer { Text = $"{i + i}", Result = false },
                            new Answer { Text = $"{i * i}", Result = true },
                    }
                }
            };
        }
    }
}
