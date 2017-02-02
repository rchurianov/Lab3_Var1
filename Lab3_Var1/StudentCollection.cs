using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Var1
{
    public class StudentCollection
    {
        private List<Student> students;

        /* Adds 5 default Student objects to students collection */
        public void AddDefaults()
        {
            if (students == null)
                students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student());
            }
        }

        public void AddStudents(params Student[] student_array)
        {
            if (student_array != null)
            {
                if (this.students == null)
                    this.students = new List<Student>();

                for (int i = 0; i < student_array.Length; i++)
                {
                    this.students.Add(student_array[i]);
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < students.Count; i++)
            {
                s += students[i].ToString() + "\n";
            }
            return s;
        }

        public string ToShortString()
        {
            string s = "";
            for (int i = 0; i < students.Count; i++)
            {
                s += students[i].ToShortString() + "\n" +
                    "Number of credits: " + students[i].Credit_List.Count + "\n" +
                    "Number of exams: " + students[i].Exam_List.Count + "\n";
            }
            return s;
        }

        public void SortByLastName()
        {
            if (this.students != null)
            {
                this.students.Sort(CompareStudentsByLastName);
            }
        }

        private int CompareStudentsByLastName(IComparable x, IComparable y)
        {
            return x.CompareTo(y);
        }

        public void SortByBirthDate()
        {

        }

        public void SortByAGP()
        {

        }
    }
}
