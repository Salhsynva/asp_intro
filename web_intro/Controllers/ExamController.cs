using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_intro.Models;

namespace web_intro.Controllers
{
    public class ExamController : Controller
    {
        List<Exam> _exams = new List<Exam>
        {
            new Exam(1, "Fizika"),
            new Exam(2, "Riyaziyyat"),
            new Exam(3, "Kimya"),
            new Exam(4, "Tarix"),
            new Exam(5, "BIalogiya"),
            new Exam(6, "Cografiya"),

        };

        public ActionResult Index()
        {
            ViewBag.Exams = _exams;

            return View();
        }

        public ActionResult Detail(int? id)
        {
            if (id != null){
                Exam wantedExam = _exams.Find(x => x.Id == id);
                ViewBag.ExamId = wantedExam.Id;
                ViewBag.ExamSubject = wantedExam.Subject;
            }
            return View();  
        }
    }
}
