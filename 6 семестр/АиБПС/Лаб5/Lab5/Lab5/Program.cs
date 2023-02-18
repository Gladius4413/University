using System;
using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();
            string text = "Двадцать первое Ночь Понедельник Очертанья столицы во мгле Сочинил же какой то бездельник что бывает любовь на земле И от лености или от скуки все поверили так и живут ждут свиданий боятся разлуки и любовные песни поют";
            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string newKey = "";

            text = text.Replace(" ", "").ToLower();


            int pointer = 0;
            int index = 0;
            foreach (char ch in alph)
            {
                index = key.IndexOf(ch);
                if (index != -1)
                {
                    newKey += key[index];
                    pointer += 1;
                }
            }
            Console.WriteLine("Новый ключ: " + newKey);
            string codeStr = Code(text, key, newKey);
            Console.WriteLine("");
            Console.WriteLine("Зашифрованная строка: ");
            Console.WriteLine(codeStr);
        }

        private static string Code(string text, string key, string newKey)
        {
            string codeStr = "";
            string[] listOfParts = new string[newKey.Length];
            int pointer = 0;
            foreach (char ch in text)
            {
                if (pointer == newKey.Length)
                {
                    pointer = 0;


                }

                listOfParts[pointer] += ch;
                pointer += 1;


            }
            foreach (char ch in newKey)
            {
                pointer = key.IndexOf(ch);
                codeStr += listOfParts[pointer];
            }
            Console.WriteLine("Части зашифрованного слова: ");
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine(listOfParts[i]);
            }
           
            return codeStr;
        }
    }
}
