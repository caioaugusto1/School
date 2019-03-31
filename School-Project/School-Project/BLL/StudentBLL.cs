using School_Project.Entities;
using School_Project.Repositories;
using System;
using System.Collections.Generic;

namespace School_Project.BLL
{
    public class StudentBLL
    {
        private StudentRepository _studentRepository;

        public StudentBLL(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(Student student)
        {
            student.Id = Guid.NewGuid();
            _studentRepository.Insert(student);
        }

        public List<Student> ListAll()
        {
            return _studentRepository.GetAll();
        }

        public List<Student> ListStudentsAvaliable()
        {
            return _studentRepository.GetAll();
        }
    }
}