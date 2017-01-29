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

        }

        public override string ToString()
        {
 	         return base.ToString();
        }

        public string ToShortString()
        {
            return base.ToString();
        }

        public void SortByLastName()
        {

        }

        public void SortByBirthDate()
        {

        }

        public void SortByAGP()
        {

        }
    }
}
