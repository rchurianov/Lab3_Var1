using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Var1
{
    public class GenericTestCollections<TKey, TValue>
    {
        private List<TKey> list_of_keys;
        private List<string> list_of_strings;
        private Dictionary<TKey, TValue> key_value_dict;
        private Dictionary<string, TValue> value_dict;

        private GenerateElement<TKey, TValue> generate_element_method;

        /* Constuctor to create collections with specified number of items */
        public GenericTestCollections(int length, GenerateElement<TKey, TValue> kvp_generator)
        {
            list_of_keys = new List<TKey>();
            list_of_strings = new List<string>();
            key_value_dict = new Dictionary<TKey, TValue>();
            value_dict = new Dictionary<string, TValue>();

            this.generate_element_method = kvp_generator;

            for (int i = 0; i < length; i++)
            {
                /* Gnerating equal but different KVP objects */
                KeyValuePair<TKey, TValue> kvp1 = generate_element_method(i);
                KeyValuePair<TKey, TValue> kvp2 = generate_element_method(i);

                list_of_keys.Add(kvp1.Key);
                list_of_strings.Add(kvp1.Key.ToString());

                key_value_dict.Add(kvp2.Key, kvp2.Value);
                value_dict.Add(kvp1.Key.ToString(), kvp1.Value);
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (TKey tk in list_of_keys)
            {
                s += tk.ToString();
            }
            s += "\n";

            foreach (string tk in list_of_strings)
            {
                s += tk;
            }
            s += "\n";
            foreach (KeyValuePair<TKey, TValue> kvp in key_value_dict)
            {
                s += kvp.ToString();
            }
            s += "\n";
            foreach(KeyValuePair<string, TValue> kvp in value_dict)
            {
                s += kvp.ToString();
            }
            return s;
        }
    }
}
