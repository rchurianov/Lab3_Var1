using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3_Var1;

namespace UnitTestProject
{
    
    [TestClass]
    public class StudentCollectionTest
    {
        // Also tests StudentCollection.ToString()
        [TestMethod]
        public void Test_AddDefaults()
        {
            StudentCollection sc = new StudentCollection();
            sc.AddDefaults();
            Console.WriteLine(sc.ToString());
        }

        // Also tests StudentCollection.ToShortString()
        [TestMethod]
        public void Test_AddStudents()
        {
            StudentCollection sc = new StudentCollection();
            sc.AddStudents(new Student());
            Console.WriteLine(sc.ToShortString());
        }

        [TestMethod]
        public void Test_SortByLastName()
        {
            StudentCollection sc = new StudentCollection();
            Student[] st_add = new Student[5];
            Random rand = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                // generate a random integer :
                int symbol_int = rand.Next(65, 91); // 65 is inclusive, 91 is exclusive - [A - Z] ASCII table interval
                // get character from randompy generated integer :
                char symbol = (char)symbol_int;
                string last_name = "a" + symbol;
                st_add[i] = new Student(new Person("John", last_name, new DateTime()), Education.Bachelor, 112);
            }

            sc.AddStudents(st_add);
            Console.WriteLine(sc.ToShortString());
            sc.SortByLastName();
            Console.WriteLine(sc.ToShortString());
        }

        [TestMethod]
        public void Test_SortByBirthDate()
        {
            StudentCollection sc = new StudentCollection();
            Student[] st_add = new Student[5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                int day_int = rand.Next(1, 29); // 1 is inclusive, 29 is exclusive - days
                st_add[i] = new Student(new Person("John", "Smith", new DateTime(1998, 1, day_int)), Education.Bachelor, 112);
            }

            sc.AddStudents(st_add);
            Console.WriteLine(sc.ToShortString());

            sc.SortByBirthDate();
            Console.WriteLine(sc.ToShortString());
        }

        [TestMethod]
        public void Test_SortByAGP()
        {
            StudentCollection sc = new StudentCollection();
            Student[] st_add = new Student[5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                int grade = rand.Next(1, 6); // 1 is inclusive, 29 is exclusive - days
                Student tmp_student = new Student();
                tmp_student.AddExams(new Exam("Some Exam", grade, new DateTime()));
                st_add[i] = tmp_student;
                //st_add[i] = new Student(new Person("John", "Smith", new DateTime()), Education.Bachelor, 112);
            }

            sc.AddStudents(st_add);
            Console.WriteLine(sc.ToShortString());

            sc.SortByAGP();
            Console.WriteLine(sc.ToShortString());
        }
    }
}
