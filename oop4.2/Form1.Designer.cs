namespace oop4._2
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelLess1 = new System.Windows.Forms.Label();
            this.labelEquals1 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.labelA.Location = new System.Drawing.Point(131, 86);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(84, 83);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
 //           this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelLess1
            // 
            this.labelLess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.labelLess1.Location = new System.Drawing.Point(200, 86);
            this.labelLess1.Name = "labelLess1";
            this.labelLess1.Size = new System.Drawing.Size(82, 83);
            this.labelLess1.TabIndex = 1;
            this.labelLess1.Text = "<=";
            // 
            // labelEquals1
            // 
            this.labelEquals1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.labelEquals1.Location = new System.Drawing.Point(259, 86);
            this.labelEquals1.Name = "labelEquals1";
            this.labelEquals1.Size = new System.Drawing.Size(82, 83);
            this.labelEquals1.TabIndex = 2;
            this.labelEquals1.Text = "=";
            // 
            // labelB
            // 
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.labelB.Location = new System.Drawing.Point(338, 86);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(84, 83);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.Location = new System.Drawing.Point(414, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 83);
            this.label2.TabIndex = 4;
            this.label2.Text = "<=";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label3.Location = new System.Drawing.Point(484, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 83);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // labelC
            // 
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.labelC.Location = new System.Drawing.Point(556, 86);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(84, 83);
            this.labelC.TabIndex = 6;
            this.labelC.Text = "C";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(115, 204);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 7;
            this.textBoxA.Text = "0";
            this.textBoxA.Leave += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(333, 204);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 8;
            this.textBoxB.Text = "50";
            this.textBoxB.Leave += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(558, 204);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 22);
            this.textBoxC.TabIndex = 9;
            this.textBoxC.Text = "90";
            this.textBoxC.Leave += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(115, 247);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownA.TabIndex = 10;
            this.numericUpDownA.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(333, 247);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownB.TabIndex = 11;
            this.numericUpDownB.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(558, 247);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownC.TabIndex = 12;
            this.numericUpDownC.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(115, 294);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(104, 56);
            this.trackBarA.TabIndex = 13;
            this.trackBarA.Value = 10;
            this.trackBarA.ValueChanged += new System.EventHandler(this.trackBarA_ValueChanged);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(329, 294);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(104, 56);
            this.trackBarB.TabIndex = 14;
            this.trackBarB.Value = 50;
            this.trackBarB.ValueChanged += new System.EventHandler(this.trackBarB_ValueChanged);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(558, 294);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(104, 56);
            this.trackBarC.TabIndex = 15;
            this.trackBarC.Value = 90;
            this.trackBarC.ValueChanged += new System.EventHandler(this.trackBarC_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelEquals1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLess1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelLess1;
        private System.Windows.Forms.Label labelEquals1;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarC;
    }
}

