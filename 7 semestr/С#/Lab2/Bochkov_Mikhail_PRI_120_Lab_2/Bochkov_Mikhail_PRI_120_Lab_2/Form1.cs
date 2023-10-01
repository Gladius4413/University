namespace Bochkov_Mikhail_PRI_120_Lab_2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Point tmp_location;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

            // ��������� ���������� X � ������ � ���������� � ���� �����
            textBox1.Text = e.X.ToString();
            // ��������� ���������� Y � ������ � ���������� � ���� �����
            textBox2.Text = e.Y.ToString();
            if (e.X > 80 && e.X < 195 && e.Y > 100 && e.Y < 135)
            {

                // ���������� ������� ��������� ����
                tmp_location = this.Location;
                // ���������� ����������� �� ���� X � Y � ���������� �� � ��������� �������� �������� ��������� ����
                // ����� ������������ � ��������� �� -100 �� 100.
                tmp_location.X += rnd.Next(-100, 100);
                tmp_location.Y += rnd.Next(-100, 100);

                // ���� ���� ����� �� ������� ������ �� ����� �� ����
                if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
                {
                    // ������ ������������ ������ ����� ����
                    tmp_location.X = _w / 2;
                    tmp_location.Y = _h / 2;
                }

                // ��������� ��������� ���� �� ����� ���������������
                this.Location = tmp_location;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������� ��������� � ������� "�� �������"
            MessageBox.Show("�� �������!!");
            // ��������� ����������
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ������� ���������, � ������� "�� �� ����������� � ����� �����������"
            // ������ �������� - ��������� ���� ��������� "��������"
            // MessageBoxButtons.OK - ��� ����������� ������ �� ����� ���������
            // MessageBoxIcon.Information - ��� ��������� - ����� ����� ������ "����������" � �������������� �������� ������
            MessageBox.Show("�� �� ����������� � ����� �����������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}