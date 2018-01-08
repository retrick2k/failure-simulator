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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.симуляцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.начатьСимуляциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbMinFailureTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxFailureTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAverageFailureTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAverageRepairTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAvailabilityRate = new System.Windows.Forms.TextBox();
            this.tcGraphTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.tcGraphTab.Size = new System.Drawing.Size(769, 356);
            this.tcGraphTab.TabIndex = 0;
            // 
            // tpGraph
            // 
            this.tpGraph.Location = new System.Drawing.Point(4, 22);
            this.tpGraph.Name = "tpGraph";
            this.tpGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tpGraph.Size = new System.Drawing.Size(761, 330);
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
            this.tabPage2.Size = new System.Drawing.Size(761, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет по симуляции";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcGraphTab);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 375);
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
            this.сохранитьToolStripMenuItem});
            this.симуляцияToolStripMenuItem.Name = "симуляцияToolStripMenuItem";
            this.симуляцияToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.симуляцияToolStripMenuItem.Text = "Граф";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Лог";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(761, 199);
            this.listBox1.TabIndex = 0;
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
            // сохранитьОтчетToolStripMenuItem
            // 
            this.сохранитьОтчетToolStripMenuItem.Name = "сохранитьОтчетToolStripMenuItem";
            this.сохранитьОтчетToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.сохранитьОтчетToolStripMenuItem.Text = "Сохранить отчет";
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
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
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 318);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список путей";
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
            // tbMinFailureTime
            // 
            this.tbMinFailureTime.Location = new System.Drawing.Point(318, 19);
            this.tbMinFailureTime.Name = "tbMinFailureTime";
            this.tbMinFailureTime.Size = new System.Drawing.Size(133, 20);
            this.tbMinFailureTime.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Симулятор отказов";
            this.tcGraphTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
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
    }
}

