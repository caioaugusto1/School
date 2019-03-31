var coursesStudents = function () {

    var includedStudentOneCourse = function (idStudent, idCourse) {

        Util.request("/CoursesStudents/LinkStudentToCourse", "POST", { idCourse, idStudent }, "JSON", function (data) {
        });
    }

    var removeStudentOneCourse = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/RemoveLonkStudentToCourse", "POST", { idCourse, idStudent }, "JSON", function () {

        });
    }

    return { includedStudentOneCourse, removeStudentOneCourse }
}();

