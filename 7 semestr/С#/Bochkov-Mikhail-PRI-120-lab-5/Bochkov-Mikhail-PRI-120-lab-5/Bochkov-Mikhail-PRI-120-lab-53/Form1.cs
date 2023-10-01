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

namespace Bochkov_Mikhail_PRI_120_lab_53
{
    public partial class Form1 : Form
    {
        double a = 1, b = 0, c = 0;
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // генерация коэфицента
            a = (double)trackBar1.Value / 1000.0;
            // вывод значения коэфицента, управляемого данным ползунком.
            // (под TrackBa'ом)
            label4.Text = a.ToString();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            // генерация коэфицента
            b = (double)trackBar2.Value / 1000.0;
            // вывод значения коэфицента, управляемого данным ползунком.
            // (под TrackBa'ом)
            label5.Text = b.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            // генерация коэфицента
            c = (double)trackBar3.Value / 1000.0;
            // вывод значения коэфицента, управляемого данным ползунком.
            // (под TrackBa'ом)
            label6.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // страт таймера, отвечающего за вызов фукнции,
            // визуализирующей кадр
            RenderTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // выход из приложения
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // функция визуализации
            Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация библиотеки GLUT
            Glut.glutInit();
            // инициализация режима окна
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // устанавливаем цвет очистки окна
            Gl.glClearColor(255, 255, 255, 1);

            // устанавливаем порт вывода, основываясь на размерах элемента управления AnT
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            // устанавливаем проекционную матрицу
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            // очищаем ее
            Gl.glLoadIdentity();

            // теперь необходимо корректно настроить 2D ортогональную проекцию
            // в зависимости от того, какая сторона больше
            // мы немного варьируем конфигурацией настройки проекции
            if (AnT.Width <= AnT.Height)
                Glu.gluOrtho2D(0.0, 30.0, 0.0, 30.0 * (float)AnT.Height / (float)AnT.Width);
            else
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0);

            // переходим к объектно-видовой матрице
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
        }
        private void Draw()
        {

            // очищаем буфер цвета
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // активируем рисование в режиме GL_TRIANGLES, при котором три заданные
            // с помощью функции glVertex2d или glVertex3d вершины
            // будут объединяться в полигон (треугольник)

            Gl.glBegin(Gl.GL_TRIANGLES);

            // устанавливаем параметр цвета, основанный на параметрах a b c
            Gl.glColor3d(0.0 + a, 0.0 + b, 0.0 + c);
            // рисуем вершину в координатах 5,5
            Gl.glVertex2d(5.0, 5.0);
            // устанавливаем параметр цвета , основанный на параметрах с a b
            Gl.glColor3d(0.0 + c, 0.0 + a, 0.0 + b);
            // рисуем вершину в координатах 25,5
            Gl.glVertex2d(25.0, 5.0);
            // устанавливаем параметр цвета , основанный на параметрах b c a
            Gl.glColor3d(0.0 + b, 0.0 + c, 0.0 + a);
            // рисуем вершину в координатах 25,5
            Gl.glVertex2d(5.0, 25.0);

            // завершаем режим рисования примитивов
            Gl.glEnd();

            // дожидаемся завершения визуализации кадра
            Gl.glFlush();

            // обновляем изображение в элементе AnT
            AnT.Invalidate();
        }

    }
}
