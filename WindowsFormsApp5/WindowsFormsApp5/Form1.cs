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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int id = 0;

        private string xsdpath = "C://Users//yurko//source//repos//WindowsFormsApp5//WindowsFormsApp5//dmn.xsd";

        private string openfilepath = "";
        private void textBoxDestination_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Visible = true;
        }

        List<Worker> workersList = new List<Worker>();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxWork.Text) || string.IsNullOrEmpty(textQu.Text))
            {
                
                
                buttonAdd.Visible = false;
                
                return;

            }
            workersList.Add(new Worker(id++, textBoxWork.Text, textQu.Text, Convert.ToInt32(numericUpDownExp.Value), Convert.ToDouble(numericUpDownWages.Value), checkBoxInsurance.Checked, Convert.ToInt32(numericUpDownVacation.Value)));
            //ListViewItem item = new ListViewItem((++id).ToString());
            ViewRefresh();
            //item.SubItems.Add(textBoxWork.Text);
            //item.SubItems.Add(numericUpDownAmount.Text);
            //item.SubItems.Add(numericUpDownExp.Text);
            //item.SubItems.Add(textBoxFlightNumber.Text);
            //item.SubItems.Add(dateTimePicker1.Text);
            //item.SubItems.Add(textBoxFtime.Text);
            //item.SubItems.Add(textBoxDestination.Text);
            //listView1.Items.Add(item);
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

        private void ViewRefresh()
        {
            
            listView1.Items.Clear();
            foreach (Worker worker in workersList)
            {
                ListViewItem item = new ListViewItem(worker.WorkerId.ToString());

                item.SubItems.Add(worker.Work);
                item.SubItems.Add(worker.Qualification);
                item.SubItems.Add(worker.Experience.ToString());
                item.SubItems.Add(worker.Wages.ToString());
                item.SubItems.Add(worker.Insurance.ToString());
                item.SubItems.Add(worker.Vacation.ToString());
                
                listView1.Items.Add(item);
                if (id == 0)
                {
                    id = worker.WorkerId++;
                }
                
                
            }
            if (!buttonFind.Visible)
            {
                refind();
            }
        }

        private Worker GetWorkerById(int id)
        {
            //int i = 0;
            foreach (Worker worker in workersList)
            {
                if(worker.WorkerId == id)
                {
                    //return workersList[i];
                    return worker;
                }
                //i++;
            }
            return null;
        }
        private int GetWorkerIndexById(int id)
        {
            int i = 0;
            foreach (Worker worker in workersList)
            {
                if (worker.WorkerId == id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    
                    workersList.RemoveAt(GetWorkerIndexById(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text)));
                    ViewRefresh();
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
            buttonRemove.Visible = true;
            buttonEdit.Visible = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            textBoxWork.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textQu.Text = listView1.SelectedItems[0].SubItems[2].Text;
            numericUpDownExp.Text = listView1.SelectedItems[0].SubItems[3].Text;
            numericUpDownWages.Text = listView1.SelectedItems[0].SubItems[4].Text;
            checkBoxInsurance.Text = listView1.SelectedItems[0].SubItems[5].Text;
            numericUpDownVacation.Text = listView1.SelectedItems[0].SubItems[6].Text;
            
            buttonAdd.Visible = false;
            button1.Visible = true;
            buttonRemove.Visible = false;
            buttonEdit.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Worker worker1 = new Worker(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text), textBoxWork.Text, textQu.Text, Convert.ToInt32(numericUpDownExp.Value), Convert.ToDouble(numericUpDownWages.Value), checkBoxInsurance.Checked, Convert.ToInt32(numericUpDownVacation.Value));

            workersList[GetWorkerIndexById(worker1.WorkerId)]=worker1;

            //GetWorkerById(worker1.WorkerId)=worker1;
            ViewRefresh();
            button2.Visible = true;
            button2.PerformClick();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxWork.Clear();
            //textBoxName.Text = listView1.;
            textQu.Clear();
            numericUpDownExp.Value = 0;
            numericUpDownVacation.Value = 0;
            checkBoxInsurance.Checked = false;
            numericUpDownWages.Value = 0;
            
            buttonAdd.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }
        private void refind()
        {
            buttonFind.Visible = false;
            listView1.Items.Clear();
            foreach (Worker worker in workersList)
            {
                if (!String.IsNullOrEmpty(WoF.Text))
                {
                    if(worker.Work != WoF.Text)
                    {
                        continue;
                    }
                }
                if (!String.IsNullOrEmpty(QuF.Text))
                {
                    if (worker.Qualification != QuF.Text)
                    {
                        continue;
                    }
                }
                if (numericUpDownFind.Value!=0)
                {
                    if (worker.Experience < numericUpDownFind.Value)
                    {
                        continue;
                    }
                }
                if (worker.Wages != 0)
                {
                    if (worker.Wages < Convert.ToDouble(WagF.Value))
                    {
                        continue;
                    }
                }
                if (worker.Insurance != InsF.Checked)
                {
                    continue;
                }
                if (worker.Vacation != 0)
                {
                    if (worker.Vacation < VacF.Value)
                    {
                        continue;
                    }
                }
                //if (worker.Experience > Convert.ToInt32(numericUpDownFind.Value))
                //{
                    ListViewItem item = new ListViewItem(worker.WorkerId.ToString());

                    item.SubItems.Add(worker.Work);
                    item.SubItems.Add(worker.Qualification);
                    item.SubItems.Add(worker.Experience.ToString());
                    item.SubItems.Add(worker.Wages.ToString());
                    item.SubItems.Add(worker.Insurance.ToString());
                    item.SubItems.Add(worker.Vacation.ToString());

                    listView1.Items.Add(item);
                //}
            }

            button3.Visible = true;
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            refind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            buttonFind.Visible = true;
            ViewRefresh();
            button3.Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.xml) | *.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Worker>));
                    using (var writer = new StreamWriter(filename))
                    {
                        xmlSerializer.Serialize(writer, workersList);
                    }
                    //XmlSerializer serialiser = new XmlSerializer(typeof(List<Worker>));

                    //TextWriter Filestream = new StreamWriter(filename);

                    //serialiser.Serialize(Filestream, workersList);

                    //Filestream.Close();
                    //    using (StreamWriter sw = new StreamWriter(filename))
                    //    {
                    //        foreach (ListViewItem item in listView1.Items)
                    //        {
                    //            string str;
                    //            str = item.SubItems[0].Text;
                    //            str += " ";
                    //            str += item.SubItems[1].Text;
                    //            str += " ";
                    //            str += item.SubItems[2].Text;
                    //            str += " ";
                    //            str += item.SubItems[3].Text;
                    //            str += " ";
                    //            str += item.SubItems[4].Text;
                    //            str += " ";
                    //            str += item.SubItems[5].Text;
                    //            str += " ";
                    //            str += item.SubItems[6].Text;


                    //            //str += "\n";
                    //            sw.WriteLine(str);
                    //            //sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", item.SubItems[0].Text, " ",
                    //            //    item.SubItems[1].Text, " ",
                    //            //    item.SubItems[2].Text, " ",
                    //            //    item.SubItems[3].Text, " ",
                    //            //    item.SubItems[4].Text, " ",
                    //            //    item.SubItems[5].Text, " ",
                    //            //    item.SubItems[6].Text, " ",
                    //            //    item.SubItems[7].Text, "\n");
                    //        }
                    //    }
                }
            }
        }
        private void Validate(string filename)
        {
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.Schemas.Add(null, xsdpath);
            using(XmlReader reader = XmlReader.Create(filename, xmlReaderSettings))
            {
                while (reader.Read()) { }
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "OpenFileDialog Export2File";
            ofd.Filter = "Text File (.xml) | *.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName.ToString();
                if (filename != "")
                {

                    try
                    {
                        Validate(filename);
                        var xmlSerializer = new XmlSerializer(typeof(List<Worker>));
                        using (var reader = new StreamReader(filename))
                        {
                            var workers1 = (List<Worker>)xmlSerializer.Deserialize(reader);
                            workersList = workers1;
                        }
                        openfilepath = filename;
                        SaveEdits.Visible=true;
                    }
                    catch(Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    
                    

                    ViewRefresh();
                    //XDocument xmlDoc = XDocument.Load(filename);

                    //var list = xmlDoc.Root.Elements("Worker")
                    //                           .Select(element => element.Value)
                    //                           .ToList();
                    //List<Worker> workers = new List<Worker>();
                    //foreach (string stringlong in list)
                    //{




                    //        string[] arrsr = stringlong.Split(' ');
                    //        Worker worker1 = new Worker(Convert.ToInt32(arrsr[1]), arrsr[1], arrsr[1], Convert.ToInt32(arrsr[1]), Convert.ToDouble(arrsr[1]), Convert.ToBoolean(arrsr[1]), Convert.ToInt32(arrsr[1]));
                    //        workers.Add(worker1);







                    //    workersList.Add(new Worker(id, textBoxWork.Text, textQu.Text, Convert.ToInt32(numericUpDownExp.Value), Convert.ToDouble(numericUpDownWages.Value), checkBoxInsurance.Checked, Convert.ToInt32(numericUpDownVacation.Value)));
                    //}
                    //workersList = workers;
                    //ViewRefresh();
                    //using (StreamReader sr = new StreamReader(filename))
                    //{
                    //    string stringlong;
                    //    while (!string.IsNullOrEmpty(stringlong = sr.ReadLine()))
                    //    {


                    //        string[] arrsr = stringlong.Split(' ');
                    //        ListViewItem item = new ListViewItem(arrsr[0]);



                    //        item.SubItems.Add(arrsr[1]);
                    //        item.SubItems.Add(arrsr[2]);
                    //        item.SubItems.Add(arrsr[3]);
                    //        item.SubItems.Add(arrsr[4]);
                    //        item.SubItems.Add(arrsr[5] + " " + arrsr[6]);
                    //        item.SubItems.Add(arrsr[7]);

                    //        listView1.Items.Add(item);
                    //    }

                    //}
                }
            }
        }

        private void numericUpDownVacation_ValueChanged(object sender, EventArgs e)
        {
            buttonAdd.Visible = true;
        }

        private void SaveEdits_Click(object sender, EventArgs e)
        {
            if(openfilepath != "")
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Worker>));
                using (var writer = new StreamWriter(openfilepath))
                {
                    xmlSerializer.Serialize(writer, workersList);
                }
            }
        }
    }
}
