using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Bochkov_Mikhail_PRI_120_lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация Glut
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // очистка окна
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соотвествии с размерами элемента anT
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);


            // настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            // теперь необходимо корректно настроить 2D ортогональную проекцию
            // в зависимости от того, какая сторона больше
            // мы немного варьируем то, как будут сконфигурированы настройки проекции

            if ((float)AnT.Width <= (float)AnT.Height)
            {
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Height / (float)AnT.Width, 0.0, 30.0);
            }
            else
            {
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0);
            }



            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gl.glLineWidth(1.1F);
            // очищаем буфер цвета и глубины
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            // очищаем текущую матрицу
            Gl.glLoadIdentity();
            // устанавливаем текущий цвет - красный
            Gl.glColor3f(139, 0, 255);


            // активируем режим рисования линий на основе
            // последовательного соединения всех вершин в отрезки
            Gl.glBegin(Gl.GL_LINE_LOOP);
            // первая вершина будет находиться в начале координат

                Gl.glVertex2d(4, 30);
                Gl.glVertex2d(1, 30);
                Gl.glVertex2d(1, 25);
                Gl.glVertex2d(4, 25);
                Gl.glVertex2d(4, 28);
                Gl.glVertex2d(1, 28);
                Gl.glVertex2d(1, 29);
                Gl.glVertex2d(4, 29);
                Gl.glVertex2d(4, 30);



            // завершаем режим рисования
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_LOOP);


            Gl.glVertex2d(8, 30);
            Gl.glVertex2d(6, 30);
            Gl.glVertex2d(6, 25);
            Gl.glVertex2d(8, 25);
            Gl.glVertex2d(8, 30);





            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_LOOP);


            Gl.glVertex2d(12, 30);
            Gl.glVertex2d(12, 25);
            Gl.glVertex2d(12, 27.5);
            Gl.glVertex2d(10, 27.5);
            Gl.glVertex2d(10, 30);
            Gl.glVertex2d(10.6, 30);
            Gl.glVertex2d(10.6, 28);
            Gl.glVertex2d(11.6, 28);
            Gl.glVertex2d(11.6, 30);


            Gl.glEnd();


            Gl.glBegin(Gl.GL_LINE_LOOP);

         
            Gl.glVertex2d(14, 30);
            Gl.glVertex2d(14, 25);
            Gl.glVertex2d(14, 27.5);
            Gl.glVertex2d(16, 30);
            Gl.glVertex2d(14, 27.5);
            Gl.glVertex2d(16, 25);
            Gl.glVertex2d(14, 27.5);

            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_LOOP);


            Gl.glVertex2d(20, 30);
            Gl.glVertex2d(18, 30);
            Gl.glVertex2d(18, 25);
            Gl.glVertex2d(20, 25);
            Gl.glVertex2d(20, 30);

            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_LOOP);


            Gl.glVertex2d(22, 30);
            Gl.glVertex2d(24, 30);
            Gl.glVertex2d(24, 28);
            Gl.glVertex2d(22, 28);
            Gl.glVertex2d(22, 25);
            Gl.glVertex2d(24, 25);
            Gl.glVertex2d(24, 27);
            Gl.glVertex2d(22, 27);



            Gl.glEnd();


            Gl.glBegin(Gl.GL_LINE_LOOP);


            Gl.glVertex2d(28, 25);
            Gl.glVertex2d(30, 30);
            Gl.glVertex2d(32, 25);
            Gl.glVertex2d(34, 30);
            Gl.glVertex2d(36, 25);
            Gl.glVertex2d(35.5, 25);
            Gl.glVertex2d(34, 29);
            Gl.glVertex2d(32.5, 25);
            Gl.glVertex2d(31.5, 25);
            Gl.glVertex2d(30, 29);
            Gl.glVertex2d(28.5, 25);




            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_LOOP);


            Gl.glVertex2d(38, 25);
            Gl.glVertex2d(40, 30);
            Gl.glVertex2d(42, 25);
            Gl.glVertex2d(41, 27.5);
            Gl.glVertex2d(39, 27.5);




            Gl.glEnd();



            // дожидаемся конца визуализации кадра
            Gl.glFlush();

            // посылаем сигнал перерисовки элемента AnT.
            AnT.Invalidate();
        }
    }
}
