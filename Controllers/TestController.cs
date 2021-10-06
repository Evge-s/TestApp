using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestApp.Models.DataModels;
using TestApp.Models.TestModels;
using TestApp.Models.ViewModels;
using TestApp.Resources;

namespace TestApp.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        private List<Quiz> quizzes = QuizGenerator.Quizzes();

        public IActionResult QuizzesPage(int page = 1)
        {
            int pageSize = 10;

            IQueryable<Quiz> source = quizzes.AsQueryable();
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel<Quiz> viewModel = new IndexViewModel<Quiz>
            {
                PageViewModel = pageViewModel,
                Set = items
            };
            return View(viewModel);
        }

        public IActionResult TestPageView(string title)
        {
            return View(FindQuiz(title));
        }

        public IActionResult QuestionsView(string title)
        {
            return View(FindQuiz(title).Questions);
        }

        private Quiz FindQuiz(string title)
        {
            return quizzes.Find(x => x.Title == title);
        }
    }
}
