using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Key = ");
            string key = Console.ReadLine();
            int m = key.Length - 2;


            Console.Write("Text = ");
            string data = Console.ReadLine();
            data = data.ToLower();
            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Console.WriteLine("");



            string codeStr = Code(key, m, alph, data);
            Console.WriteLine(codeStr);
            Console.WriteLine("");

            // string strForDecode = "Фу эъцё сйу дюсягм ьръгм С аяцшффжмм схщм зпаэпдпьйс Ню т щхитрд хе сщтзл сбула";
            // strForDecode = strForDecode.ToLower();
            string decodeStr = Decode(key, m, alph, codeStr);
            Console.WriteLine(decodeStr);

        }

       

        private static string Code(string key, int m, string alph, string data)
        {
            List<string> strs = new List<string>();
            int i = 0;
            foreach (char ch in key)
            {
                strs.Add(alph.Substring(alph.IndexOf(ch)) + alph.Substring(0, alph.IndexOf(ch)));
                Console.WriteLine(strs[i]);
                i++;
            }
            Console.WriteLine("");
            data = data.Replace(" ", "");
            Console.WriteLine(data);
            string newData = "";
            int pointer = 0;
            foreach (char ch in data)
            {
                if (pointer == key.Length)
                {
                    newData += " ";
                    pointer = 0;
                }
                int index = alph.IndexOf(ch);
                newData += strs[pointer].Substring(index, 1);
                pointer += 1;
            }
            Console.WriteLine("");
            return newData;
        }
        private static string Decode(string key, int m, string alph, string codeStr)
        {
            List<string> strs = new List<string>();
            int i = 0;
            foreach (char ch in key)
            {
                strs.Add(alph.Substring(alph.IndexOf(ch)) + alph.Substring(0, alph.IndexOf(ch)));
                Console.WriteLine(strs[i]);
                i++;
            }
            Console.WriteLine("");
            codeStr = codeStr.Replace(" ", "");
            Console.WriteLine(codeStr);
            string newData = "";
            int pointer = 0;
            foreach (char ch in codeStr)
            {
                if (pointer == key.Length)
                {
                    newData += " ";
                    pointer = 0;
                }
                int index = strs[pointer].IndexOf(ch);
                newData += alph.Substring(index, 1);
                pointer += 1;
            }
            Console.WriteLine("");
            return newData;
        }
    }
}
