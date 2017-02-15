using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Var1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input_number = 0;
            while (true)
            {
                Console.WriteLine("Please, input the number of elements in collecions.\n" +
                                  "The number should be a nonnegative integer.");
                bool parse_result_success = Int32.TryParse(Console.ReadLine(), out input_number);
                if (parse_result_success)
                    break;
            }
        }
    }
}
