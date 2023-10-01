namespace Bochkov_Mikhail_PRI_120_Lab_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ������� ���������� rsl, ������� ����� ������� ��������� ������ ���� � ��������
            // (������������ ����� ���� �� ������ �� ���� - ��� � ���� ���������)
            // MessageBox ����� ���������� ������, � ����� ������ Yes No � ������ Question (������)
            DialogResult rsl = MessageBox.Show("�� ������������� ������ ����� �� ����������?", "��������!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ���� ������������ ����� ������ "��"
            if (rsl == DialogResult.Yes)
            {
                // ������� �� ����������
                Application.Exit();
            }
        }

        private void ��������JPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage(true);
        }

        private void ��������PNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage(false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LoadImage(true);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LoadImage(false);
        }
        Image MemForImage;
        private void LoadImage(bool jpg)
        {
            // ����������, ������� ����� ������� ��� ��������� � ���� ��� ������ �����
            openFileDialog1.InitialDirectory = "c:\\";

            // ���� ����� �������� jpg �����
            if (jpg)
            {
                // ������������� ������ ������ ��� �������� - jpg
                openFileDialog1.Filter = "image (JPEG) files (*.jpg)|*.jpg|All files (*.*)|*.*";
            }
            else
            {
                // ������������� ������ ������ ��� �������� - png
                openFileDialog1.Filter = "image (PNG) files (*.png)|*.png|All files (*.*)|*.*";
            }

            // ���� �������� ���� ������ ����� ����������� ������� ����� � �������� ������ ��
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try // ���������� �������
                {
                    // �������� ��������� ���� � ������ openFileDialog1.FileName - ��������� ������������� ����.
                    MemForImage = Image.FromFile(openFileDialog1.FileName);
                    // ������������� �������� � ���� �������� PictureBox
                    pictureBox1.Image = MemForImage;
                }
                catch (Exception ex) // ���� ������� �������� �� �������
                {
                    // ������� ��������� � �������� ������
                    MessageBox.Show("�� ������� ��������� ����: " + ex.Message);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // ������� ����� ��������� ������ Preview,
            // ����������� �� ������ � ����� �������������� ������
            // � �������� ��������� �� �������� ���� ����������� �����������
            Form PreView = new Preview(MemForImage);
            // ����� �� �������� �������� ����
            PreView.ShowDialog();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutProgram = new AboutProgram();
            // ����� �� �������� �������� ����
            AboutProgram.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}