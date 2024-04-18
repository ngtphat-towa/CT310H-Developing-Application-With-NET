using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentListDataGridView.Models
{
    public class Student
    {
        public Student(Student student)
        {
            StudentId = student.StudentId;
            StudentName = student.StudentName;
            Gender = student.Gender;
            ClassName = student.ClassName;
        }
        public Student(string StudentId, string StudentName, int Gender, string ClassName)
        {
            StudentId = StudentId;
            StudentName = StudentName;
            Gender = Gender;
            ClassName = ClassName;
        }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public int Gender { get; set; }
        public string ClassName { get; set; }
    }
}