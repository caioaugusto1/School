var coursesStudents = function () {

    //Students
    var includedStudentOneCourse = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/LinkStudentToCourse", "POST", { idCourse, idStudent }, "JSON", function (data) {
        });
    }

    //Students
    var removeStudentOneCourse = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/RemoveLinkStudentToCourse", "POST", { idCourse, idStudent }, "JSON", function () {
            debugger;
        });
    }

    //Course
    var includedCourseOneStudent = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/LinkCourseToStudent", "POST", { idCourse, idStudent }, "JSON", function (data) {

        });
    }

    //Course
    var removeCourseOneStudent = function (idStudent, idCourse) {
        Util.request("/CoursesStudents/RemoveLinkCourseToStudent", "POST", { idCourse, idStudent }, "JSON", function (data) {

        });
    }

    var dataTables = function () {
        $(document).ready(function () {
            $('#data-table').DataTable();
        });
    };

    return { includedStudentOneCourse, removeStudentOneCourse, includedCourseOneStudent, removeCourseOneStudent, dataTables }
}();

