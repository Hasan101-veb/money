namespace money
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label2.Visible = false;

            pictureBox2.Visible = false;
            label3.Visible = false;

            pictureBox3.Visible = false;
            label4.Visible = false;

            pictureBox4.Visible = false;
            label5.Visible = false;

            pictureBox5.Visible = false;
            label6.Visible = false;

            pictureBox6.Visible = false;
            label7.Visible = false;

            pictureBox7.Visible = false;
            label8.Visible = false;

            pictureBox8.Visible = false;
            label9.Visible = false;

            string inputText = maskedTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(inputText))
            {
                errorProvider1.SetError(maskedTextBox1, "Məbləğ xanası boş ola bilməz!");
                return;
            }
            if (!int.TryParse(inputText, out int amount))
            {
                errorProvider1.SetError(maskedTextBox1, "Xahiş olunur düzgün ədəd daxil edin!");
                return;
            }

                if (amount <= 0)
            {
                MessageBox.Show("Mənfi və ya sıfır məbləğ xırdalanmaz!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int sum = 0;

            int a = amount / 500;
            if (a > 3) a = 3;
            int b = amount % 500;

            int c = b / 200;
            if (c > 3) a = 3;
            int d = b % 200;

            int f = d / 100;
            if (f > 3) a = 3;
            int g = d % 100;

            int h = g / 50;
            if (h > 3) a = 3;
            int i = g % 50;

            int j = i / 20;
            if (j > 3) a = 3;
            int k = i % 20;

            int l = k / 10;
            if (l > 3) a = 3;
            int m = k % 10;

            int n = m / 5;
            if (n > 3) a = 3;
            int o = m % 5;

            int p = o / 1;
            if (p > 3) a = 3;
            int q = o % 1;

            if (a > 0)
            {
                pictureBox8.Visible = true;
                label9.Text = a.ToString();
                label9.Visible = true;
            }
            if (c > 0)
            {
                pictureBox7.Visible = true;
                label8.Text = c.ToString();
                label8.Visible = true;
            }
            if (f > 0)
            {
                pictureBox6.Visible = true;
                label7.Text = f.ToString();
                label7.Visible = true;
            }
            if (h > 0)
            {
                pictureBox5.Visible = true;
                label6.Text = h.ToString();
                label6.Visible = true;
            }
            if (j > 0)
            {
                pictureBox4.Visible = true;
                label5.Text = j.ToString();
                label5.Visible = true;
            }
            if (l > 0)
            {
                pictureBox3.Visible = true;
                label4.Text = l.ToString();
                label4.Visible = true;
            }
            if (n > 0)
            {
                pictureBox2.Visible = true;
                label3.Text = n.ToString();
                label3.Visible = true;
            }
            if (p > 0)
            {
                pictureBox1.Visible = true;
                label2.Text = p.ToString();
                label2.Visible = true;
            }
        }
    }
}

