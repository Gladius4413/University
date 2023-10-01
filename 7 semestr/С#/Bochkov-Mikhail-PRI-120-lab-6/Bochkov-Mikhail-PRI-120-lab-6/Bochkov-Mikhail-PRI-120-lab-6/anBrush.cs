using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bochkov_Mikhail_PRI_120_lab_6
{
    internal class anBrush
    {
        public Bitmap myBrush;
        private bool IsErase = false;

        // стандартная (квадратная) кисть, с указанием масштаба
        // и флагом закраски узлов

        public anBrush(int Value, bool Special)
        {
            if (!Special)
            {
                myBrush = new Bitmap(Value, Value);

                for (int ax = 0; ax < Value; ax++)
                    for (int bx = 0; bx < Value; bx++)
                        myBrush.SetPixel(0, 0, Color.Black);

                // не является ластиком
                IsErase = false;
            }
            else
            {
                // здесь мы будем размещать предустановленные кисти
                // созданная нами ранее кисть в виде перекрестия двух линий будет китсью по умолчанию
                // на тот случай, если задан не описанный номер кисти

                switch (Value)
                {
                    // специальная кисть по умолчанию
                    default:
                        {
                            myBrush = new Bitmap(5, 5);

                            for (int ax = 0; ax < 5; ax++)
                                for (int bx = 0; bx < 5; bx++)
                                    myBrush.SetPixel(ax, bx, Color.Red);

                            myBrush.SetPixel(0, 2, Color.Black);
                            myBrush.SetPixel(1, 2, Color.Black);

                            myBrush.SetPixel(2, 0, Color.Black);
                            myBrush.SetPixel(2, 1, Color.Black);
                            myBrush.SetPixel(2, 2, Color.Black);
                            myBrush.SetPixel(2, 3, Color.Black);
                            myBrush.SetPixel(2, 4, Color.Black);

                            myBrush.SetPixel(3, 2, Color.Black);
                            myBrush.SetPixel(4, 2, Color.Black);

                            // не является ластиком
                            IsErase = false;

                            break;
                        }
                    case 1: // стерка
                        {
                            // создается так же, как и обычная кисть,
                            // но имеет флаг IsErase равный true
                            myBrush = new Bitmap(5, 5);

                            for (int ax = 0; ax < Value; ax++)
                                for (int bx = 0; bx < Value; bx++)
                                    myBrush.SetPixel(0, 0, Color.Black);

                            // является ластиком
                            IsErase = true;
                            break;
                        }
                }
            }
        }

        // второй конструктор будет позволять загружать кисть из стороннего файла
        public anBrush(string FromFile)
        {
            string path = Directory.GetCurrentDirectory();
            path += "\\" + FromFile;

            myBrush = new Bitmap(path);
        }
        public bool IsBrushErase()
        {
            return IsErase;
        }
    }
}
