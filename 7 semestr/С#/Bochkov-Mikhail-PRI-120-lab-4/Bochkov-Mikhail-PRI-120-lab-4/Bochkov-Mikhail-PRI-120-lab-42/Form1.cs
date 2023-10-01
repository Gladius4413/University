using OpenTK.Graphics.ES10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Bochkov_Mikhail_PRI_120_lab_42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            //Gl.glViewport(0, 0, glControl1.Width, glControl1.Height);
            //Gl.glMatrixMode((int)MatrixMode.Projection);
            //Gl.glLoadIdentity();
            //Gl.glOrtho(-1, 1, -1, 1, -1, 1);
            //Gl.glMatrixMode((int)MatrixMode.Modelview);
            //glControl1.Invalidate();
           
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            //Gl.glClearColor(0.5f, 0.5f, 0.75f, 1.0f); // цвет фона
            //                                          // очистка буферов цвета и глубины
            //Gl.glClear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //// поворот изображения
            //Gl.glLoadIdentity();
            //Gl.glRotated(AngleX, 1.0, 0.0, 0.0);
            //Gl.glRotated(AngleY, 0.0, 1.0, 0.0);
            //Gl.glRotated(AngleZ, 0.0, 0.0, 1.0);
            //// формирование изображения
            //Gl.Begin(BeginMode.Lines);
            //Gl.Color3(1f, 0f, 0f); GL.Vertex3(-1f, 0f, 0f); GL.Vertex3(1f, 0f, 0f);
            //Gl.Color3(0f, 1f, 0f); GL.Vertex3(0f, -1f, 0f); GL.Vertex3(0f, 1f, 0f);
            //Gl.Color3(0f, 0f, 1f); GL.Vertex3(0f, 0f, -1f); GL.Vertex3(0f, 0f, 1f);
            //Gl.End();
            //// завершение формирования изображения
            //Gl.Flush();
            //Gl.Finish();
            //glControl1.SwapBuffers();
        }
    }
}
