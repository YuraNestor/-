namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxWork = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownExp = new System.Windows.Forms.NumericUpDown();
            this.buttonFind = new System.Windows.Forms.Button();
            this.numericUpDownFind = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.textQu = new System.Windows.Forms.TextBox();
            this.numericUpDownWages = new System.Windows.Forms.NumericUpDown();
            this.checkBoxInsurance = new System.Windows.Forms.CheckBox();
            this.numericUpDownVacation = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.SaveEdits = new System.Windows.Forms.Button();
            this.WoF = new System.Windows.Forms.TextBox();
            this.QuF = new System.Windows.Forms.TextBox();
            this.InsF = new System.Windows.Forms.CheckBox();
            this.WagF = new System.Windows.Forms.NumericUpDown();
            this.VacF = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WagF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacF)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(824, 422);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Work";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qualification";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Experience";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Wages";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Insurance";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vacation";
            this.columnHeader7.Width = 76;
            // 
            // textBoxWork
            // 
            this.textBoxWork.Location = new System.Drawing.Point(855, 52);
            this.textBoxWork.Name = "textBoxWork";
            this.textBoxWork.Size = new System.Drawing.Size(149, 22);
            this.textBoxWork.TabIndex = 1;
            this.textBoxWork.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1040, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(969, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1040, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qualification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1040, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vacation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1040, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Experience";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1040, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wages";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.Location = new System.Drawing.Point(855, 459);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 47);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Firebrick;
            this.buttonRemove.Location = new System.Drawing.Point(25, 496);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(166, 47);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Silver;
            this.buttonSave.Location = new System.Drawing.Point(222, 496);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(166, 47);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save in file";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Silver;
            this.buttonOpen.Location = new System.Drawing.Point(422, 496);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(166, 47);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Open from file";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Yellow;
            this.buttonEdit.Location = new System.Drawing.Point(25, 564);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(166, 47);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(868, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(975, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownExp
            // 
            this.numericUpDownExp.Location = new System.Drawing.Point(855, 130);
            this.numericUpDownExp.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownExp.Name = "numericUpDownExp";
            this.numericUpDownExp.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownExp.TabIndex = 6;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(775, 21);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 9;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // numericUpDownFind
            // 
            this.numericUpDownFind.DecimalPlaces = 1;
            this.numericUpDownFind.Location = new System.Drawing.Point(359, 23);
            this.numericUpDownFind.Name = "numericUpDownFind";
            this.numericUpDownFind.Size = new System.Drawing.Size(55, 22);
            this.numericUpDownFind.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(797, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textQu
            // 
            this.textQu.Location = new System.Drawing.Point(855, 90);
            this.textQu.Name = "textQu";
            this.textQu.Size = new System.Drawing.Size(149, 22);
            this.textQu.TabIndex = 1;
            this.textQu.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // numericUpDownWages
            // 
            this.numericUpDownWages.DecimalPlaces = 1;
            this.numericUpDownWages.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWages.Location = new System.Drawing.Point(855, 170);
            this.numericUpDownWages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownWages.Name = "numericUpDownWages";
            this.numericUpDownWages.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWages.TabIndex = 6;
            // 
            // checkBoxInsurance
            // 
            this.checkBoxInsurance.AutoSize = true;
            this.checkBoxInsurance.Location = new System.Drawing.Point(855, 215);
            this.checkBoxInsurance.Name = "checkBoxInsurance";
            this.checkBoxInsurance.Size = new System.Drawing.Size(87, 20);
            this.checkBoxInsurance.TabIndex = 10;
            this.checkBoxInsurance.Text = "Insurance";
            this.checkBoxInsurance.UseVisualStyleBackColor = true;
            // 
            // numericUpDownVacation
            // 
            this.numericUpDownVacation.Location = new System.Drawing.Point(855, 248);
            this.numericUpDownVacation.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownVacation.Name = "numericUpDownVacation";
            this.numericUpDownVacation.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVacation.TabIndex = 6;
            this.numericUpDownVacation.ValueChanged += new System.EventHandler(this.numericUpDownVacation_ValueChanged);
            // 
            // SaveEdits
            // 
            this.SaveEdits.Location = new System.Drawing.Point(614, 496);
            this.SaveEdits.Name = "SaveEdits";
            this.SaveEdits.Size = new System.Drawing.Size(87, 47);
            this.SaveEdits.TabIndex = 11;
            this.SaveEdits.Text = "SaveEdits";
            this.SaveEdits.UseVisualStyleBackColor = true;
            this.SaveEdits.Visible = false;
            this.SaveEdits.Click += new System.EventHandler(this.SaveEdits_Click);
            // 
            // WoF
            // 
            this.WoF.Location = new System.Drawing.Point(92, 23);
            this.WoF.Name = "WoF";
            this.WoF.Size = new System.Drawing.Size(75, 22);
            this.WoF.TabIndex = 12;
            // 
            // QuF
            // 
            this.QuF.Location = new System.Drawing.Point(222, 22);
            this.QuF.Name = "QuF";
            this.QuF.Size = new System.Drawing.Size(75, 22);
            this.QuF.TabIndex = 12;
            // 
            // InsF
            // 
            this.InsF.AutoSize = true;
            this.InsF.Location = new System.Drawing.Point(648, 24);
            this.InsF.Name = "InsF";
            this.InsF.Size = new System.Drawing.Size(87, 20);
            this.InsF.TabIndex = 10;
            this.InsF.Text = "Insurance";
            this.InsF.UseVisualStyleBackColor = true;
            // 
            // WagF
            // 
            this.WagF.DecimalPlaces = 1;
            this.WagF.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WagF.Location = new System.Drawing.Point(461, 23);
            this.WagF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WagF.Name = "WagF";
            this.WagF.Size = new System.Drawing.Size(84, 22);
            this.WagF.TabIndex = 6;
            // 
            // VacF
            // 
            this.VacF.Location = new System.Drawing.Point(713, 22);
            this.VacF.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.VacF.Name = "VacF";
            this.VacF.Size = new System.Drawing.Size(56, 22);
            this.VacF.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Work";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Qualification";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Experience";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Wages";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(709, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Vacation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 622);
            this.Controls.Add(this.QuF);
            this.Controls.Add(this.WoF);
            this.Controls.Add(this.SaveEdits);
            this.Controls.Add(this.InsF);
            this.Controls.Add(this.checkBoxInsurance);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.numericUpDownFind);
            this.Controls.Add(this.VacF);
            this.Controls.Add(this.numericUpDownVacation);
            this.Controls.Add(this.WagF);
            this.Controls.Add(this.numericUpDownWages);
            this.Controls.Add(this.numericUpDownExp);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQu);
            this.Controls.Add(this.textBoxWork);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WagF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox textBoxWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownExp;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.NumericUpDown numericUpDownFind;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textQu;
        private System.Windows.Forms.NumericUpDown numericUpDownWages;
        private System.Windows.Forms.CheckBox checkBoxInsurance;
        private System.Windows.Forms.NumericUpDown numericUpDownVacation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button SaveEdits;
        private System.Windows.Forms.TextBox WoF;
        private System.Windows.Forms.TextBox QuF;
        private System.Windows.Forms.CheckBox InsF;
        private System.Windows.Forms.NumericUpDown WagF;
        private System.Windows.Forms.NumericUpDown VacF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

