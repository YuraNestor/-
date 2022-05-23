using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double A, B, K;
        double x, y, t;

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else if ((e.KeyChar == '.' && !string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Contains(".") && textBox.Text != "-"))
            {
                return;
            }
            e.Handled = true;
        }

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                chart1.SaveImage(name, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                chart2.Series[0].Points.Clear();
                chart2.Series[1].Points.Clear();
                chart3.Series[0].Points.Clear();
                chart3.Series[1].Points.Clear();
                if (string.IsNullOrWhiteSpace(textBox4.Text)
                    || string.IsNullOrWhiteSpace(textBox5.Text)
                    || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Ви не заповнили всі поля", "Помилка");
                }
                A = double.Parse(textBox6.Text);
                B = double.Parse(textBox5.Text);
                K = double.Parse(textBox4.Text);
                
                t = A;
                double Kr = (B - A) / K;
                int index = 0;

                while (t < B)
                {
                    
                    y = 3 * t - t * t * t;
                    x = 2 * t - t * t;
                        
                    



                    chart3.Series[1].Points.AddXY(t, y);
                    if (x > A)
                    {
                        chart3.Series[0].Points.AddXY(x, t);
                    }

                    if (y > 3 * A && x < 3 * B)
                    {
                        chart2.Series[0].Points.AddXY(x, y);
                    }

                    //if ((x / y) > 3 * A && (x / y) < 3 * B)
                    //{
                    //    chart2.Series[1].Points.AddXY(y, x);
                    //}
                    if (!Double.IsNaN(y) || !Double.IsNaN(x))
                    {
                        dataGridView2.Rows.Add(y / x, x / y, y, x, t);
                        dataGridView2.Rows[index].HeaderCell.Value = (index).ToString();
                    }
                    index++;
                    t += Kr;
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender; 
            if (char.IsDigit(e.KeyChar)||e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else if ((e.KeyChar == '.' && !string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Contains(".") && textBox.Text != "-"))
            {
                return;
            }
            else if ((e.KeyChar == '-' && string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Contains("-")))
            {
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();
                if (string.IsNullOrWhiteSpace(textBox1.Text) 
                    || string.IsNullOrWhiteSpace(textBox2.Text) 
                    || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Ви не заповнили всі поля", "Помилка");
                }
                A = double.Parse(textBox1.Text);
                B = double.Parse(textBox2.Text);
                K = double.Parse(textBox3.Text);
                x = A;
                int index = 0;
                while (x < B)
                {
                    y = Math.Acos((1-x*x)/(1+x*x));
                    chart1.Series[0].Points.AddXY(x, y);
                    if (!Double.IsNaN(y))
                    {
                        dataGridView1.Rows.Add(y, x);
                        dataGridView1.Rows[index].HeaderCell.Value = (++index).ToString();
                    }
                    x += (B - A)/K;
                }
            }
            catch { }
        }
    }
}
