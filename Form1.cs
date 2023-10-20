namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double C1, C2, C3, C4, PRO;

            C1 = double.Parse(cal1.Text);
            C2 = double.Parse(cal2.Text);
            C3 = double.Parse(cal3.Text);
            C4 = double.Parse(cal4.Text);

            PRO = (C1 + C2 + C3 + C4) / 4;

            promedio.Text = PRO.ToString();

            if (PRO >= 6)
            {
                if ((C1 >= 6) && (C2 >= 6) && (C3 >= 6) && (C4 >= 6))
                {
                    MessageBox.Show("APROBADO");
                }
                else
                {
                    MessageBox.Show("REPROBADO");
                }
            }
            else
            {
                MessageBox.Show("REPROBADO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cal1.Text = " ";
            cal2.Text = " ";
            cal3.Text = " ";
            cal4.Text = " ";
            promedio.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}