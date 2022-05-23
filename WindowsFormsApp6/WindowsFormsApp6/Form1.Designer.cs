namespace WindowsFormsApp6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.button26 = new System.Windows.Forms.Button();
            this.newLabel1 = new newLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.newLabel2 = new newLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart1.BorderlineColor = System.Drawing.Color.IndianRed;
            chartArea4.CursorX.LineColor = System.Drawing.Color.Brown;
            chartArea4.CursorX.SelectionColor = System.Drawing.Color.Chartreuse;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.HeaderSeparatorColor = System.Drawing.Color.DimGray;
            legend4.ItemColumnSeparatorColor = System.Drawing.Color.IndianRed;
            legend4.Name = "Legend1";
            legend4.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            legend4.TitleForeColor = System.Drawing.Color.DarkGray;
            legend4.TitleSeparatorColor = System.Drawing.Color.Firebrick;
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(83, 57);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(255)))));
            series22.CustomProperties = "BubbleMaxSize=6, BubbleMinSize=1";
            series22.Legend = "Legend1";
            series22.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series22.Name = "-20°- 0°";
            series22.YValuesPerPoint = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(65)))), ((int)(((byte)(243)))), ((int)(((byte)(194)))));
            series23.CustomProperties = "BubbleUseSizeForLabel=True, BubbleMaxSize=6, BubbleMinSize=1";
            series23.Legend = "Legend1";
            series23.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series23.Name = "0°- 10°";
            series23.YValuesPerPoint = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(44)))), ((int)(((byte)(233)))), ((int)(((byte)(16)))));
            series24.CustomProperties = "BubbleMaxSize=6, BubbleMinSize=1";
            series24.Legend = "Legend1";
            series24.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series24.Name = "10°- 20°";
            series24.YValuesPerPoint = 2;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series25.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(57)))));
            series25.CustomProperties = "BubbleMaxSize=6, BubbleMinSize=1";
            series25.Legend = "Legend1";
            series25.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series25.Name = "20°- 30°";
            series25.YValuesPerPoint = 2;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series26.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(6)))));
            series26.CustomProperties = "BubbleMaxSize=6, BubbleMinSize=1";
            series26.Legend = "Legend1";
            series26.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series26.Name = "30°- 35°";
            series26.YValuesPerPoint = 2;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series27.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(252)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            series27.CustomProperties = "BubbleMaxSize=6, BubbleMinSize=1";
            series27.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series27.Legend = "Legend1";
            series27.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series27.Name = ">35°";
            series27.YValuesPerPoint = 2;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series28.Color = System.Drawing.Color.Black;
            series28.Legend = "Legend1";
            series28.Name = "Series1";
            series28.YValuesPerPoint = 2;
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Series.Add(series25);
            this.chart1.Series.Add(series26);
            this.chart1.Series.Add(series27);
            this.chart1.Series.Add(series28);
            this.chart1.Size = new System.Drawing.Size(552, 433);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 1;
            this.button1.Text = "21";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 1;
            this.button2.Text = "22";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 10);
            this.button3.TabIndex = 1;
            this.button3.Text = "23";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(10, 10);
            this.button4.TabIndex = 1;
            this.button4.Text = "24";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(413, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(10, 10);
            this.button5.TabIndex = 1;
            this.button5.Text = "25";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(226, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(10, 10);
            this.button6.TabIndex = 1;
            this.button6.Text = "16";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(273, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(10, 10);
            this.button7.TabIndex = 1;
            this.button7.Text = "17";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(317, 184);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(10, 10);
            this.button8.TabIndex = 1;
            this.button8.Text = "18";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(369, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(10, 10);
            this.button9.TabIndex = 1;
            this.button9.Text = "19";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(413, 184);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(10, 10);
            this.button10.TabIndex = 1;
            this.button10.Text = "20";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(226, 232);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(10, 10);
            this.button11.TabIndex = 1;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(273, 232);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(10, 10);
            this.button12.TabIndex = 1;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(317, 232);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(10, 10);
            this.button13.TabIndex = 1;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button1_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(369, 232);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(10, 10);
            this.button14.TabIndex = 1;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button1_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(413, 232);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(10, 10);
            this.button15.TabIndex = 1;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button1_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(226, 283);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(10, 10);
            this.button16.TabIndex = 1;
            this.button16.Text = "6";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button1_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(273, 283);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(10, 10);
            this.button17.TabIndex = 1;
            this.button17.Text = "7";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button1_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(317, 283);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(10, 10);
            this.button18.TabIndex = 1;
            this.button18.Text = "8";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button1_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(369, 283);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(10, 10);
            this.button19.TabIndex = 1;
            this.button19.Text = "9";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button1_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(413, 283);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(10, 10);
            this.button20.TabIndex = 1;
            this.button20.Text = "10";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button1_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(226, 337);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(10, 10);
            this.button21.TabIndex = 1;
            this.button21.Text = "1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button1_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(273, 337);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(10, 10);
            this.button22.TabIndex = 1;
            this.button22.Text = "2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button1_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(317, 337);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(10, 10);
            this.button23.TabIndex = 1;
            this.button23.Text = "3";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button1_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(369, 337);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(10, 10);
            this.button24.TabIndex = 1;
            this.button24.Text = "4";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button1_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(413, 337);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(10, 10);
            this.button25.TabIndex = 1;
            this.button25.Text = "5";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "unknown";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(664, 96);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(664, 146);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(664, 184);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 3;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(664, 232);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown4.TabIndex = 3;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.Location = new System.Drawing.Point(664, 283);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(92, 38);
            this.button26.TabIndex = 4;
            this.button26.Text = "Edit";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // newLabel1
            // 
            this.newLabel1.AutoSize = true;
            this.newLabel1.BackColor = System.Drawing.Color.Transparent;
            this.newLabel1.ForeColor = System.Drawing.Color.Black;
            this.newLabel1.Location = new System.Drawing.Point(874, 474);
            this.newLabel1.Name = "newLabel1";
            this.newLabel1.NewText = null;
            this.newLabel1.RotateAngle = 0;
            this.newLabel1.Size = new System.Drawing.Size(34, 16);
            this.newLabel1.TabIndex = 6;
            this.newLabel1.Text = "----->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meteo stantion";
            // 
            // newLabel2
            // 
            this.newLabel2.AutoSize = true;
            this.newLabel2.Location = new System.Drawing.Point(874, 474);
            this.newLabel2.Name = "newLabel2";
            this.newLabel2.NewText = null;
            this.newLabel2.RotateAngle = 0;
            this.newLabel2.Size = new System.Drawing.Size(72, 16);
            this.newLabel2.TabIndex = 8;
            this.newLabel2.Text = "newLabel2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Persure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(823, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wind sped";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(823, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wind rotate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 502);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newLabel1);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button button26;
        private newLabel newLabel1;
        private System.Windows.Forms.Label label2;
        private newLabel newLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

