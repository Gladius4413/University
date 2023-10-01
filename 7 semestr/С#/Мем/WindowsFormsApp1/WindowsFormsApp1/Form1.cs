using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double AngleX;
        private double AngleY;
        private double AngleZ;
        private double AngleDl = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GL.ClearColor(0.5f, 0.5f, 0.75f, 1.0f); // цвет фона
                                                    // очистка буферов цвета и глубины
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            // поворот изображения
            GL.LoadIdentity();
            GL.Rotate(AngleX, 1.0, 0.0, 0.0);
            GL.Rotate(AngleY, 0.0, 1.0, 0.0);
            GL.Rotate(AngleZ, 0.0, 0.0, 1.0);
            // формирование изображения
            GL.Begin(BeginMode.Lines);
            GL.Color3(1f, 0f, 0f); GL.Vertex3(-1f, 0f, 0f); GL.Vertex3(1f, 0f, 0f);
            GL.Color3(0f, 1f, 0f); GL.Vertex3(0f, -1f, 0f); GL.Vertex3(0f, 1f, 0f);
            GL.Color3(0f, 0f, 1f); GL.Vertex3(0f, 0f, -1f); GL.Vertex3(0f, 0f, 1f);
            GL.End();
            // завершение формирования изображения
            GL.Flush();
            GL.Finish();
            glControl1.SwapBuffers();
        }

        private void glControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert: AngleX += AngleDl; break;
                case Keys.Delete: AngleX -= AngleDl; break;
                case Keys.Home: AngleY += AngleDl; break;
                case Keys.End: AngleY -= AngleDl; break;
                case Keys.Prior: AngleZ += AngleDl; break;
                case Keys.Next: AngleZ -= AngleDl; break;
            }
            glControl1.Invalidate();
        }
    }
}
