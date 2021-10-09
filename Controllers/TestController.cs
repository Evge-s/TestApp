using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models.DataModels;
using TestApp.Models.TestModels;
using TestApp.Models.ViewModels;
using TestApp.Resources;

namespace TestApp.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        private DataContext db;
        private Random rnd = new Random();
        public TestController(DataContext context)
        {
            db = context;
            QuizGenerator.InitializeQuizzes(db);
        }

        public async Task<IActionResult> Quizzes(int? pageNumber)
        {
            int val = rnd.Next(1, 150);
            int pageSize = 3;

            var quizzes = from s in db.Quizzes.Where(x => x.Id >= val & x.Id <= val + 5)
            select s;
            
            return View(await PaginatedList<Quiz>.CreateAsync(quizzes.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public IActionResult Test(int id)
        {
            return View(FindQuiz(id));
        }

        public IActionResult Question(int quizId)
        {
            return View(db.Questions.Where(x => x.QuizId == quizId).FirstOrDefault());
        }

        public IActionResult AnswerResult(int questId)
        {
            return View(db.Questions.FirstOrDefault(x => x.Id == questId));
        }

        private Quiz FindQuiz(int id)
        {
            return db.Quizzes.FirstOrDefault(x => x.Id == id);
        }        
    }
}
