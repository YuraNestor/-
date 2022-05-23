using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMeteoStantions();
            Gr();
        }
        List<MeteoStantion> meteoStants=new List<MeteoStantion>();
        List<int> globalMSTemp=new List<int>();
        List<int> globalMSPersure = new List<int>();
        List<int> globalMSSped = new List<int>();
        List<int> globalMSRotate = new List<int>();
        public void Gr()
        {
            
            foreach (MeteoStantion me in meteoStants)
            {

                //chart1.Series[6].Points.AddXY(me.getXY().X, me.getXY().Y);
                

                if (me.temperature < 0)
                {
                    chart1.Series[0].Points.AddXY(me.getXY().X, me.getXY().Y);
                    continue;
                }
                if (me.temperature < 10)
                {
                    chart1.Series[1].Points.AddXY(me.getXY().X, me.getXY().Y);
                    continue;
                }
                if (me.temperature < 20)
                {
                    chart1.Series[2].Points.AddXY(me.getXY().X, me.getXY().Y);
                    continue;
                }
                if (me.temperature < 30)
                {
                    chart1.Series[3].Points.AddXY(me.getXY().X, me.getXY().Y);
                    continue;
                }
                if (me.temperature < 35)
                {
                    chart1.Series[4].Points.AddXY(me.getXY().X, me.getXY().Y);
                    continue;
                }
                else
                {
                    chart1.Series[5].Points.AddXY(me.getXY().X, me.getXY().Y);
                    
                }
                

            }
        }
        
        public void InitializeMeteoStantions()
        {
            //newLabel1.Parent = chart1;
            newLabel2.RotateAngle = -60;
            int n = 35;
            int interval=1;
            int[,] m = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    m[i,j] = rnd.Next(-20, 40);
                    globalMSTemp.Add(m[i,j]);
                    globalMSPersure.Add(Math.Abs(m[i,j]*10));
                    globalMSSped.Add(Math.Abs(m[i, j] * 5));
                    globalMSRotate.Add(60);
                }
            }
            windRotate(globalMSRotate);
            tempgradient(m, n, interval);
        }
        
        public void tempgradient(int[,] m, int n, int interval)
        {
            int pretempi = 0;
            int[] pretempj = new int[n];
            //int tr = -5;
            int inta = 0;
            Random rnd = new Random();
            for (int i = 0; i < n * interval; i += interval)
            {
                for (int j = 0; j < n * interval; j += interval)
                {
                    int temp = (m[i / ((n / 5) * interval), j / ((n / 5) * interval)] - rnd.Next(-5, 5) + pretempi + pretempj[j]) / 3;
                    pretempj[j] = pretempi = temp;
                    MeteoStantion ms = new MeteoStantion(new Point(j, i), temp, 12, 3, 60);
                    meteoStants.Add(ms);
                    //tr += 2;
                    inta++;
                }

            }
        }
        public void windRotate(List<int> g)
        {
            newLabel1.RotateAngle = -60;
        }
        //public void InitializeMeteoStantions()
        //{
        //    int n = 15;
        //    int interval = 5;
        //    int[] generaltemps = new int[25];
        //    Random rnd = new Random();
        //    foreach (int i in generaltemps)
        //    {
        //        generaltemps[i] = rnd.Next(-20, 40);
        //    }
        //    int pretemp = 0;
        //    //int tr = -5;

        //    for (int i = 0; i < n * interval; i += interval)
        //    {
        //        for (int j = 0; j < n * interval; j += interval)
        //        {
        //            MeteoStantion ms = new MeteoStantion(new Point(j, i), rnd.Next(-20, 40), 12, 3, 60);
        //            meteoStants.Add(ms);
        //            //tr += 2;
        //        }
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            int ind = Convert.ToInt32((sender as Button).Text) - 1;
            label1.Text = (sender as Button).Text;
            //numericUpDown1.Value = meteoStants[Convert.ToInt32((sender as Button).Text)-1].temperature;
            numericUpDown1.Value = globalMSTemp[ind];
            numericUpDown2.Value = globalMSPersure[ind];
            numericUpDown3.Value = globalMSSped[ind];
            numericUpDown4.Value = globalMSRotate[ind];
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int n = 35;
            int interval = 1;
            int[,] m = new int[5, 5];
            Random rnd = new Random();
            if (label1.Text == "unknown")
            {
                
                return;
            }
            

            globalMSTemp[Convert.ToInt32(label1.Text) - 1] = Convert.ToInt32(numericUpDown1.Value);
            globalMSPersure[Convert.ToInt32(label1.Text)-1] = Convert.ToInt32(numericUpDown2.Value);
            globalMSSped[Convert.ToInt32(label1.Text) - 1] = Convert.ToInt32(numericUpDown3.Value);
            globalMSRotate[Convert.ToInt32(label1.Text) - 1] = Convert.ToInt32(numericUpDown4.Value);
            int it = 0;

            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < 5; j++)
                {
                    if (it < 7)
                    {
                        chart1.Series[it].Points.Clear();
                    }
                    m[i, j] = globalMSTemp[it];
                    it++;
                }
            }
            tempgradient(m, n, interval);
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            label1.Text = "unknown";
            Gr();
        }
    }
}
