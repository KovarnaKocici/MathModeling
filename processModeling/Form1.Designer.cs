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
            this.labelProcess.Location = new System.Drawing.Point(29, 25);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(158, 13);
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
            this.comboBoxProcess.Location = new System.Drawing.Point(29, 41);
            this.comboBoxProcess.Name = "comboBoxProcess";
            this.comboBoxProcess.Size = new System.Drawing.Size(255, 21);
            this.comboBoxProcess.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(29, 65);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(121, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Виберіть розмірність x";
            // 
            // comboBoxX
            // 
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Items.AddRange(new object[] {
            "Одновимірний",
            "Двовимірний"});
            this.comboBoxX.Location = new System.Drawing.Point(29, 81);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(255, 21);
            this.comboBoxX.TabIndex = 3;
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.Location = new System.Drawing.Point(29, 145);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(151, 13);
            this.labelDynamic.TabIndex = 4;
            this.labelDynamic.Text = "Виберіть як протікає процес";
            // 
            // comboBoxDynamic
            // 
            this.comboBoxDynamic.FormattingEnabled = true;
            this.comboBoxDynamic.Items.AddRange(new object[] {
            "Динамічно",
            "Статично"});
            this.comboBoxDynamic.Location = new System.Drawing.Point(29, 161);
            this.comboBoxDynamic.Name = "comboBoxDynamic";
            this.comboBoxDynamic.Size = new System.Drawing.Size(255, 21);
            this.comboBoxDynamic.TabIndex = 5;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(29, 185);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(55, 13);
            this.labelT.TabIndex = 7;
            this.labelT.Text = "Введіть T";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(30, 241);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(107, 20);
            this.textBoxX1.TabIndex = 9;
            // 
            // labelXs
            // 
            this.labelXs.AutoSize = true;
            this.labelXs.Location = new System.Drawing.Point(29, 226);
            this.labelXs.Name = "labelXs";
            this.labelXs.Size = new System.Drawing.Size(82, 13);
            this.labelXs.TabIndex = 10;
            this.labelXs.Text = "Виберіть x1, xn";
            // 
            // textBoxXn
            // 
            this.textBoxXn.Location = new System.Drawing.Point(165, 241);
            this.textBoxXn.Name = "textBoxXn";
            this.textBoxXn.Size = new System.Drawing.Size(117, 20);
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
            this.comboBoxY.Location = new System.Drawing.Point(29, 122);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(255, 21);
            this.comboBoxY.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Виберіть y(s)";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(65, 287);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(177, 75);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(32, 201);
            this.textBoxT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(253, 20);
            this.textBoxT.TabIndex = 16;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(331, 3);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(437, 249);
            this.elementHost1.TabIndex = 15;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.surfaceControl1;
            // 
            // initYs
            // 
            this.initYs.FormattingEnabled = true;
            this.initYs.Location = new System.Drawing.Point(331, 256);
            this.initYs.Margin = new System.Windows.Forms.Padding(2);
            this.initYs.Name = "initYs";
            this.initYs.Size = new System.Drawing.Size(207, 173);
            this.initYs.TabIndex = 17;
            // 
            // finalYs
            // 
            this.finalYs.FormattingEnabled = true;
            this.finalYs.Location = new System.Drawing.Point(561, 256);
            this.finalYs.Margin = new System.Windows.Forms.Padding(2);
            this.finalYs.Name = "finalYs";
            this.finalYs.Size = new System.Drawing.Size(207, 173);
            this.finalYs.TabIndex = 18;
            // 
            // FormMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 431);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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

