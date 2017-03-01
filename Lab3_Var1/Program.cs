using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Var1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region old task
            /*
            Student[] st_ar = new Student[5];
            st_ar[0] = new Student(new Person("John", "Huff", new DateTime(1916, 12, 12)), Education.Specialist, 122);
            st_ar[1] = new Student(new Person("Edgar", "Poe", new DateTime(1895, 10, 1)), Education.Bachelor, 222);
            st_ar[2] = new Student(new Person("Douglas", "Spaulding", new DateTime(1917, 11, 15)), Education.Bachelor, 231);
            st_ar[3] = new Student(new Person("Tomas", "Spaulding", new DateTime(1865, 5, 23)), Education.Bachelor, 452);
            st_ar[4] = new Student(new Person("James", "May", new DateTime(1830, 3, 24)), Education.SecondEducation, 662);

            StudentCollection st_coll = new StudentCollection();
            st_coll.AddStudents(st_ar);

            Console.WriteLine("Initial Student collection:\n");
            Console.WriteLine(st_coll.ToString());

            Console.WriteLine("****** Sorted by Last Name:\n");
            st_coll.SortByLastName();
            Console.WriteLine(st_coll.ToString());

            Console.WriteLine("****** Sorted by Birth Date:\n");
            st_coll.SortByBirthDate();
            Console.WriteLine(st_coll.ToString());

            Console.WriteLine("****** Sorted by AGP:\n");
            st_coll.SortByAGP();
            Console.WriteLine(st_coll.ToString());

            Console.WriteLine("****** Maximum AGP ******\n");
            Console.WriteLine("{0} - maximum agp.", st_coll.MaxAGP);

            Console.WriteLine("****** Specialists ******\n");
            IEnumerable<Student> spec = st_coll.Specialists;
            foreach (Student stud in spec)
            {
                Console.WriteLine(stud.ToString());
            }

            Console.WriteLine("****** Average Mark Group ******\n");
            List<Student> st_list = st_coll.AverageMarkGroup(5.0);
            foreach (Student stud in st_list)
            {
                Console.WriteLine(stud.ToString());
            }

            Console.WriteLine("************\n");
            int input_number = 0;
            while (true)
            {
                Console.WriteLine("Please, input the number of elements in collecions.\n" +
                                  "The number should be a nonnegative integer.");
                bool parse_result_success = Int32.TryParse(Console.ReadLine(), out input_number);
                if (parse_result_success)
                {
                    Console.WriteLine("Input correct. Please, wait for search results.\n");
                    break;
                }
                    
            }
            */
            /*
            TestCollections tc = new TestCollections(1000000);
            int[] results = tc.TimeComparison();
             * */
            /* [0] - search time for the first element in List<Person>
             * [1] - search time for the central element in List<Person>
             * [2] - search time for the last element in List<Person>
             * [3] - search time for a non-existent element in List<Person>
             * [4] - search time for the first element in List<string>
             * [5] - search time for the central element in List<string>
             * [6] - search time for the last element in List<string>
             * [7] - search time for the non-existent element in List<string>
             * [8] - search time by key for the first element in Dictionary<Person, Student>
             * [9] - search time by key for the central element in Dictionary<Person, Student>
             * [10] - search time by key for the last element in Dictionary<Person, Student>
             * [11] - search time by key for a non-existent element in Dictionary<Person, Student>
             * [12] - search time by key for the first element in Dictionary<string, Student>
             * [13] - search time by key for the central element in Dictionary<string, Student>
             * [14] - search time by key for the last element in Dictionary<string, Student>
             * [15] - search time by key for a non-existent element in Dictionary<string, Student>
             * [16] - search time by value for the first element in Dictionary<Person, Student>
             * [17] - search time by value for the central element in Dictionary<Person, Student>
             * [18] - search time by value for the last element in Dictionary<Person, Student>
             * [19] - search time by value for a non-existent element in Dictionary<Person, Student>
             */
            /*
            Console.WriteLine("{0} - search time for the first element in List<Person>", results[0]);
            Console.WriteLine("{0} - search time for the central element in List<Person>", results[1]);
            Console.WriteLine("{0} - search time for the last element in List<Person>", results[2]);
            Console.WriteLine("{0} - search time for a non-existent element in List<Person>", results[3]);
            Console.WriteLine("{0} - search time for the first element in List<string>", results[4]);
            Console.WriteLine("{0} - search time for the central element in List<string>", results[5]);
            Console.WriteLine("{0} - search time for the last element in List<string>", results[6]);
            Console.WriteLine("{0} - search time for the non-existent element in List<string>", results[7]);
            Console.WriteLine("{0} - search time by key for the first element in Dictionary<Person, Student>", results[8]);
            Console.WriteLine("{0} - search time by key for the central element in Dictionary<Person, Student>", results[9]);
            Console.WriteLine("{0} - search time by key for the last element in Dictionary<Person, Student>", results[10]);
            Console.WriteLine("{0} - search time by key for a non-existent element in Dictionary<Person, Student>", results[11]);
            Console.WriteLine("{0} - search time by key for the first element in Dictionary<string, Student>", results[12]);
            Console.WriteLine("{0} - search time by key for the central element in Dictionary<string, Student>", results[13]);
            Console.WriteLine("{0} - search time by key for the last element in Dictionary<string, Student>", results[14]);
            Console.WriteLine("{0} - search time by key for a non-existent element in Dictionary<string, Student>", results[15]);
            Console.WriteLine("{0} - search time by value for the first element in Dictionary<Person, Student>", results[16]);
            Console.WriteLine("{0} - search time by value for the central element in Dictionary<Person, Student>", results[17]);
            Console.WriteLine("{0} - search time by value for the last element in Dictionary<Person, Student>", results[18]);
            Console.WriteLine("{0} - search time by value for a non-existent element in Dictionary<Person, Student>", results[19]);
            */
            #endregion
            
            Student stud = new Student();
            stud.AddExams(new Exam("Game Theory", 2, new DateTime(2001, 1, 1)));
            stud.AddExams(new Exam("Probability Theory", 4, new DateTime(2000, 7, 16)));
            stud.AddExams(new Exam("Game Theory", 2, new DateTime()));
            stud.AddExams(new Exam("Probability Theory", 4, new DateTime()));
            stud.AddExams(new Exam("Game Theory", 2, new DateTime()));
            stud.AddExams(new Exam("Probability Theory", 4, new DateTime()));

            Console.WriteLine("Make a Student object. Sort Exams with different setings.\n");
            Console.WriteLine(stud.ToString());
            Console.WriteLine("______________\n");
            stud.SortExamsByName();
            Console.WriteLine(stud.ToString());
            Console.WriteLine("______________\n");
            stud.SortExamsByGrade();
            Console.WriteLine(stud.ToString());
            Console.WriteLine("______________\n");
            stud.SortExamsByDate();
            Console.WriteLine(stud.ToString());
            Console.WriteLine("****************\n");

            Student[] st_ar = new Student[5];
            st_ar[0] = new Student(new Person("John", "Huff", new DateTime(1916, 12, 12)), Education.Specialist, 122);
            st_ar[1] = new Student(new Person("Edgar", "Poe", new DateTime(1895, 10, 1)), Education.Bachelor, 222);
            st_ar[2] = new Student(new Person("Douglas", "Spaulding", new DateTime(1917, 11, 15)), Education.Bachelor, 231);
            st_ar[3] = new Student(new Person("Tomas", "Spaulding", new DateTime(1865, 5, 23)), Education.Bachelor, 452);
            st_ar[4] = new Student(new Person("James", "May", new DateTime(1830, 3, 24)), Education.SecondEducation, 662);

            GenericStudentCollection<string> st_coll = new GenericStudentCollection<string>(makeStudentKey);
            st_coll.AddStudents(st_ar);

            Console.WriteLine("Make a StudentCollection<string> object. Call feature method.\n");
            Console.WriteLine("Initial Student collection:\n");
            
            Console.WriteLine(st_coll.ToString());
            
            Console.WriteLine("________________\n");
            Console.WriteLine("Maximum AGP overall: {0}.", st_coll.MaxAGP);
            Console.WriteLine("________________\n");
            IEnumerable<KeyValuePair<string, Student>> spec_coll = st_coll.EducationForm(Education.Specialist);
            foreach (KeyValuePair<string, Student> kvp in spec_coll)
            {
                Console.WriteLine(kvp.ToString());
            }
            Console.WriteLine("________________\n");
            IEnumerable<IGrouping<Education, KeyValuePair<string, Student>>> group_collection = st_coll.AGP_Grouping; 
            foreach (IGrouping<Education, KeyValuePair<string, Student>> grouping in group_collection) 
            {
                Console.WriteLine("Group key: {0}.", grouping.Key);
                foreach(KeyValuePair<string, Student> kvp in grouping)
                {
                    Console.WriteLine(kvp.ToString());
                }
            }

            Console.WriteLine("************\n");
            Console.WriteLine("Create GenericTestCollection<Person, Student> object. Call TimeComparison() method.");
            
            int input_number = 0;
            while (true)
            {
                Console.WriteLine("Please, input the number of elements in collecions.\n" +
                                  "The number should be a nonnegative integer.");
                bool parse_result_success = Int32.TryParse(Console.ReadLine(), out input_number);
                if (parse_result_success)
                {
                    Console.WriteLine("Input correct. Please, wait for search results.\n");
                    break;
                }

            }
            GenericTestCollections<Person, Student> gtc_ps = new GenericTestCollections<Person, Student>(input_number, person_student_pair_generator);
            int[] results = gtc_ps.TimeComparison();

            Console.WriteLine("{0} - search time for the first element in List<Person>", results[0]);
            Console.WriteLine("{0} - search time for the central element in List<Person>", results[1]);
            Console.WriteLine("{0} - search time for the last element in List<Person>", results[2]);
            Console.WriteLine("{0} - search time for a non-existent element in List<Person>", results[3]);
            Console.WriteLine("{0} - search time for the first element in List<string>", results[4]);
            Console.WriteLine("{0} - search time for the central element in List<string>", results[5]);
            Console.WriteLine("{0} - search time for the last element in List<string>", results[6]);
            Console.WriteLine("{0} - search time for the non-existent element in List<string>", results[7]);
            Console.WriteLine("{0} - search time by key for the first element in Dictionary<Person, Student>", results[8]);
            Console.WriteLine("{0} - search time by key for the central element in Dictionary<Person, Student>", results[9]);
            Console.WriteLine("{0} - search time by key for the last element in Dictionary<Person, Student>", results[10]);
            Console.WriteLine("{0} - search time by key for a non-existent element in Dictionary<Person, Student>", results[11]);
            Console.WriteLine("{0} - search time by key for the first element in Dictionary<string, Student>", results[12]);
            Console.WriteLine("{0} - search time by key for the central element in Dictionary<string, Student>", results[13]);
            Console.WriteLine("{0} - search time by key for the last element in Dictionary<string, Student>", results[14]);
            Console.WriteLine("{0} - search time by key for a non-existent element in Dictionary<string, Student>", results[15]);
            Console.WriteLine("{0} - search time by value for the first element in Dictionary<Person, Student>", results[16]);
            Console.WriteLine("{0} - search time by value for the central element in Dictionary<Person, Student>", results[17]);
            Console.WriteLine("{0} - search time by value for the last element in Dictionary<Person, Student>", results[18]);
            Console.WriteLine("{0} - search time by value for a non-existent element in Dictionary<Person, Student>", results[19]);

            Console.ReadKey();
        }

        private static string makeStudentKey(Student stud)
        {
            return stud.Passport_Data.ToString() + "\n";
        }

        private static KeyValuePair<Person, Student> person_student_pair_generator(int number)
        {
            Person key = new Person("Doug " + number, "Spaulding " + number, new DateTime(1930, 12, 20));
            Student value = new Student(key, Education.Bachelor, 133 + number);
            return new KeyValuePair<Person, Student>(key, value);
        }
    }
}
