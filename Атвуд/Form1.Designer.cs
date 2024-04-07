namespace Atwood
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.TimerLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Disk_mass = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.PauseBottom = new System.Windows.Forms.Button();
			this.ResetBottom = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Massbody2 = new System.Windows.Forms.TextBox();
			this.Massbody1 = new System.Windows.Forms.TextBox();
			this.StartBottom = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сценаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Main_Height = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Main_Height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.TimerLabel);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.Disk_mass);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.PauseBottom);
			this.groupBox1.Controls.Add(this.ResetBottom);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Massbody2);
			this.groupBox1.Controls.Add(this.Massbody1);
			this.groupBox1.Controls.Add(this.StartBottom);
			this.groupBox1.Location = new System.Drawing.Point(731, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 331);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Земля - 9,8",
            "Меркурий - 3,72 ",
            "Венера - 8,87 ",
            "Марс - 3,69",
            "Юпитер - 20,87",
            "Сатурн - 7,21",
            "Уран - 8,43",
            "Нептун - 10,71",
            "Плутон - 0,81"});
			this.comboBox1.Location = new System.Drawing.Point(9, 151);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 16;
			this.comboBox1.Text = "Земля - 9,8";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 131);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(170, 13);
			this.label11.TabIndex = 15;
			this.label11.Text = " ускорение свободного падения";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(171, 246);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(16, 18);
			this.label10.TabIndex = 14;
			this.label10.Text = "0";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 301);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Высота установки(от 3 до 15 метров):\r\n";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(171, 221);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(16, 18);
			this.label9.TabIndex = 13;
			this.label9.Text = "0";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TimerLabel
			// 
			this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TimerLabel.AutoSize = true;
			this.TimerLabel.BackColor = System.Drawing.Color.White;
			this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TimerLabel.Location = new System.Drawing.Point(171, 267);
			this.TimerLabel.Name = "TimerLabel";
			this.TimerLabel.Size = new System.Drawing.Size(16, 18);
			this.TimerLabel.TabIndex = 7;
			this.TimerLabel.Text = "0";
			this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TimerLabel.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(11, 271);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Таймер:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(11, 246);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "Высота груза 2, м";
			// 
			// Disk_mass
			// 
			this.Disk_mass.Location = new System.Drawing.Point(171, 66);
			this.Disk_mass.Name = "Disk_mass";
			this.Disk_mass.Size = new System.Drawing.Size(100, 20);
			this.Disk_mass.TabIndex = 9;
			this.Disk_mass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Disk_mass_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(11, 221);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(122, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Высота груза 1, м";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(6, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Блок, кг";
			// 
			// PauseBottom
			// 
			this.PauseBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PauseBottom.Enabled = false;
			this.PauseBottom.Location = new System.Drawing.Point(97, 97);
			this.PauseBottom.Name = "PauseBottom";
			this.PauseBottom.Size = new System.Drawing.Size(85, 31);
			this.PauseBottom.TabIndex = 7;
			this.PauseBottom.Text = "Пауза";
			this.PauseBottom.UseVisualStyleBackColor = true;
			this.PauseBottom.Click += new System.EventHandler(this.PauseBottom_Click);
			// 
			// ResetBottom
			// 
			this.ResetBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResetBottom.Location = new System.Drawing.Point(9, 97);
			this.ResetBottom.Name = "ResetBottom";
			this.ResetBottom.Size = new System.Drawing.Size(75, 31);
			this.ResetBottom.TabIndex = 6;
			this.ResetBottom.Text = "Сброс";
			this.ResetBottom.UseVisualStyleBackColor = true;
			this.ResetBottom.Click += new System.EventHandler(this.ResetBottom_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(6, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Груз 2, кг";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(6, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Груз 1, кг";
			// 
			// Massbody2
			// 
			this.Massbody2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Massbody2.Location = new System.Drawing.Point(171, 38);
			this.Massbody2.MaxLength = 9;
			this.Massbody2.Name = "Massbody2";
			this.Massbody2.Size = new System.Drawing.Size(100, 20);
			this.Massbody2.TabIndex = 3;
			this.Massbody2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Massbody2_KeyPress);
			// 
			// Massbody1
			// 
			this.Massbody1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Massbody1.Location = new System.Drawing.Point(171, 9);
			this.Massbody1.MaxLength = 9;
			this.Massbody1.Name = "Massbody1";
			this.Massbody1.Size = new System.Drawing.Size(100, 20);
			this.Massbody1.TabIndex = 2;
			this.Massbody1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Massbody1_KeyPress);
			// 
			// StartBottom
			// 
			this.StartBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.StartBottom.Location = new System.Drawing.Point(193, 97);
			this.StartBottom.Name = "StartBottom";
			this.StartBottom.Size = new System.Drawing.Size(75, 31);
			this.StartBottom.TabIndex = 1;
			this.StartBottom.Text = "Пуск";
			this.StartBottom.UseVisualStyleBackColor = true;
			this.StartBottom.Click += new System.EventHandler(this.StartBottom_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.pictureBox1.Image = global::Атвуд.Properties.Resources.NSTU_Logo_darkred;
			this.pictureBox1.Location = new System.Drawing.Point(731, 457);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(289, 270);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// AnT
			// 
			this.AnT.AccumBits = ((byte)(0));
			this.AnT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AnT.AutoCheckErrors = false;
			this.AnT.AutoFinish = false;
			this.AnT.AutoMakeCurrent = true;
			this.AnT.AutoSize = true;
			this.AnT.AutoSwapBuffers = true;
			this.AnT.BackColor = System.Drawing.Color.Black;
			this.AnT.ColorBits = ((byte)(32));
			this.AnT.DepthBits = ((byte)(16));
			this.AnT.Location = new System.Drawing.Point(-8, 28);
			this.AnT.Name = "AnT";
			this.AnT.Size = new System.Drawing.Size(733, 699);
			this.AnT.StencilBits = ((byte)(0));
			this.AnT.TabIndex = 2;
			this.AnT.Load += new System.EventHandler(this.AnT_Load);
			this.AnT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseDown);
			this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
			this.AnT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseUp);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(1, 1);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикиToolStripMenuItem,
            this.сценаToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// графикиToolStripMenuItem
			// 
			this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vTToolStripMenuItem,
            this.eTToolStripMenuItem});
			this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
			this.графикиToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.графикиToolStripMenuItem.Text = "Графики";
			// 
			// vTToolStripMenuItem
			// 
			this.vTToolStripMenuItem.Name = "vTToolStripMenuItem";
			this.vTToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.vTToolStripMenuItem.Text = "V ( t )";
			this.vTToolStripMenuItem.Click += new System.EventHandler(this.vTToolStripMenuItem_Click);
			// 
			// eTToolStripMenuItem
			// 
			this.eTToolStripMenuItem.Name = "eTToolStripMenuItem";
			this.eTToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.eTToolStripMenuItem.Text = "E ( t )";
			this.eTToolStripMenuItem.Click += new System.EventHandler(this.eTToolStripMenuItem_Click);
			// 
			// сценаToolStripMenuItem
			// 
			this.сценаToolStripMenuItem.Name = "сценаToolStripMenuItem";
			this.сценаToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.сценаToolStripMenuItem.Text = "Сцена";
			this.сценаToolStripMenuItem.Click += new System.EventHandler(this.сценаToolStripMenuItem_Click);
			// 
			// помощьToolStripMenuItem
			// 
			this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
			this.помощьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.помощьToolStripMenuItem.Text = "Справка";
			// 
			// timer1
			// 
			this.timer1.Interval = 17;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// Main_Height
			// 
			this.Main_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Main_Height.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Main_Height.Location = new System.Drawing.Point(729, 366);
			this.Main_Height.Maximum = 150;
			this.Main_Height.Minimum = 30;
			this.Main_Height.Name = "Main_Height";
			this.Main_Height.Size = new System.Drawing.Size(262, 45);
			this.Main_Height.TabIndex = 4;
			this.Main_Height.Value = 80;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(730, 437);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Нынешняя высота: 8";
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(2, 29);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.LegendText = "Скорость груза 1";
			series1.Name = "Series1";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.LegendText = "Скорость груза 2";
			series2.Name = "Series4";
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(722, 697);
			this.chart1.TabIndex = 8;
			this.chart1.Text = "chart1";
			title1.Name = "Title1";
			title1.Text = "Зависимости скорости от времени";
			this.chart1.Titles.Add(title1);
			this.chart1.Visible = false;
			// 
			// chart2
			// 
			this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(3, 29);
			this.chart2.Name = "chart2";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series3.Legend = "Legend1";
			series3.LegendText = "Кинетическая энергия груза 1";
			series3.Name = "Series1";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series4.Legend = "Legend1";
			series4.LegendText = "Кинетическая энергия груза 2";
			series4.Name = "Series2";
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series5.Legend = "Legend1";
			series5.LegendText = "Потенциальная энергия груза 1";
			series5.Name = "Series3";
			series6.ChartArea = "ChartArea1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series6.Legend = "Legend1";
			series6.LegendText = "Потенциальная энергия груза 2";
			series6.Name = "Series4";
			this.chart2.Series.Add(series3);
			this.chart2.Series.Add(series4);
			this.chart2.Series.Add(series5);
			this.chart2.Series.Add(series6);
			this.chart2.Size = new System.Drawing.Size(720, 697);
			this.chart2.TabIndex = 9;
			this.chart2.Text = "chart2";
			title2.Name = "Title1";
			title2.Text = "Зависимость кинетической энергии от времени";
			this.chart2.Titles.Add(title2);
			this.chart2.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1021, 728);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Main_Height);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.AnT);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Виртуальная лаборатоная работа:  машина Атвуда";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Main_Height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Massbody2;
        private System.Windows.Forms.TextBox Massbody1;
        private System.Windows.Forms.Button StartBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ResetBottom;
        private System.Windows.Forms.TrackBar Main_Height;
        private System.Windows.Forms.Button PauseBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Disk_mass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TimerLabel;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сценаToolStripMenuItem;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Label label11;
	}
}

