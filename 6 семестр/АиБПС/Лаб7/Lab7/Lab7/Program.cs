using System;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Помехоустойчивое кодирование  это кодирование с возможностью восстановления потерянных или ошибочно принятых данных";
            Console.Write("Исходный текст: ");
            Console.WriteLine(text);
            Console.WriteLine("");
            text = text.Replace(" ", "").ToLower();
            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int[,] matrix = { { 1, 7, 12 }, { 8, -5, 0 }, { 7, 8, 2 } };
            string codeStr = Code(matrix, alph, text);
            Console.WriteLine("Закодированный текст:");
            Console.Write(codeStr);
        }

        private static string Code(int[,] matrix, string alph, string text)
        {
            string codeStr = "";
            int temp = 0;
            int pointer = 0;
            int[,] multMatrix = new int[3, text.Length / 3];
            int[,] resultMatrix = new int[3, text.Length / 3];
            for (int k = 0; k < text.Length / 3; k++)
            {
                for (int i = k; i < k + 1; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        multMatrix[j, i] = alph.IndexOf(text.Substring(pointer, 1));
                        pointer += 1;
                    }
                }
            }
            for (int k = 0; k < text.Length / 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        temp += matrix[i, j] * multMatrix[j, k];
                    }
                    resultMatrix[i, k] = temp;
                    temp = 0;
                }
            }

            for (int k = 0; k < text.Length / 3; k++)
            {
                for (int i = k; i < k + 1; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        codeStr += resultMatrix[j, i].ToString() + ", ";

                    }
                }
            }
           
            return codeStr;
        }
    }
}
