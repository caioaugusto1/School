var linkCourseManyStudents = function () {

    function includedStudentOneCourse(idCourse, idStudent) {
        
        Util.request('qq/wq', 'POST', { idStudent, idCourse }, 'json', function (data) {

        });
    }

};
