namespace FailureSimulator.GUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.симуляцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестШинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смешанныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьСимуляциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ненадежныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcGraphTab = new System.Windows.Forms.TabControl();
            this.tpGraph = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbEdgeFailIntensity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbVertexFailIntensity = new System.Windows.Forms.TextBox();
            this.tbVertexNameCh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbVertexChoosingMode = new System.Windows.Forms.CheckBox();
            this.gbVertexChoosingMode = new System.Windows.Forms.GroupBox();
            this.rbSelectFinishVertex = new System.Windows.Forms.RadioButton();
            this.rbSelectStartVertex = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFinishVertex = new System.Windows.Forms.TextBox();
            this.tbStartVertex = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.graphHost = new System.Windows.Forms.Integration.ElementHost();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAvailabilityRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAverageRepairTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAverageFailureTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxFailureTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMinFailureTime = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zcTimeDiagram = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.zcRepairBarChart = new ZedGraph.ZedGraphControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.zcFailureBarChart = new ZedGraph.ZedGraphControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnUseDefaultSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.cbRepair = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.rbFifoRepairQueueFactory = new System.Windows.Forms.RadioButton();
            this.rbFastFirstReqairQueueFactory = new System.Windows.Forms.RadioButton();
            this.rbImportantFirstRepairQueueFactory = new System.Windows.Forms.RadioButton();
            this.rbLifoRepairQueueFactory = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nudRepairIntensity = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nudRepairTeamsCount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudBarChartCount = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudMaxTime = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudNumRuns = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.надежныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кольцоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tcGraphTab.SuspendLayout();
            this.tpGraph.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbVertexChoosingMode.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepairIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepairTeamsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBarChartCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRuns)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.симуляцияToolStripMenuItem,
            this.начатьСимуляциюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // симуляцияToolStripMenuItem
            // 
            this.симуляцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестовыеДанныеToolStripMenuItem});
            this.симуляцияToolStripMenuItem.Name = "симуляцияToolStripMenuItem";
            this.симуляцияToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.симуляцияToolStripMenuItem.Text = "Граф";
            // 
            // тестовыеДанныеToolStripMenuItem
            // 
            this.тестовыеДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестШинаToolStripMenuItem,
            this.шинаToolStripMenuItem,
            this.смешанныйToolStripMenuItem,
            this.ненадежныйToolStripMenuItem,
            this.надежныйToolStripMenuItem,
            this.кольцоToolStripMenuItem});
            this.тестовыеДанныеToolStripMenuItem.Name = "тестовыеДанныеToolStripMenuItem";
            this.тестовыеДанныеToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.тестовыеДанныеToolStripMenuItem.Text = "Создать готовый";
            // 
            // тестШинаToolStripMenuItem
            // 
            this.тестШинаToolStripMenuItem.Name = "тестШинаToolStripMenuItem";
            this.тестШинаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.тестШинаToolStripMenuItem.Text = "Звезда";
            this.тестШинаToolStripMenuItem.Click += new System.EventHandler(this.тестШинаToolStripMenuItem_Click);
            // 
            // шинаToolStripMenuItem
            // 
            this.шинаToolStripMenuItem.Name = "шинаToolStripMenuItem";
            this.шинаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.шинаToolStripMenuItem.Text = "Шина";
            this.шинаToolStripMenuItem.Click += new System.EventHandler(this.шинаToolStripMenuItem_Click);
            // 
            // смешанныйToolStripMenuItem
            // 
            this.смешанныйToolStripMenuItem.Name = "смешанныйToolStripMenuItem";
            this.смешанныйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.смешанныйToolStripMenuItem.Text = "Смешанный";
            this.смешанныйToolStripMenuItem.Click += new System.EventHandler(this.смешанныйToolStripMenuItem_Click);
            // 
            // начатьСимуляциюToolStripMenuItem
            // 
            this.начатьСимуляциюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem});
            this.начатьСимуляциюToolStripMenuItem.Name = "начатьСимуляциюToolStripMenuItem";
            this.начатьСимуляциюToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.начатьСимуляциюToolStripMenuItem.Text = "Симуляция";
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // ненадежныйToolStripMenuItem
            // 
            this.ненадежныйToolStripMenuItem.Name = "ненадежныйToolStripMenuItem";
            this.ненадежныйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ненадежныйToolStripMenuItem.Text = "Ненадежный";
            this.ненадежныйToolStripMenuItem.Click += new System.EventHandler(this.ненадежныйToolStripMenuItem_Click);
            // 
            // tcGraphTab
            // 
            this.tcGraphTab.Controls.Add(this.tpGraph);
            this.tcGraphTab.Controls.Add(this.tabPage2);
            this.tcGraphTab.Controls.Add(this.tabPage1);
            this.tcGraphTab.Controls.Add(this.tabPage3);
            this.tcGraphTab.Controls.Add(this.tabPage4);
            this.tcGraphTab.Controls.Add(this.tabPage5);
            this.tcGraphTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcGraphTab.Location = new System.Drawing.Point(0, 24);
            this.tcGraphTab.Name = "tcGraphTab";
            this.tcGraphTab.SelectedIndex = 0;
            this.tcGraphTab.Size = new System.Drawing.Size(769, 402);
            this.tcGraphTab.TabIndex = 3;
            // 
            // tpGraph
            // 
            this.tpGraph.Controls.Add(this.groupBox2);
            this.tpGraph.Controls.Add(this.groupBox6);
            this.tpGraph.Controls.Add(this.groupBox5);
            this.tpGraph.Location = new System.Drawing.Point(4, 22);
            this.tpGraph.Name = "tpGraph";
            this.tpGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tpGraph.Size = new System.Drawing.Size(761, 376);
            this.tpGraph.TabIndex = 0;
            this.tpGraph.Text = "Граф системы";
            this.tpGraph.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Location = new System.Drawing.Point(407, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 196);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики элементов системы";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.tbEdgeFailIntensity);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Location = new System.Drawing.Point(6, 113);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(331, 77);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Связь";
            // 
            // tbEdgeFailIntensity
            // 
            this.tbEdgeFailIntensity.Location = new System.Drawing.Point(194, 13);
            this.tbEdgeFailIntensity.Name = "tbEdgeFailIntensity";
            this.tbEdgeFailIntensity.Size = new System.Drawing.Size(131, 20);
            this.tbEdgeFailIntensity.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Интенсивность отказов связи";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbVertexFailIntensity);
            this.groupBox8.Controls.Add(this.tbVertexNameCh);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(331, 88);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Узел";
            // 
            // tbVertexFailIntensity
            // 
            this.tbVertexFailIntensity.Location = new System.Drawing.Point(193, 57);
            this.tbVertexFailIntensity.Name = "tbVertexFailIntensity";
            this.tbVertexFailIntensity.Size = new System.Drawing.Size(131, 20);
            this.tbVertexFailIntensity.TabIndex = 3;
            // 
            // tbVertexNameCh
            // 
            this.tbVertexNameCh.Location = new System.Drawing.Point(193, 22);
            this.tbVertexNameCh.Name = "tbVertexNameCh";
            this.tbVertexNameCh.Size = new System.Drawing.Size(131, 20);
            this.tbVertexNameCh.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Интенсивность отказов узла";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Название узла";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.cbVertexChoosingMode);
            this.groupBox6.Controls.Add(this.gbVertexChoosingMode);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.tbFinishVertex);
            this.groupBox6.Controls.Add(this.tbStartVertex);
            this.groupBox6.Location = new System.Drawing.Point(407, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(343, 157);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Работа с графом";
            // 
            // cbVertexChoosingMode
            // 
            this.cbVertexChoosingMode.AutoSize = true;
            this.cbVertexChoosingMode.Location = new System.Drawing.Point(10, 85);
            this.cbVertexChoosingMode.Name = "cbVertexChoosingMode";
            this.cbVertexChoosingMode.Size = new System.Drawing.Size(151, 17);
            this.cbVertexChoosingMode.TabIndex = 8;
            this.cbVertexChoosingMode.Text = "Режим выбора вершины";
            this.cbVertexChoosingMode.UseVisualStyleBackColor = true;
            this.cbVertexChoosingMode.CheckedChanged += new System.EventHandler(this.cbVertexChoosingMode_CheckedChanged_1);
            // 
            // gbVertexChoosingMode
            // 
            this.gbVertexChoosingMode.Controls.Add(this.rbSelectFinishVertex);
            this.gbVertexChoosingMode.Controls.Add(this.rbSelectStartVertex);
            this.gbVertexChoosingMode.Location = new System.Drawing.Point(167, 76);
            this.gbVertexChoosingMode.Name = "gbVertexChoosingMode";
            this.gbVertexChoosingMode.Size = new System.Drawing.Size(170, 69);
            this.gbVertexChoosingMode.TabIndex = 8;
            this.gbVertexChoosingMode.TabStop = false;
            // 
            // rbSelectFinishVertex
            // 
            this.rbSelectFinishVertex.AutoSize = true;
            this.rbSelectFinishVertex.Location = new System.Drawing.Point(6, 42);
            this.rbSelectFinishVertex.Name = "rbSelectFinishVertex";
            this.rbSelectFinishVertex.Size = new System.Drawing.Size(157, 17);
            this.rbSelectFinishVertex.TabIndex = 7;
            this.rbSelectFinishVertex.Text = "Выбор конечной вершины";
            this.rbSelectFinishVertex.UseVisualStyleBackColor = true;
            // 
            // rbSelectStartVertex
            // 
            this.rbSelectStartVertex.AutoSize = true;
            this.rbSelectStartVertex.Checked = true;
            this.rbSelectStartVertex.Location = new System.Drawing.Point(6, 19);
            this.rbSelectStartVertex.Name = "rbSelectStartVertex";
            this.rbSelectStartVertex.Size = new System.Drawing.Size(163, 17);
            this.rbSelectStartVertex.TabIndex = 6;
            this.rbSelectStartVertex.TabStop = true;
            this.rbSelectStartVertex.Text = "Выбор начальной вершины";
            this.rbSelectStartVertex.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Конечная вершина";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Начальная вершина";
            // 
            // tbFinishVertex
            // 
            this.tbFinishVertex.Location = new System.Drawing.Point(153, 50);
            this.tbFinishVertex.Name = "tbFinishVertex";
            this.tbFinishVertex.Size = new System.Drawing.Size(184, 20);
            this.tbFinishVertex.TabIndex = 3;
            // 
            // tbStartVertex
            // 
            this.tbStartVertex.Location = new System.Drawing.Point(153, 20);
            this.tbStartVertex.Name = "tbStartVertex";
            this.tbStartVertex.Size = new System.Drawing.Size(184, 20);
            this.tbStartVertex.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.graphHost);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 362);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Топология системы";
            // 
            // graphHost
            // 
            this.graphHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphHost.Location = new System.Drawing.Point(3, 16);
            this.graphHost.Name = "graphHost";
            this.graphHost.Size = new System.Drawing.Size(389, 343);
            this.graphHost.TabIndex = 0;
            this.graphHost.Text = "elementHost1";
            this.graphHost.Child = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет по симуляции";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbAvailabilityRate);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbAverageRepairTime);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbAverageFailureTime);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbMaxFailureTime);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbMinFailureTime);
            this.groupBox4.Location = new System.Drawing.Point(301, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 361);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Замеры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Коэффициент готовности";
            // 
            // tbAvailabilityRate
            // 
            this.tbAvailabilityRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAvailabilityRate.Location = new System.Drawing.Point(297, 163);
            this.tbAvailabilityRate.Name = "tbAvailabilityRate";
            this.tbAvailabilityRate.Size = new System.Drawing.Size(133, 20);
            this.tbAvailabilityRate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Среднее время восстановления системы";
            // 
            // tbAverageRepairTime
            // 
            this.tbAverageRepairTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAverageRepairTime.Location = new System.Drawing.Point(297, 126);
            this.tbAverageRepairTime.Name = "tbAverageRepairTime";
            this.tbAverageRepairTime.Size = new System.Drawing.Size(133, 20);
            this.tbAverageRepairTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Среднее время работы до отказа системы";
            // 
            // tbAverageFailureTime
            // 
            this.tbAverageFailureTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAverageFailureTime.Location = new System.Drawing.Point(297, 90);
            this.tbAverageFailureTime.Name = "tbAverageFailureTime";
            this.tbAverageFailureTime.Size = new System.Drawing.Size(133, 20);
            this.tbAverageFailureTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Максимальное время работы до отказа системы";
            // 
            // tbMaxFailureTime
            // 
            this.tbMaxFailureTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxFailureTime.Location = new System.Drawing.Point(297, 55);
            this.tbMaxFailureTime.Name = "tbMaxFailureTime";
            this.tbMaxFailureTime.Size = new System.Drawing.Size(133, 20);
            this.tbMaxFailureTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Минимальное время работы до отказа системы";
            // 
            // tbMinFailureTime
            // 
            this.tbMinFailureTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinFailureTime.Location = new System.Drawing.Point(297, 18);
            this.tbMinFailureTime.Name = "tbMinFailureTime";
            this.tbMinFailureTime.Size = new System.Drawing.Size(133, 20);
            this.tbMinFailureTime.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.lbPaths);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 364);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список путей";
            // 
            // lbPaths
            // 
            this.lbPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.Location = new System.Drawing.Point(3, 16);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(280, 345);
            this.lbPaths.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zcTimeDiagram);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 469);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Диаграмма восстановления";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // zcTimeDiagram
            // 
            this.zcTimeDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zcTimeDiagram.Location = new System.Drawing.Point(3, 3);
            this.zcTimeDiagram.Name = "zcTimeDiagram";
            this.zcTimeDiagram.ScrollGrace = 0D;
            this.zcTimeDiagram.ScrollMaxX = 0D;
            this.zcTimeDiagram.ScrollMaxY = 0D;
            this.zcTimeDiagram.ScrollMaxY2 = 0D;
            this.zcTimeDiagram.ScrollMinX = 0D;
            this.zcTimeDiagram.ScrollMinY = 0D;
            this.zcTimeDiagram.ScrollMinY2 = 0D;
            this.zcTimeDiagram.Size = new System.Drawing.Size(832, 463);
            this.zcTimeDiagram.TabIndex = 0;
            this.zcTimeDiagram.UseExtendedPrintDialog = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.zcRepairBarChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 391);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Гистограмма восстановления";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // zcRepairBarChart
            // 
            this.zcRepairBarChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zcRepairBarChart.Location = new System.Drawing.Point(3, 3);
            this.zcRepairBarChart.Name = "zcRepairBarChart";
            this.zcRepairBarChart.ScrollGrace = 0D;
            this.zcRepairBarChart.ScrollMaxX = 0D;
            this.zcRepairBarChart.ScrollMaxY = 0D;
            this.zcRepairBarChart.ScrollMaxY2 = 0D;
            this.zcRepairBarChart.ScrollMinX = 0D;
            this.zcRepairBarChart.ScrollMinY = 0D;
            this.zcRepairBarChart.ScrollMinY2 = 0D;
            this.zcRepairBarChart.Size = new System.Drawing.Size(755, 385);
            this.zcRepairBarChart.TabIndex = 1;
            this.zcRepairBarChart.UseExtendedPrintDialog = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.zcFailureBarChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(761, 391);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Гистограмма отказов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // zcFailureBarChart
            // 
            this.zcFailureBarChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zcFailureBarChart.Location = new System.Drawing.Point(3, 3);
            this.zcFailureBarChart.Name = "zcFailureBarChart";
            this.zcFailureBarChart.ScrollGrace = 0D;
            this.zcFailureBarChart.ScrollMaxX = 0D;
            this.zcFailureBarChart.ScrollMaxY = 0D;
            this.zcFailureBarChart.ScrollMaxY2 = 0D;
            this.zcFailureBarChart.ScrollMinX = 0D;
            this.zcFailureBarChart.ScrollMinY = 0D;
            this.zcFailureBarChart.ScrollMinY2 = 0D;
            this.zcFailureBarChart.Size = new System.Drawing.Size(755, 385);
            this.zcFailureBarChart.TabIndex = 0;
            this.zcFailureBarChart.UseExtendedPrintDialog = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Controls.Add(this.groupBox7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(761, 376);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Настройки";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.btnUseDefaultSettings);
            this.groupBox10.Controls.Add(this.btnSaveSettings);
            this.groupBox10.Controls.Add(this.cbRepair);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Location = new System.Drawing.Point(346, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(407, 366);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            // 
            // btnUseDefaultSettings
            // 
            this.btnUseDefaultSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUseDefaultSettings.Location = new System.Drawing.Point(87, 335);
            this.btnUseDefaultSettings.Name = "btnUseDefaultSettings";
            this.btnUseDefaultSettings.Size = new System.Drawing.Size(100, 25);
            this.btnUseDefaultSettings.TabIndex = 5;
            this.btnUseDefaultSettings.Text = "По умолчанию";
            this.btnUseDefaultSettings.UseVisualStyleBackColor = true;
            this.btnUseDefaultSettings.Click += new System.EventHandler(this.btnUseDefaultSettings_Click_1);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSettings.Location = new System.Drawing.Point(6, 335);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 25);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click_1);
            // 
            // cbRepair
            // 
            this.cbRepair.AutoSize = true;
            this.cbRepair.Location = new System.Drawing.Point(6, 136);
            this.cbRepair.Name = "cbRepair";
            this.cbRepair.Size = new System.Drawing.Size(151, 17);
            this.cbRepair.TabIndex = 3;
            this.cbRepair.Text = "Есть ли восстановление";
            this.cbRepair.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.rbFifoRepairQueueFactory);
            this.groupBox11.Controls.Add(this.rbFastFirstReqairQueueFactory);
            this.groupBox11.Controls.Add(this.rbImportantFirstRepairQueueFactory);
            this.groupBox11.Controls.Add(this.rbLifoRepairQueueFactory);
            this.groupBox11.Location = new System.Drawing.Point(6, 9);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(394, 116);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Политики восстановления";
            // 
            // rbFifoRepairQueueFactory
            // 
            this.rbFifoRepairQueueFactory.AutoSize = true;
            this.rbFifoRepairQueueFactory.Location = new System.Drawing.Point(6, 88);
            this.rbFifoRepairQueueFactory.Name = "rbFifoRepairQueueFactory";
            this.rbFifoRepairQueueFactory.Size = new System.Drawing.Size(48, 17);
            this.rbFifoRepairQueueFactory.TabIndex = 3;
            this.rbFifoRepairQueueFactory.TabStop = true;
            this.rbFifoRepairQueueFactory.Text = "FIFO";
            this.rbFifoRepairQueueFactory.UseVisualStyleBackColor = true;
            // 
            // rbFastFirstReqairQueueFactory
            // 
            this.rbFastFirstReqairQueueFactory.AutoSize = true;
            this.rbFastFirstReqairQueueFactory.Location = new System.Drawing.Point(6, 65);
            this.rbFastFirstReqairQueueFactory.Name = "rbFastFirstReqairQueueFactory";
            this.rbFastFirstReqairQueueFactory.Size = new System.Drawing.Size(175, 17);
            this.rbFastFirstReqairQueueFactory.TabIndex = 2;
            this.rbFastFirstReqairQueueFactory.TabStop = true;
            this.rbFastFirstReqairQueueFactory.Text = "По скорости восстановления";
            this.rbFastFirstReqairQueueFactory.UseVisualStyleBackColor = true;
            // 
            // rbImportantFirstRepairQueueFactory
            // 
            this.rbImportantFirstRepairQueueFactory.AutoSize = true;
            this.rbImportantFirstRepairQueueFactory.Location = new System.Drawing.Point(6, 42);
            this.rbImportantFirstRepairQueueFactory.Name = "rbImportantFirstRepairQueueFactory";
            this.rbImportantFirstRepairQueueFactory.Size = new System.Drawing.Size(99, 17);
            this.rbImportantFirstRepairQueueFactory.TabIndex = 1;
            this.rbImportantFirstRepairQueueFactory.TabStop = true;
            this.rbImportantFirstRepairQueueFactory.Text = "По приоритету";
            this.rbImportantFirstRepairQueueFactory.UseVisualStyleBackColor = true;
            // 
            // rbLifoRepairQueueFactory
            // 
            this.rbLifoRepairQueueFactory.AutoSize = true;
            this.rbLifoRepairQueueFactory.Location = new System.Drawing.Point(6, 19);
            this.rbLifoRepairQueueFactory.Name = "rbLifoRepairQueueFactory";
            this.rbLifoRepairQueueFactory.Size = new System.Drawing.Size(48, 17);
            this.rbLifoRepairQueueFactory.TabIndex = 0;
            this.rbLifoRepairQueueFactory.TabStop = true;
            this.rbLifoRepairQueueFactory.Text = "LIFO";
            this.rbLifoRepairQueueFactory.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.nudRepairIntensity);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.nudRepairTeamsCount);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.nudBarChartCount);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.nudMaxTime);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.nudNumRuns);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(334, 206);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // nudRepairIntensity
            // 
            this.nudRepairIntensity.DecimalPlaces = 3;
            this.nudRepairIntensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRepairIntensity.Location = new System.Drawing.Point(214, 171);
            this.nudRepairIntensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRepairIntensity.Name = "nudRepairIntensity";
            this.nudRepairIntensity.Size = new System.Drawing.Size(114, 20);
            this.nudRepairIntensity.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Интенсивность восстановления";
            // 
            // nudRepairTeamsCount
            // 
            this.nudRepairTeamsCount.Location = new System.Drawing.Point(214, 133);
            this.nudRepairTeamsCount.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudRepairTeamsCount.Name = "nudRepairTeamsCount";
            this.nudRepairTeamsCount.Size = new System.Drawing.Size(114, 20);
            this.nudRepairTeamsCount.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Число ремонтных бригад";
            // 
            // nudBarChartCount
            // 
            this.nudBarChartCount.Location = new System.Drawing.Point(214, 95);
            this.nudBarChartCount.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudBarChartCount.Name = "nudBarChartCount";
            this.nudBarChartCount.Size = new System.Drawing.Size(114, 20);
            this.nudBarChartCount.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Количество столбцов в гистограммах";
            // 
            // nudMaxTime
            // 
            this.nudMaxTime.Location = new System.Drawing.Point(214, 57);
            this.nudMaxTime.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudMaxTime.Name = "nudMaxTime";
            this.nudMaxTime.Size = new System.Drawing.Size(114, 20);
            this.nudMaxTime.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Максимальное время одной итерации";
            // 
            // nudNumRuns
            // 
            this.nudNumRuns.Location = new System.Drawing.Point(214, 18);
            this.nudNumRuns.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudNumRuns.Name = "nudNumRuns";
            this.nudNumRuns.Size = new System.Drawing.Size(114, 20);
            this.nudNumRuns.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Количество запусков моделирования";
            // 
            // надежныйToolStripMenuItem
            // 
            this.надежныйToolStripMenuItem.Name = "надежныйToolStripMenuItem";
            this.надежныйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.надежныйToolStripMenuItem.Text = "Надежный";
            this.надежныйToolStripMenuItem.Click += new System.EventHandler(this.надежныйToolStripMenuItem_Click);
            // 
            // кольцоToolStripMenuItem
            // 
            this.кольцоToolStripMenuItem.Name = "кольцоToolStripMenuItem";
            this.кольцоToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.кольцоToolStripMenuItem.Text = "Кольцо";
            this.кольцоToolStripMenuItem.Click += new System.EventHandler(this.кольцоToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 426);
            this.Controls.Add(this.tcGraphTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(785, 465);
            this.Name = "Form1";
            this.Text = "Симулятор отказов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcGraphTab.ResumeLayout(false);
            this.tpGraph.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbVertexChoosingMode.ResumeLayout(false);
            this.gbVertexChoosingMode.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepairIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepairTeamsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBarChartCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRuns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem симуляцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьСимуляциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестШинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem смешанныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ненадежныйToolStripMenuItem;
        private System.Windows.Forms.TabControl tcGraphTab;
        private System.Windows.Forms.TabPage tpGraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbEdgeFailIntensity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbVertexFailIntensity;
        private System.Windows.Forms.TextBox tbVertexNameCh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbVertexChoosingMode;
        private System.Windows.Forms.GroupBox gbVertexChoosingMode;
        private System.Windows.Forms.RadioButton rbSelectFinishVertex;
        private System.Windows.Forms.RadioButton rbSelectStartVertex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFinishVertex;
        private System.Windows.Forms.TextBox tbStartVertex;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Integration.ElementHost graphHost;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAvailabilityRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAverageRepairTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAverageFailureTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaxFailureTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMinFailureTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.TabPage tabPage1;
        private ZedGraph.ZedGraphControl zcTimeDiagram;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl zcRepairBarChart;
        private System.Windows.Forms.TabPage tabPage4;
        private ZedGraph.ZedGraphControl zcFailureBarChart;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnUseDefaultSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.CheckBox cbRepair;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.RadioButton rbFifoRepairQueueFactory;
        private System.Windows.Forms.RadioButton rbFastFirstReqairQueueFactory;
        private System.Windows.Forms.RadioButton rbImportantFirstRepairQueueFactory;
        private System.Windows.Forms.RadioButton rbLifoRepairQueueFactory;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown nudRepairIntensity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudRepairTeamsCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudBarChartCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudMaxTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudNumRuns;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem надежныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кольцоToolStripMenuItem;
    }
}

