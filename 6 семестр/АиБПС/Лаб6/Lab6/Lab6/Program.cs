using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "помехоустойчивое кодирование  это кодирование с возможностью восстановления потерянных или ошибочно принятых данных";
            Console.WriteLine("Исходный текст:  "+ text);
            Console.WriteLine("");
            text = text.Replace(" ", "");

            Dictionary<char, int> dictOfAlph = new Dictionary<char, int>()
            {
                { 'а', 1 },
                { 'б', 9 },
                { 'в', 10 },
                { 'г', 11 },
                { 'д', 12 },
                { 'е', 2 },
                { 'ж', 13 },
                { 'з', 14 },
                { 'и', 3 },
                { 'й', 3 },
                { 'к', 15 },
                { 'л', 16 },
                { 'м', 17 },
                { 'н', 18 },
                { 'о', 4 },
                { 'п', 19 },
                { 'р', 20 },
                { 'с', 21 },
                { 'т', 22 },
                { 'у', 5 },
                { 'ф', 23 },
                { 'х', 24 },
                { 'ц', 25 },
                { 'ч', 26 },
                { 'ш', 27 },
                { 'щ', 28 },
                { 'ы', 29 },
                { 'ь', 30 },
                { 'э', 6 },
                { 'ю', 7 },
                { 'я', 8 },
            };

            string codeStr = Code(dictOfAlph, text);
            Console.WriteLine("Закодированный текст: ");
            Console.WriteLine(codeStr);
        }

        private static string Code(Dictionary<char, int> dictOfAlph, string text)
        {
            string codeStr = "";
            int pointer = 0;
            int[] gammaSigns = new int[] { 2, 3, 10, 4, 1, 5, 6, 7, 8, 11, 15, 14, 12, 13, 9, 0 };
            foreach(var dictValue in dictOfAlph)
            {
                if(pointer == gammaSigns.Length)
                {
                    pointer = 0;
                    
                }
                dictOfAlph[dictValue.Key] = dictValue.Value + gammaSigns[pointer];
                pointer += 1;
                //Console.WriteLine("key: "+dictValue.Key+"  Value: "+dictOfAlph[dictValue.Key]);

            }

            foreach(char element in text)
            {
                codeStr += Convert.ToString(dictOfAlph[element], 2);
            }


            return codeStr;
        }
    }
}
