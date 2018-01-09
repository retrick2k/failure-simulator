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
            this.tcGraphTab = new System.Windows.Forms.TabControl();
            this.tpGraph = new System.Windows.Forms.TabPage();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.симуляцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьСимуляциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphHost = new System.Windows.Forms.Integration.ElementHost();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.тестовыеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестШинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смешанныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbStartVertex = new System.Windows.Forms.TextBox();
            this.tbFinishVertex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbSelectStartVertex = new System.Windows.Forms.RadioButton();
            this.rbSelectFinishVertex = new System.Windows.Forms.RadioButton();
            this.gbVertexChoosingMode = new System.Windows.Forms.GroupBox();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbVertexNameCh = new System.Windows.Forms.TextBox();
            this.tbVertexFailIntensity = new System.Windows.Forms.TextBox();
            this.tbEdgeFailIntensity = new System.Windows.Forms.TextBox();
            this.cbVertexChoosingMode = new System.Windows.Forms.CheckBox();
            this.tcGraphTab.SuspendLayout();
            this.tpGraph.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbVertexChoosingMode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcGraphTab
            // 
            this.tcGraphTab.Controls.Add(this.tpGraph);
            this.tcGraphTab.Controls.Add(this.tabPage2);
            this.tcGraphTab.Controls.Add(this.tabPage1);
            this.tcGraphTab.Controls.Add(this.tabPage3);
            this.tcGraphTab.Controls.Add(this.tabPage4);
            this.tcGraphTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcGraphTab.Location = new System.Drawing.Point(3, 16);
            this.tcGraphTab.Name = "tcGraphTab";
            this.tcGraphTab.SelectedIndex = 0;
            this.tcGraphTab.Size = new System.Drawing.Size(769, 417);
            this.tcGraphTab.TabIndex = 0;
            // 
            // tpGraph
            // 
            this.tpGraph.Controls.Add(this.groupBox2);
            this.tpGraph.Controls.Add(this.groupBox6);
            this.tpGraph.Controls.Add(this.groupBox5);
            this.tpGraph.Location = new System.Drawing.Point(4, 22);
            this.tpGraph.Name = "tpGraph";
            this.tpGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tpGraph.Size = new System.Drawing.Size(761, 391);
            this.tpGraph.TabIndex = 0;
            this.tpGraph.Text = "Граф системы";
            this.tpGraph.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет по симуляции";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
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
            this.groupBox4.Location = new System.Drawing.Point(298, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 318);
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
            this.tbAvailabilityRate.Location = new System.Drawing.Point(318, 164);
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
            this.tbAverageRepairTime.Location = new System.Drawing.Point(318, 127);
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
            this.tbAverageFailureTime.Location = new System.Drawing.Point(318, 91);
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
            this.tbMaxFailureTime.Location = new System.Drawing.Point(318, 56);
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
            this.tbMinFailureTime.Location = new System.Drawing.Point(318, 19);
            this.tbMinFailureTime.Name = "tbMinFailureTime";
            this.tbMinFailureTime.Size = new System.Drawing.Size(133, 20);
            this.tbMinFailureTime.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPaths);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 318);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список путей";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 330);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Диаграмма восстановления";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 330);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Гистограмма восстановления";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(761, 330);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Гистограмма отказов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcGraphTab);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.симуляцияToolStripMenuItem,
            this.начатьСимуляциюToolStripMenuItem,
            this.сохранитьОтчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // симуляцияToolStripMenuItem
            // 
            this.симуляцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.тестовыеДанныеToolStripMenuItem});
            this.симуляцияToolStripMenuItem.Name = "симуляцияToolStripMenuItem";
            this.симуляцияToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.симуляцияToolStripMenuItem.Text = "Граф";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // начатьСимуляциюToolStripMenuItem
            // 
            this.начатьСимуляциюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.начатьСимуляциюToolStripMenuItem.Name = "начатьСимуляциюToolStripMenuItem";
            this.начатьСимуляциюToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.начатьСимуляциюToolStripMenuItem.Text = "Симуляция";
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // сохранитьОтчетToolStripMenuItem
            // 
            this.сохранитьОтчетToolStripMenuItem.Name = "сохранитьОтчетToolStripMenuItem";
            this.сохранитьОтчетToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.сохранитьОтчетToolStripMenuItem.Text = "Сохранить отчет";
            this.сохранитьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОтчетToolStripMenuItem_Click);
            // 
            // graphHost
            // 
            this.graphHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphHost.Location = new System.Drawing.Point(3, 16);
            this.graphHost.Name = "graphHost";
            this.graphHost.Size = new System.Drawing.Size(394, 360);
            this.graphHost.TabIndex = 0;
            this.graphHost.Text = "elementHost1";
            this.graphHost.Move += new System.EventHandler(this.graphHost_Move);
            this.graphHost.Child = null;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.graphHost);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 379);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Топология системы";
            // 
            // тестовыеДанныеToolStripMenuItem
            // 
            this.тестовыеДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестШинаToolStripMenuItem,
            this.шинаToolStripMenuItem,
            this.смешанныйToolStripMenuItem});
            this.тестовыеДанныеToolStripMenuItem.Name = "тестовыеДанныеToolStripMenuItem";
            this.тестовыеДанныеToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.тестовыеДанныеToolStripMenuItem.Text = "Создать готовый";
            // 
            // тестШинаToolStripMenuItem
            // 
            this.тестШинаToolStripMenuItem.Name = "тестШинаToolStripMenuItem";
            this.тестШинаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.тестШинаToolStripMenuItem.Text = "Звезда";
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
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbVertexChoosingMode);
            this.groupBox6.Controls.Add(this.gbVertexChoosingMode);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.tbFinishVertex);
            this.groupBox6.Controls.Add(this.tbStartVertex);
            this.groupBox6.Location = new System.Drawing.Point(412, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(343, 157);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Работа с графом";
            // 
            // tbStartVertex
            // 
            this.tbStartVertex.Location = new System.Drawing.Point(153, 20);
            this.tbStartVertex.Name = "tbStartVertex";
            this.tbStartVertex.Size = new System.Drawing.Size(184, 20);
            this.tbStartVertex.TabIndex = 2;
            // 
            // tbFinishVertex
            // 
            this.tbFinishVertex.Location = new System.Drawing.Point(153, 50);
            this.tbFinishVertex.Name = "tbFinishVertex";
            this.tbFinishVertex.Size = new System.Drawing.Size(184, 20);
            this.tbFinishVertex.TabIndex = 3;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Конечная вершина";
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
            // gbVertexChoosingMode
            // 
            this.gbVertexChoosingMode.Controls.Add(this.rbSelectFinishVertex);
            this.gbVertexChoosingMode.Controls.Add(this.rbSelectStartVertex);
            this.gbVertexChoosingMode.Enabled = false;
            this.gbVertexChoosingMode.Location = new System.Drawing.Point(167, 76);
            this.gbVertexChoosingMode.Name = "gbVertexChoosingMode";
            this.gbVertexChoosingMode.Size = new System.Drawing.Size(170, 69);
            this.gbVertexChoosingMode.TabIndex = 8;
            this.gbVertexChoosingMode.TabStop = false;
            // 
            // lbPaths
            // 
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.Location = new System.Drawing.Point(6, 19);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(274, 290);
            this.lbPaths.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Location = new System.Drawing.Point(412, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики элементов системы";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbVertexFailIntensity);
            this.groupBox8.Controls.Add(this.tbVertexNameCh);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(325, 88);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Узел";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbEdgeFailIntensity);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Location = new System.Drawing.Point(6, 113);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(325, 94);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Связь";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Интенсивность отказов узла";
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
            // tbVertexNameCh
            // 
            this.tbVertexNameCh.Location = new System.Drawing.Point(188, 22);
            this.tbVertexNameCh.Name = "tbVertexNameCh";
            this.tbVertexNameCh.Size = new System.Drawing.Size(131, 20);
            this.tbVertexNameCh.TabIndex = 2;
            // 
            // tbVertexFailIntensity
            // 
            this.tbVertexFailIntensity.Location = new System.Drawing.Point(188, 57);
            this.tbVertexFailIntensity.Name = "tbVertexFailIntensity";
            this.tbVertexFailIntensity.Size = new System.Drawing.Size(131, 20);
            this.tbVertexFailIntensity.TabIndex = 3;
            // 
            // tbEdgeFailIntensity
            // 
            this.tbEdgeFailIntensity.Location = new System.Drawing.Point(188, 13);
            this.tbEdgeFailIntensity.Name = "tbEdgeFailIntensity";
            this.tbEdgeFailIntensity.Size = new System.Drawing.Size(131, 20);
            this.tbEdgeFailIntensity.TabIndex = 4;
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
            this.cbVertexChoosingMode.CheckedChanged += new System.EventHandler(this.cbVertexChoosingMode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Симулятор отказов";
            this.tcGraphTab.ResumeLayout(false);
            this.tpGraph.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbVertexChoosingMode.ResumeLayout(false);
            this.gbVertexChoosingMode.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcGraphTab;
        private System.Windows.Forms.TabPage tpGraph;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem симуляцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьСимуляциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОтчетToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Integration.ElementHost graphHost;
        private System.Windows.Forms.ToolStripMenuItem тестовыеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестШинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem смешанныйToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbFinishVertex;
        private System.Windows.Forms.TextBox tbStartVertex;
        private System.Windows.Forms.GroupBox gbVertexChoosingMode;
        private System.Windows.Forms.RadioButton rbSelectFinishVertex;
        private System.Windows.Forms.RadioButton rbSelectStartVertex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEdgeFailIntensity;
        private System.Windows.Forms.TextBox tbVertexFailIntensity;
        private System.Windows.Forms.TextBox tbVertexNameCh;
        private System.Windows.Forms.CheckBox cbVertexChoosingMode;
    }
}

