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
                int symbol_int = rand.Next(65, 91); // 65 is inclusive, 91 is exclusive
                char symbol = (char)symbol_int;
                string last_name = "a" + symbol;
                st_add[i] = new Student(new Person("John", last_name, new DateTime()), Education.Bachelor, 112);
            }
            //Student st1 = new Student(new Person("John", ""))

            sc.AddStudents(st_add);
            Console.WriteLine(sc.ToShortString());
            sc.SortByLastName();
            Console.WriteLine(sc.ToShortString());
        }
    }
}
