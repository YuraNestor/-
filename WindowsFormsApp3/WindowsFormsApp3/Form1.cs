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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int id = 0;
        private void textBoxDestination_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(numericUpDownAmount.Text) || string.IsNullOrEmpty(numericUpDownWeight.Text) || string.IsNullOrEmpty(textBoxFlightNumber.Text) || string.IsNullOrEmpty(textBoxFtime.Text) || string.IsNullOrEmpty(textBoxDestination.Text))
            {
                if (string.IsNullOrEmpty(textBoxDestination.Text)){
                    buttonAdd.Visible = false;
                }
                return;

            }
            ListViewItem item = new ListViewItem((++id).ToString());
            item.SubItems.Add(textBoxName.Text);
            item.SubItems.Add(numericUpDownAmount.Text);
            item.SubItems.Add(numericUpDownWeight.Text);
            item.SubItems.Add(textBoxFlightNumber.Text);
            item.SubItems.Add(dateTimePicker1.Text);
            item.SubItems.Add(textBoxFtime.Text);
            item.SubItems.Add(textBoxDestination.Text);
            listView1.Items.Add(item);
            button2.Visible = true;
            button2.PerformClick();
            button3.PerformClick();
            //textBoxName.Clear();
            //numericUpDownAmount.Clear();
            //numericUpDownWeight.Clear();
            //textBoxFlightNumber.Clear();
            //this.dateTimePicker1.Value = System.DateTime.Now;
            //textBoxFtime.Clear();
            //textBoxDestination.Clear();
            //buttonAdd.Visible = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count >0){
                try{
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    buttonRemove.Visible = false;
                    buttonEdit.Visible = false;
                }
                catch
                {

                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Visible=true;
            buttonEdit.Visible = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0)
            {
                return;
            }
            
            textBoxName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            numericUpDownAmount.Text = listView1.SelectedItems[0].SubItems[2].Text;
            numericUpDownWeight.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxFlightNumber.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBoxFtime.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBoxDestination.Text = listView1.SelectedItems[0].SubItems[7].Text;
            buttonAdd.Visible = false;
            button1.Visible = true;
            buttonRemove.Visible = false;
            buttonEdit.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listView1.SelectedItems[0].SubItems[1].Text= textBoxName.Text;
            listView1.SelectedItems[0].SubItems[2].Text= numericUpDownAmount.Text;
            listView1.SelectedItems[0].SubItems[3].Text= numericUpDownWeight.Text;
            listView1.SelectedItems[0].SubItems[4].Text= textBoxFlightNumber.Text;
            listView1.SelectedItems[0].SubItems[5].Text= this.dateTimePicker1.Text;
            listView1.SelectedItems[0].SubItems[6].Text= textBoxFtime.Text;
            listView1.SelectedItems[0].SubItems[7].Text= textBoxDestination.Text;
            button2.Visible = true;
            button2.PerformClick();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            //textBoxName.Text = listView1.;
            numericUpDownAmount.Value=0;
            numericUpDownWeight.Value = 0;
            textBoxFlightNumber.Clear();
            this.dateTimePicker1.Value = System.DateTime.Now;
            textBoxFtime.Value= new System.DateTime(2022, 3, 30, 0, 0, 0, 0); 
            textBoxDestination.Clear();
            buttonAdd.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            buttonFind.Visible = false;
            foreach (ListViewItem item in listView1.Items)
            {
                if (Convert.ToDouble(item.SubItems[3].Text) > Convert.ToDouble(numericUpDownFind.Value))
                {
                    ListViewItem item1 = new ListViewItem(item.SubItems[0].Text);
                    item1.SubItems.Add(item.SubItems[1].Text);
                    item1.SubItems.Add(item.SubItems[2].Text);
                    item1.SubItems.Add(item.SubItems[3].Text);
                    item1.SubItems.Add(item.SubItems[4].Text);
                    item1.SubItems.Add(item.SubItems[5].Text);
                    item1.SubItems.Add(item.SubItems[6].Text);
                    item1.SubItems.Add(item.SubItems[7].Text);

                    listView2.Items.Add(item1);
                }
            }
            listView2.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            buttonFind.Visible = true;
            listView2.Visible = false;
            button3.Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            string str;
                            str = item.SubItems[0].Text;
                            str += " ";
                            str += item.SubItems[1].Text;
                            str += " ";
                            str += item.SubItems[2].Text;
                            str += " ";
                            str += item.SubItems[3].Text;
                            str += " ";
                            str += item.SubItems[4].Text;
                            str += " ";
                            str += item.SubItems[5].Text;
                            str += " ";
                            str += item.SubItems[6].Text;
                            str += " ";
                            str += item.SubItems[7].Text;
                            //str += "\n";
                            sw.WriteLine(str);
                            //sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", item.SubItems[0].Text, " ",
                            //    item.SubItems[1].Text, " ",
                            //    item.SubItems[2].Text, " ",
                            //    item.SubItems[3].Text, " ",
                            //    item.SubItems[4].Text, " ",
                            //    item.SubItems[5].Text, " ",
                            //    item.SubItems[6].Text, " ",
                            //    item.SubItems[7].Text, "\n");
                        }
                    }
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "OpenFileDialog Export2File";
            ofd.Filter = "Text File (.txt) | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        string stringlong;
                        while (!string.IsNullOrEmpty(stringlong = sr.ReadLine()))
                        {
                            
                            
                            string[] arrsr = stringlong.Split(' ');
                            ListViewItem item = new ListViewItem(arrsr[0]);

                            
                           
                            item.SubItems.Add(arrsr[1]);
                            item.SubItems.Add(arrsr[2]);
                            item.SubItems.Add(arrsr[3]);
                            item.SubItems.Add(arrsr[4]);
                            item.SubItems.Add(arrsr[5] + " " + arrsr[6]);
                            item.SubItems.Add(arrsr[7]);
                            item.SubItems.Add(arrsr[8]);
                            listView1.Items.Add(item);
                        }
                        
                    }
                }
            }
        }
    }
}
