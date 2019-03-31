using School_Project.BLL;
using School_Project.Models.StudentsCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Project.Controllers
{
    public class CoursesStudentsController : Controller
    {
        private CourseStudentBLL _courseStudentBLL;

        public CoursesStudentsController(CourseStudentBLL courseStudentBLL)
        {
            _courseStudentBLL = courseStudentBLL;
        }

        // GET: StudentsCourses
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LinkCourseManyStudents(Guid id)
        {
            return View(_courseStudentBLL.OneCourseManyStudent(id));
        }

        [HttpPost]
        public ActionResult LinkCourseManyStudents(Guid idCourse, Guid idStudent)
        {
            return View();
        }

        // GET: CourseStudent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseStudent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseStudent/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseStudent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseStudent/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseStudent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseStudent/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
