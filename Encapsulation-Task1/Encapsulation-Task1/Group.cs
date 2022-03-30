using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Task1
{
    public class Group
    {
        public int currentPosition = 0;
        private string _Ad;

        public string Ad
        {
            get
            {
                return _Ad;
            }

            set
            {
                _Ad = value;
            }
        }

        private int _maxStuCount;

        public int maxStuCount
        {
            get
            {
                return _maxStuCount;
            }

            set
            {
                _maxStuCount = value;
            }
        }

        private Student[] _students = new Student[16];

        public Student[] students
        {
            get
            {
                return _students;
               
            }

            set
            {
               
            }
        }

        public void addStudent(Student Obyekt)
        {
            if(_students.Length <= maxStuCount)
            {
                _students[currentPosition] = Obyekt;
                currentPosition++;
            }

            else
            {
                Console.WriteLine("Telebe elave edile bilmez, yer yoxdur");
            }

        }

        public void removeStudent(int id)
        {
            Student[] newStudents = new Student[_students.Length-1];
            for (int i = 0; i < _students.Length; i++)
            {
                if(_students[i].ID == id)
                {
                    continue;
                }

                else
                {
                    newStudents[i] = _students[i];
                }
            }
            foreach (var item in newStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
