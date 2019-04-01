using School_Project.BLL;
using School_Project.Entities;
using School_Project.Filters;
using School_Project.Models.StudentsCourses;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace School_Project.Controllers
{
    [AutorizationFilter]
    public class CoursesStudentsController : Controller
    {
        private CourseStudentBLL _courseStudentBLL;

        private CourseBLL _courseBLL;

        private StudentBLL _studantsBLL;

        public CoursesStudentsController(CourseStudentBLL courseStudentBLL,
            CourseBLL courseBLL, StudentBLL studantsBLL)
        {
            _courseStudentBLL = courseStudentBLL;
            _courseBLL = courseBLL;
            _studantsBLL = studantsBLL;
        }

        // GET: StudentsCourses
        public ActionResult Index()
        {
            return View();
        }

        #region Students
        public ActionResult ListCoursesAvaliableByStudent(Guid id)
        {
            //ok
            Student student = _studantsBLL.GetById(id);
            List<Course> courses = _courseBLL.GetCoursesAvaliable();

            ListCoursesAvaliableVM listCoursesAvaliableVM = new ListCoursesAvaliableVM(student, courses);

            return View("ListCoursesAvaliableByStudent", listCoursesAvaliableVM);
        }

        [HttpPost]
        public JsonResult LinkStudentToCourse(Guid idCourse, Guid idStudent)
        {
            HttpStatusCode statusCode = _courseStudentBLL.CreateLinkStudentToCourse(idStudent, idCourse);

            if (statusCode == HttpStatusCode.NotFound)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return Json(new { message = "Student or Course not found" }, JsonRequestBehavior.AllowGet);
            }
            else if (statusCode == HttpStatusCode.Conflict)
            {
                Response.StatusCode = (int)HttpStatusCode.Conflict;
                return Json(new { message = "Student enrolled in many courses" }, JsonRequestBehavior.AllowGet);
            }

            Response.StatusCode = (int)HttpStatusCode.NoContent;
            return Json(new { message = "Success" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult RemoveLinkStudentToCourse(Guid idCourse, Guid idStudent)
        {
            HttpStatusCode statusCode = _courseStudentBLL.RemoveLinkStudentToCourse(idStudent, idCourse);

            if (statusCode == HttpStatusCode.NotFound)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return Json(new { message = "Student or Course not found" }, JsonRequestBehavior.AllowGet);
            }

            Response.StatusCode = (int)HttpStatusCode.NoContent;
            return Json(new { message = "Success" }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Courses

        public ActionResult ListStudentsAvaliableIncluedInCourse(Guid id)
        {
            //ok
            Course course = _courseBLL.GetById(id);
            List<Student> students = _studantsBLL.GetStudentsAvaliable();

            ListCourseManyStudentsVM listCourseManyStudentsVM = new ListCourseManyStudentsVM(course, students);

            return View("ListStudentsByCourse", listCourseManyStudentsVM);
        }

        [HttpPost]
        public ActionResult LinkCourseToStudent(Guid idCourse, Guid idStudent)
        {
            //ok
            HttpStatusCode statusCode = _courseStudentBLL.CreateLinkCourseToStudent(idStudent, idCourse);

            if (statusCode == HttpStatusCode.NotFound)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return Json(new { message = "Student or Course not found" }, JsonRequestBehavior.AllowGet);
            }
            else if (statusCode == HttpStatusCode.Conflict)
            {
                Response.StatusCode = (int)HttpStatusCode.Conflict;
                return Json(new { message = "Student enrolled in many courses" }, JsonRequestBehavior.AllowGet);
            }

            Response.StatusCode = (int)HttpStatusCode.NoContent;
            return Json(new { message = "Success" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RemoveLinkCourseToStudent(Guid idCourse, Guid idStudent)
        {
            //ok
            HttpStatusCode statusCode = _courseStudentBLL.RemoveLinkCourseToStudent(idStudent, idCourse);

            if (statusCode == HttpStatusCode.NotFound)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return Json(new { message = "Student or Course not found" }, JsonRequestBehavior.AllowGet);
            }

            Response.StatusCode = (int)HttpStatusCode.NoContent;
            return Json(new { message = "Success" }, JsonRequestBehavior.AllowGet);
        }

        #endregion

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
