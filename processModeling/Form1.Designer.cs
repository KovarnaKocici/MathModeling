namespace processModeling
{
    partial class FormMM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelProcess = new System.Windows.Forms.Label();
            this.comboBoxProcess = new System.Windows.Forms.ComboBox();
            this.labelX = new System.Windows.Forms.Label();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.labelDynamic = new System.Windows.Forms.Label();
            this.comboBoxDynamic = new System.Windows.Forms.ComboBox();
            this.chartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelT = new System.Windows.Forms.Label();
            this.comboBoxT = new System.Windows.Forms.ComboBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelXs = new System.Windows.Forms.Label();
            this.textBoxXn = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(18, 14);
            this.labelProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(243, 20);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "Виберіть диф. оператор  L(Ds)";
            // 
            // comboBoxProcess
            // 
            this.comboBoxProcess.FormattingEnabled = true;
            this.comboBoxProcess.Items.AddRange(new object[] {
            "Dt-D^2x",
            "Dt^2-c^2Dx^2",
            "Dt^2-c^2(Dx1^2 +Dx2^2)"});
            this.comboBoxProcess.Location = new System.Drawing.Point(18, 38);
            this.comboBoxProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxProcess.Name = "comboBoxProcess";
            this.comboBoxProcess.Size = new System.Drawing.Size(228, 28);
            this.comboBoxProcess.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(18, 75);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(179, 20);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Виберіть розмірність x";
            // 
            // comboBoxX
            // 
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Items.AddRange(new object[] {
            "Одновимірний",
            "Двовимірний"});
            this.comboBoxX.Location = new System.Drawing.Point(18, 100);
            this.comboBoxX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(228, 28);
            this.comboBoxX.TabIndex = 3;
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.Location = new System.Drawing.Point(18, 198);
            this.labelDynamic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(224, 20);
            this.labelDynamic.TabIndex = 4;
            this.labelDynamic.Text = "Виберіть як протікає процес";
            // 
            // comboBoxDynamic
            // 
            this.comboBoxDynamic.FormattingEnabled = true;
            this.comboBoxDynamic.Items.AddRange(new object[] {
            "Динамічно",
            "Статично"});
            this.comboBoxDynamic.Location = new System.Drawing.Point(18, 223);
            this.comboBoxDynamic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDynamic.Name = "comboBoxDynamic";
            this.comboBoxDynamic.Size = new System.Drawing.Size(228, 28);
            this.comboBoxDynamic.TabIndex = 5;
            // 
            // chartY
            // 
            chartArea2.Name = "ChartArea1";
            this.chartY.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartY.Legends.Add(legend2);
            this.chartY.Location = new System.Drawing.Point(501, 14);
            this.chartY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartY.Name = "chartY";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartY.Series.Add(series2);
            this.chartY.Size = new System.Drawing.Size(800, 805);
            this.chartY.TabIndex = 6;
            this.chartY.Text = "chart1";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(18, 260);
            this.labelT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(90, 20);
            this.labelT.TabIndex = 7;
            this.labelT.Text = "Виберіть T";
            // 
            // comboBoxT
            // 
            this.comboBoxT.FormattingEnabled = true;
            this.comboBoxT.Items.AddRange(new object[] {
            "2"});
            this.comboBoxT.Location = new System.Drawing.Point(18, 285);
            this.comboBoxT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxT.Name = "comboBoxT";
            this.comboBoxT.Size = new System.Drawing.Size(228, 28);
            this.comboBoxT.TabIndex = 8;
            this.comboBoxT.SelectedIndexChanged += new System.EventHandler(this.comboBoxT_SelectedIndexChanged);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(22, 346);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(85, 26);
            this.textBoxX1.TabIndex = 9;
            // 
            // labelXs
            // 
            this.labelXs.AutoSize = true;
            this.labelXs.Location = new System.Drawing.Point(18, 322);
            this.labelXs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXs.Name = "labelXs";
            this.labelXs.Size = new System.Drawing.Size(121, 20);
            this.labelXs.TabIndex = 10;
            this.labelXs.Text = "Виберіть x1, xn";
            // 
            // textBoxXn
            // 
            this.textBoxXn.Location = new System.Drawing.Point(158, 346);
            this.textBoxXn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxXn.Name = "textBoxXn";
            this.textBoxXn.Size = new System.Drawing.Size(85, 26);
            this.textBoxXn.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "y(s(x,t))=sintsinx",
            "y(s(x,t))=sintcosx",
            "y(s(x,t))=costcosx",
            "y(s(x,t))=costsinx"});
            this.comboBox1.Location = new System.Drawing.Point(18, 162);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Виберіть y(s)";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(22, 400);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 35);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 837);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxXn);
            this.Controls.Add(this.labelXs);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.comboBoxT);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.chartY);
            this.Controls.Add(this.comboBoxDynamic);
            this.Controls.Add(this.labelDynamic);
            this.Controls.Add(this.comboBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.comboBoxProcess);
            this.Controls.Add(this.labelProcess);
            this.Name = "FormMM";
            this.Text = "Modeling ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.ComboBox comboBoxProcess;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.ComboBox comboBoxX;
        private System.Windows.Forms.Label labelDynamic;
        private System.Windows.Forms.ComboBox comboBoxDynamic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartY;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.ComboBox comboBoxT;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labelXs;
        private System.Windows.Forms.TextBox textBoxXn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
    }
}

