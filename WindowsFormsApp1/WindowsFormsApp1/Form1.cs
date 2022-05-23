using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            config=Config.GetConfig();
            textBox1.Text = config.TextBoxText;
            xorUse = config.xorUse;
            orUse = config.orUse;
            iUse = config.iUse;
            button17.Visible = config.button17;
            button16.Visible = config.button16;
            button18.Visible = config.button18;
            button19.Visible = config.button19;
            button20.Visible = config.button20;
            button21.Visible = config.button21;
            button22.Visible = config.button22;
            button23.Visible = config.button23;
            button24.Visible = config.button24;
            button25.Visible = config.button25;
            button26.Visible = config.button26;
            button27.Visible = config.button27;
        }
        private bool xorUse = false;
        private bool orUse = false;
        private bool iUse = false;
        //-
        private Config config;
        
        private void button11_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            //allbuttonFromOff();
            //try
            //{
            //    textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 16);

            //}
            //catch { textBox1.Text = "Error"; }
        }
        
        private void buttonToInt_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            button17.Visible = true;
            button16.Visible = true;
            button18.Visible = true;
        }

        private void ButtonTo8_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            //allbuttonFromOff();
            //try
            //{
            //    textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 8);

            //}
            //catch { /*textBox1.Text = "Error";*/ }
        }
        private void buttonToBin_Click(object sender, EventArgs e)
        {

            allbuttonFromOff();
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            //allbuttonFromOff();
            //try
            //{
            //    textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 2);

            //}
            //catch { textBox1.Text = "Error"; }


        }
        //---------------------------------
        private void buttonsDigit_Click(object sender, EventArgs e)
        {
            //if ((textBox1.Text.Last() == 'i' || textBox1.Text.Last() == 'R' || textBox1.Text.Last() == 'r'|| textBox1.Text == "0")&&((sender as Button).Text.Last() == 'i' || (sender as Button).Text.Last() == 'R' || (sender as Button).Text.Last() == 'r'))
            //{
            //    return;
            //}
            if (textBox1.Text == "0" || textBox1.Text == "Error")
            {
                if((sender as Button).Text == "0" & textBox1.Text == "0")
                {
                    textBox1.Text = "00";
                }
                else
                {
                    textBox1.Text = (sender as Button).Text;
                }
                
                
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
            allbuttonFromOff();


        }
        private void buttonOR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "Error")
            {

                return;

            }
            else
            {
                if(xorUse || orUse || iUse)
                {
                    if (!(textBox1.Text.Last() == '1' || textBox1.Text.Last() == '0'))
                    {

                        return;
                    }
                    button38.PerformClick();
                    
                    button37.PerformClick();
                }
                else
                {
                    textBox1.Text += "or";
                    orUse = true;
                }
                
            }
            allbuttonFromOff();
        }

        private void buttonXOR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "Error")
            {

                return;

            }
            else
            {
                if (xorUse || orUse || iUse)
                {
                    if (!(textBox1.Text.Last() == '1' || textBox1.Text.Last() == '0'))
                    {

                        return;
                    }
                    button38.PerformClick();
                    
                    button35.PerformClick();
                }
                else
                {
                    textBox1.Text += "XOR";
                    xorUse = true;
                }
                
            }
            allbuttonFromOff();
        }


        private void buttonI_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "Error")
            {

                return;

            }
            else
            {
                if (xorUse || orUse || iUse)

                {
                    if (!(textBox1.Text.Last() == '1' || textBox1.Text.Last() == '0'))
                    {
                        
                        return;
                    }
                    button38.PerformClick();
                    button36.PerformClick();
                }
                else
                {
                    textBox1.Text += "i";
                    iUse = true;
                }
                
            }
            allbuttonFromOff();
        }

        void button15_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            allbuttonFromOff();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
                case Keys.NumPad0:
                    button10.PerformClick();
                    break;
                case Keys.A:
                    button28.PerformClick();
                    break;
                case Keys.B:
                    button29.PerformClick();
                    break;
                case Keys.C:
                    button31.PerformClick();
                    break;
                case Keys.D:
                    button30.PerformClick();
                    break;
                case Keys.E:
                    button33.PerformClick();
                    break;
                case Keys.F:
                    button32.PerformClick();
                    break;
                case Keys.Back:
                    button15.PerformClick();
                    break;
                default:
                    break;
            }
            
                
            
        }

        
        private void allbuttonFromOff()
        {
            button17.Visible = false;
            button16.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
        }

        private void buttonFromBinarToint_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2));
            }
            catch { textBox1.Text = "Error"; }

        }
        private void buttonFrom8Toint_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8));
            }
            catch { textBox1.Text = "Error"; }
        }

        private void buttonFrom16Toint_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16));
            }
            catch { textBox1.Text = "Error"; }
        }

        private void buttonFromBinarTo8_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 8);
            }
            catch { textBox1.Text = "Error"; }

        }
        private void buttonFromintTo8_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text),  8);
            }
            catch { textBox1.Text = "Error"; }
        }

        private void buttonFrom16To8_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 8);
            }
            catch { textBox1.Text = "Error"; }
        }

        private void buttonFromintToBinar_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 2);
            }
            catch { textBox1.Text = "Error"; }

        }
        private void buttonFrom8ToBinar_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 2);
            }
            catch { textBox1.Text = "Error"; }
        }

        private void buttonFrom16ToBinar_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 2);
            }
            catch { textBox1.Text = "Error"; }
        }

        private void buttonFromBinarTo16_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 16);
            }
            catch { textBox1.Text = "Error"; }

        }
        private void buttonFrom8To16_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 16);
            }
            catch { textBox1.Text = "Error"; }
        }

        private void buttonFromintTo16_Click(object sender, EventArgs e)
        {
            allbuttonFromOff();
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 16);
            }
            catch { textBox1.Text = "Error"; }
        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            string av=string.Empty;
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                if(!(textBox1.Text[i] == '0' || textBox1.Text[i] == '1'))
                {
                    textBox1.Text = "Error";
                    return;
                }
                else
                {
                    if(textBox1.Text[i] == '1')
                    {
                        
                        av += "0";
                    }
                    else
                    {
                        av += "1";
                    }
                }
            }
            textBox1.Text = av;


        }

        

        private void buttonreturn_Click(object sender, EventArgs e)
        {

            /*
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!(textBox1.Text[i] == '0' || textBox1.Text[i] == '1' || textBox1.Text[i] == 'X' || textBox1.Text[i] == 'O' || textBox1.Text[i] == 'R'))
                {
                    textBox1.Text = "Error";
                    return;
                }
                //else
                //{
                //    if (textBox1.Text[i] == 'R')
                //    {

                //        av += "0";
                //    }
                //    else
                //    {
                //        av += "1";
                //    }
                //}
            }

            string[] vs = textBox1.Text.Split('X', 'O', 'R');
            textBox1.Text = "";
            for (int i = 0; i < vs.Length; i++)
            {

                textBox1.Text += vs[i];
            }
            */
            bool validoperation(string[] vs)
            {
                
                for (int i = 0; i < vs.Length; i++)
                {
                    
                        for (int j = 0; j < vs[i].Length; j++)
                    {
                        if (!(vs[i][j] == '1' || vs[i][j] == '0'))
                        {
                            textBox1.Text = "Error";

                            return true;
                        }
                    }
                }
                return false;
            }

            void addnull(string s, string[] vs)
            {
                int maxSize;

                if (vs[0].Length > vs[1].Length)
                {
                    maxSize = vs[0].Length;

                }
                else
                {
                    maxSize = vs[1].Length;
                }

                textBox1.Text = "";
                for (int i = 0; i < maxSize - s.Length; i++)
                {
                    textBox1.Text += 0;
                }
            }
            
            if (xorUse)
            {
                xorUse = false;
                string[] vs = textBox1.Text.Split('X', 'O', 'R');
                vs = vs.Where(v => v.Length > 0).ToArray();
                //textBox1.Text = Convert.ToString(vs.Length);
                if (validoperation(vs))
                {
                    return;
                }
                try {
                    string s = Convert.ToString(Convert.ToInt32(vs[0]) ^ Convert.ToInt32(vs[1]));
                    addnull(s, vs);

                    textBox1.Text += s;
                    return;
                }
                catch {
                    xorUse = true;
                }
                
                
            }
            if (orUse)
            {
                orUse = false;
                string[] vs = textBox1.Text.Split('o', 'r');
                vs = vs.Where(v => v.Length > 0).ToArray();
                //textBox1.Text = Convert.ToString(vs.Length);
                for (int i = 0; i < vs.Length; i++)
                {
                    for (int j = 0; j < vs[i].Length; j++)
                    {
                        if (!(vs[i][j] == 1 || vs[i][j] == 0))
                        {
                            textBox1.Text = "Error";
                            
                            return;
                        }
                    }
                }
                try
                {
                    string s = Convert.ToString(Convert.ToInt32(vs[0]) | Convert.ToInt32(vs[1]));
                    addnull(s, vs);

                    textBox1.Text += s;
                    return;
                }
                catch {
                    orUse = true;
                }
               
            }
            if (iUse)
            {
                iUse = false;
                string[] vs = textBox1.Text.Split('i');
                //vs = vs.Where(v => v.Length > 0).ToArray();
                //textBox1.Text = Convert.ToString(vs.Length);
                if (validoperation(vs))
                {
                    return;
                }
                try
                {
                    string s = Convert.ToString(Convert.ToInt32(vs[0]) & Convert.ToInt32(vs[1]));
                    addnull(s, vs);

                    textBox1.Text += s;
                    return;
                }
                catch
                {
                    iUse = true;
                }
                
            }
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            config.TextBoxText = textBox1.Text;
            config.xorUse = xorUse;
            config.orUse = orUse;
            config.iUse = iUse;
            config.button17 = button17.Visible;
            config.button16 = button16.Visible;
            config.button18 = button18.Visible;
            config.button19 = button19.Visible;
            config.button20 = button20.Visible;
            config.button21 = button21.Visible;
            config.button22 = button22.Visible;
            config.button23 = button23.Visible;
            config.button24 = button24.Visible;
            config.button25 = button25.Visible;
            config.button26 = button26.Visible;
            config.button27 = button27.Visible;
            config.Save();
        }
    }
}
