﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_300_F22SD_Labs
{
    public class Course
    {
        private int _courseId;
        
        public int CourseId { get { return _courseId; } }
        private void _setCourseId(int courseId)
        {
            if (courseId > 99)
            {
                _courseId = courseId;
            }
            else
            {
                throw new Exception("Course ID should be number greater than 100");
            }
        }


        private string _title;
        public string Title { get { return _title; } }
        private void _setTitle(string title)
        {
            if (title.Length > 2)
            {
                _title = title;
            }
            else
            {
                throw new Exception("Title should be three or more characters.");
            }
        }


        private int _capacity;
        public int Capacity { get { return _capacity; } }
        private void _setCapacity(int capacity)
        {
            if (capacity > 0)
            {
                _capacity = capacity;
            }
            else
            {
                throw new Exception("Capacity must be greater than zero.");
            }
        }



        //public Enrolment? GetStudentInCourse(int studentId)
        //{
        //    string answer;

        //    foreach (Enrolment e in _enrolments)
        //    {
        //        if (e.Student.StudentId == studentId)
        //        {
        //            answer = e.Student.FirstName ;

        //            Console.WriteLine(answer);
        //        }
        //        else
        //        {
        //            throw new Exception("Student not registered");
        //        }
        //    }
        //    return null;
        //}

        //private HashSet<Enrolment> _enrolments = new HashSet<Enrolment>();

        //public void AddEnrolmentToCourse(Enrolment enrolment)
        //{
        //    if (_enrolments.Count < Capacity)
        //    {
        //        _enrolments.Add(enrolment);
        //    }
        //    else
        //    {
        //        throw new Exception($"Course is at enrolment capacity {Capacity}");
        //    }
        //}




        private HashSet<Student> _students = new HashSet<Student>();

        public Student? GetStudentInCourse(int studentId)
        {
            foreach (Student s in _students)
            {
                if (s.StudentId == studentId)
                {
                    return s;
                }
            }
            return null;
        }


        public void AddStudentToCourse(Student student)
        {
            if (_students.Count < Capacity)
            {
                _students.Add(student);
            }
            else
            {
                throw new Exception($"course is at enrolment capacity {Capacity}");
            }
        }

        public void RemoveStudentFromCourse(Student student)
        {
            _students.Remove(student);
        }


        public Course(int courseId, string title, int capacity)
        {
            _setCourseId(courseId);
            _setTitle(title);
            _setCapacity(capacity);
        }
    }
}
