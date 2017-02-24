using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Var1
{
    public class GenericTestCollections<TKey, TValue>
    {
        private List<TKey> person_list;
        private List<string> list_of_strings;
        private Dictionary<TKey, TValue> person_student_dict;
        private Dictionary<string, TValue> student_dict;

        private GenerateElement<TKey, TValue> generate_element_method;
    }
}
