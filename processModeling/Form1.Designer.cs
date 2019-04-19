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
            this.labelProcess = new System.Windows.Forms.Label();
            this.comboBoxProcess = new System.Windows.Forms.ComboBox();
            this.labelX = new System.Windows.Forms.Label();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.labelDynamic = new System.Windows.Forms.Label();
            this.comboBoxDynamic = new System.Windows.Forms.ComboBox();
            this.labelT = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelXs = new System.Windows.Forms.Label();
            this.textBoxXn = new System.Windows.Forms.TextBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.surfaceControl1 = new processModeling.SurfaceControl();
            this.initYs = new System.Windows.Forms.ListBox();
            this.finalYs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(44, 39);
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
            this.comboBoxProcess.Location = new System.Drawing.Point(44, 63);
            this.comboBoxProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxProcess.Name = "comboBoxProcess";
            this.comboBoxProcess.Size = new System.Drawing.Size(381, 28);
            this.comboBoxProcess.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(44, 100);
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
            this.comboBoxX.Location = new System.Drawing.Point(44, 125);
            this.comboBoxX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(381, 28);
            this.comboBoxX.TabIndex = 3;
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.Location = new System.Drawing.Point(44, 223);
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
            this.comboBoxDynamic.Location = new System.Drawing.Point(44, 248);
            this.comboBoxDynamic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDynamic.Name = "comboBoxDynamic";
            this.comboBoxDynamic.Size = new System.Drawing.Size(381, 28);
            this.comboBoxDynamic.TabIndex = 5;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(44, 285);
            this.labelT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(83, 20);
            this.labelT.TabIndex = 7;
            this.labelT.Text = "Введіть T";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(45, 371);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(158, 26);
            this.textBoxX1.TabIndex = 9;
            // 
            // labelXs
            // 
            this.labelXs.AutoSize = true;
            this.labelXs.Location = new System.Drawing.Point(44, 347);
            this.labelXs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXs.Name = "labelXs";
            this.labelXs.Size = new System.Drawing.Size(121, 20);
            this.labelXs.TabIndex = 10;
            this.labelXs.Text = "Виберіть x1, xn";
            // 
            // textBoxXn
            // 
            this.textBoxXn.Location = new System.Drawing.Point(248, 371);
            this.textBoxXn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxXn.Name = "textBoxXn";
            this.textBoxXn.Size = new System.Drawing.Size(174, 26);
            this.textBoxXn.TabIndex = 11;
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Items.AddRange(new object[] {
            "y(s(x,t))=costcosx",
            "y(s(x,t))=sintsinx",
            "y(s(x,t))=sintcosx",
            "y(s(x,t))=costsinx"});
            this.comboBoxY.Location = new System.Drawing.Point(44, 187);
            this.comboBoxY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(381, 28);
            this.comboBoxY.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Виберіть y(s)";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(92, 421);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(265, 115);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(48, 309);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(377, 26);
            this.textBoxT.TabIndex = 16;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(496, 38);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(656, 297);
            this.elementHost1.TabIndex = 15;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.surfaceControl1;
            // 
            // initYs
            // 
            this.initYs.FormattingEnabled = true;
            this.initYs.ItemHeight = 20;
            this.initYs.Location = new System.Drawing.Point(496, 371);
            this.initYs.Name = "initYs";
            this.initYs.Size = new System.Drawing.Size(309, 184);
            this.initYs.TabIndex = 17;
            // 
            // finalYs
            // 
            this.finalYs.FormattingEnabled = true;
            this.finalYs.ItemHeight = 20;
            this.finalYs.Location = new System.Drawing.Point(843, 371);
            this.finalYs.Name = "finalYs";
            this.finalYs.Size = new System.Drawing.Size(309, 184);
            this.finalYs.TabIndex = 18;
            // 
            // FormMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 561);
            this.Controls.Add(this.finalYs);
            this.Controls.Add(this.initYs);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.textBoxXn);
            this.Controls.Add(this.labelXs);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.comboBoxDynamic);
            this.Controls.Add(this.labelDynamic);
            this.Controls.Add(this.comboBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.comboBoxProcess);
            this.Controls.Add(this.labelProcess);
            this.Name = "FormMM";
            this.Text = "Modeling ";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labelXs;
        private System.Windows.Forms.TextBox textBoxXn;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private SurfaceControl surfaceControl1;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.ListBox initYs;
        private System.Windows.Forms.ListBox finalYs;
    }
}

