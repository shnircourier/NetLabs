
namespace WinFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.gbCalculate = new System.Windows.Forms.GroupBox();
            this.rbSecond = new System.Windows.Forms.RadioButton();
            this.rbMinute = new System.Windows.Forms.RadioButton();
            this.rbHour = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.gbInputDate = new System.Windows.Forms.GroupBox();
            this.secondFIO = new System.Windows.Forms.TextBox();
            this.firstFIO = new System.Windows.Forms.TextBox();
            this.secondFIODate = new System.Windows.Forms.MaskedTextBox();
            this.cbExtendForm = new System.Windows.Forms.CheckBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDate = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResult = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCalculate = new System.Windows.Forms.ToolStripButton();
            this.tsbClearDate = new System.Windows.Forms.ToolStripButton();
            this.tsbClearResult = new System.Windows.Forms.ToolStripButton();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbCalculate.SuspendLayout();
            this.gbInputDate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.gbResult);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.gbCalculate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.gbInputDate);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1104, 487);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1104, 542);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.listBox);
            this.gbResult.Location = new System.Drawing.Point(260, 3);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(841, 483);
            this.gbResult.TabIndex = 2;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(7, 27);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(828, 444);
            this.listBox.TabIndex = 0;
            // 
            // gbCalculate
            // 
            this.gbCalculate.Controls.Add(this.rbSecond);
            this.gbCalculate.Controls.Add(this.rbMinute);
            this.gbCalculate.Controls.Add(this.rbHour);
            this.gbCalculate.Controls.Add(this.rbDay);
            this.gbCalculate.Controls.Add(this.rbMonth);
            this.gbCalculate.Controls.Add(this.rbYear);
            this.gbCalculate.Location = new System.Drawing.Point(4, 259);
            this.gbCalculate.Name = "gbCalculate";
            this.gbCalculate.Size = new System.Drawing.Size(250, 227);
            this.gbCalculate.TabIndex = 1;
            this.gbCalculate.TabStop = false;
            this.gbCalculate.Text = "Расчитать количество";
            // 
            // rbSecond
            // 
            this.rbSecond.AutoSize = true;
            this.rbSecond.Location = new System.Drawing.Point(8, 176);
            this.rbSecond.Name = "rbSecond";
            this.rbSecond.Size = new System.Drawing.Size(78, 24);
            this.rbSecond.TabIndex = 5;
            this.rbSecond.TabStop = true;
            this.rbSecond.Text = "Секунд";
            this.rbSecond.UseVisualStyleBackColor = true;
            // 
            // rbMinute
            // 
            this.rbMinute.AutoSize = true;
            this.rbMinute.Location = new System.Drawing.Point(8, 146);
            this.rbMinute.Name = "rbMinute";
            this.rbMinute.Size = new System.Drawing.Size(74, 24);
            this.rbMinute.TabIndex = 4;
            this.rbMinute.TabStop = true;
            this.rbMinute.Text = "Минут";
            this.rbMinute.UseVisualStyleBackColor = true;
            // 
            // rbHour
            // 
            this.rbHour.AutoSize = true;
            this.rbHour.Location = new System.Drawing.Point(8, 116);
            this.rbHour.Name = "rbHour";
            this.rbHour.Size = new System.Drawing.Size(72, 24);
            this.rbHour.TabIndex = 3;
            this.rbHour.TabStop = true;
            this.rbHour.Text = "Часов";
            this.rbHour.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(8, 86);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(66, 24);
            this.rbDay.TabIndex = 2;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Дней";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(8, 56);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(91, 24);
            this.rbMonth.TabIndex = 1;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Месяцев";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(8, 26);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(54, 24);
            this.rbYear.TabIndex = 0;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "Лет";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // gbInputDate
            // 
            this.gbInputDate.Controls.Add(this.comboBox);
            this.gbInputDate.Controls.Add(this.secondFIO);
            this.gbInputDate.Controls.Add(this.firstFIO);
            this.gbInputDate.Controls.Add(this.secondFIODate);
            this.gbInputDate.Controls.Add(this.cbExtendForm);
            this.gbInputDate.Controls.Add(this.maskedTextBox);
            this.gbInputDate.Location = new System.Drawing.Point(4, 4);
            this.gbInputDate.Name = "gbInputDate";
            this.gbInputDate.Size = new System.Drawing.Size(250, 249);
            this.gbInputDate.TabIndex = 0;
            this.gbInputDate.TabStop = false;
            this.gbInputDate.Text = "Введите дату";
            // 
            // secondFIO
            // 
            this.secondFIO.Location = new System.Drawing.Point(6, 125);
            this.secondFIO.Name = "secondFIO";
            this.secondFIO.Size = new System.Drawing.Size(238, 27);
            this.secondFIO.TabIndex = 6;
            // 
            // firstFIO
            // 
            this.firstFIO.Location = new System.Drawing.Point(8, 59);
            this.firstFIO.Name = "firstFIO";
            this.firstFIO.Size = new System.Drawing.Size(236, 27);
            this.firstFIO.TabIndex = 5;
            // 
            // secondFIODate
            // 
            this.secondFIODate.Location = new System.Drawing.Point(8, 92);
            this.secondFIODate.Mask = "00/00/0000";
            this.secondFIODate.Name = "secondFIODate";
            this.secondFIODate.Size = new System.Drawing.Size(238, 27);
            this.secondFIODate.TabIndex = 4;
            this.secondFIODate.ValidatingType = typeof(System.DateTime);
            // 
            // cbExtendForm
            // 
            this.cbExtendForm.AutoSize = true;
            this.cbExtendForm.Location = new System.Drawing.Point(8, 219);
            this.cbExtendForm.Name = "cbExtendForm";
            this.cbExtendForm.Size = new System.Drawing.Size(238, 24);
            this.cbExtendForm.TabIndex = 3;
            this.cbExtendForm.Text = "Доп. приколы 10-го варианта";
            this.cbExtendForm.UseVisualStyleBackColor = true;
            this.cbExtendForm.CheckedChanged += new System.EventHandler(this.cbExtendForm_CheckedChanged);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(8, 26);
            this.maskedTextBox.Mask = "00/00/0000";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(236, 27);
            this.maskedTextBox.TabIndex = 0;
            this.maskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAction
            // 
            this.tsmiAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalculate,
            this.clearDate,
            this.clearResult});
            this.tsmiAction.Name = "tsmiAction";
            this.tsmiAction.Size = new System.Drawing.Size(88, 24);
            this.tsmiAction.Text = "Действие";
            // 
            // tsmiCalculate
            // 
            this.tsmiCalculate.Name = "tsmiCalculate";
            this.tsmiCalculate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiCalculate.Size = new System.Drawing.Size(238, 26);
            this.tsmiCalculate.Text = "Расчитать";
            this.tsmiCalculate.Click += new System.EventHandler(this.tsmiCalculate_Click);
            // 
            // clearDate
            // 
            this.clearDate.Name = "clearDate";
            this.clearDate.Size = new System.Drawing.Size(238, 26);
            this.clearDate.Text = "Очистить дату";
            this.clearDate.Click += new System.EventHandler(this.clearDate_Click);
            // 
            // clearResult
            // 
            this.clearResult.Name = "clearResult";
            this.clearResult.Size = new System.Drawing.Size(238, 26);
            this.clearResult.Text = "Очистить результаты";
            this.clearResult.Click += new System.EventHandler(this.clearResult_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getAbout});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // getAbout
            // 
            this.getAbout.Name = "getAbout";
            this.getAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.getAbout.Size = new System.Drawing.Size(211, 26);
            this.getAbout.Text = "О программе";
            this.getAbout.Click += new System.EventHandler(this.getAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCalculate,
            this.tsbClearDate,
            this.tsbClearResult});
            this.toolStrip1.Location = new System.Drawing.Point(4, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(412, 27);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbCalculate
            // 
            this.tsbCalculate.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalculate.Image")));
            this.tsbCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalculate.Name = "tsbCalculate";
            this.tsbCalculate.Size = new System.Drawing.Size(101, 24);
            this.tsbCalculate.Text = "Расчитать";
            this.tsbCalculate.Click += new System.EventHandler(this.tsmiCalculate_Click);
            // 
            // tsbClearDate
            // 
            this.tsbClearDate.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearDate.Image")));
            this.tsbClearDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearDate.Name = "tsbClearDate";
            this.tsbClearDate.Size = new System.Drawing.Size(130, 24);
            this.tsbClearDate.Text = "Очистить дату";
            this.tsbClearDate.Click += new System.EventHandler(this.clearDate_Click);
            // 
            // tsbClearResult
            // 
            this.tsbClearResult.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearResult.Image")));
            this.tsbClearResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearResult.Name = "tsbClearResult";
            this.tsbClearResult.Size = new System.Drawing.Size(168, 24);
            this.tsbClearResult.Text = "Очистить результат";
            this.tsbClearResult.Click += new System.EventHandler(this.clearResult_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Старше",
            "Младше"});
            this.comboBox.Location = new System.Drawing.Point(8, 178);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(236, 28);
            this.comboBox.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 542);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Расчет интервалов времени";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbCalculate.ResumeLayout(false);
            this.gbCalculate.PerformLayout();
            this.gbInputDate.ResumeLayout(false);
            this.gbInputDate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalculate;
        private System.Windows.Forms.ToolStripMenuItem clearDate;
        private System.Windows.Forms.ToolStripMenuItem clearResult;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox gbInputDate;
        private System.Windows.Forms.GroupBox gbCalculate;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.RadioButton rbSecond;
        private System.Windows.Forms.RadioButton rbMinute;
        private System.Windows.Forms.RadioButton rbHour;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ToolStripButton tsbCalculate;
        private System.Windows.Forms.ToolStripButton tsbClearDate;
        private System.Windows.Forms.ToolStripButton tsbClearResult;
        private System.Windows.Forms.TextBox secondFIO;
        private System.Windows.Forms.TextBox firstFIO;
        private System.Windows.Forms.MaskedTextBox secondFIODate;
        private System.Windows.Forms.CheckBox cbExtendForm;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

