using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3_Var1;

namespace UnitTestProject
{
    [TestClass]
    public class Test_GenericTestCollections
    {
        [TestMethod]
        public void Test_Constructor()
        {
            GenericTestCollections<Person, Student> gtc_ps = new GenericTestCollections<Person, Student>(6, person_student_pair_generator);
            Console.WriteLine(gtc_ps.ToString());
        }

        private KeyValuePair<Person, Student> person_student_pair_generator(int number)
        {
            Person key = new Person("Doug " + number, "Spaulding " + number, new DateTime(1930, 12, 20));
            Student value = new Student(key, Education.Bachelor, 133 + number);
            return new KeyValuePair<Person, Student>(key, value);
        }
    }
}
