var coursesStudents = function () {

    //Students
    var includedStudentOneCourse = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/LinkStudentToCourse", "POST", { idCourse, idStudent }, "JSON", function (data) {
            window.location.reload();
        });
    }

    //Students
    var removeStudentOneCourse = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/RemoveLinkStudentToCourse", "POST", { idCourse, idStudent }, "JSON", function () {
            window.location.reload();
        });
    }

    //Course
    var includedCourseOneStudent = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/LinkCourseToStudent", "POST", { idCourse, idStudent }, "JSON", function (data) {
            window.location.reload();
        });
    }

    //Course
    var removeCourseOneStudent = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/RemoveLinkCourseToStudent", "POST", { idCourse, idStudent }, "JSON", function (data) {
            window.location.reload();
        });
    }

    return { includedStudentOneCourse, removeStudentOneCourse, includedCourseOneStudent, removeCourseOneStudent }
}();

