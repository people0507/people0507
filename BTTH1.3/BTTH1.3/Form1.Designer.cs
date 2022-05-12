namespace BTTH1._3
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
            this.txtPlus = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMinus = new System.Windows.Forms.RadioButton();
            this.txtMultiply = new System.Windows.Forms.RadioButton();
            this.txtDivine = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlus
            // 
            this.txtPlus.AutoSize = true;
            this.txtPlus.Location = new System.Drawing.Point(23, 42);
            this.txtPlus.Name = "txtPlus";
            this.txtPlus.Size = new System.Drawing.Size(50, 17);
            this.txtPlus.TabIndex = 0;
            this.txtPlus.TabStop = true;
            this.txtPlus.Text = "Cộng";
            this.txtPlus.UseVisualStyleBackColor = true;
            this.txtPlus.CheckedChanged += new System.EventHandler(this.txtPlus_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDivine);
            this.groupBox1.Controls.Add(this.txtMultiply);
            this.groupBox1.Controls.Add(this.txtMinus);
            this.groupBox1.Controls.Add(this.txtPlus);
            this.groupBox1.Location = new System.Drawing.Point(113, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMinus
            // 
            this.txtMinus.AutoSize = true;
            this.txtMinus.Location = new System.Drawing.Point(157, 42);
            this.txtMinus.Name = "txtMinus";
            this.txtMinus.Size = new System.Drawing.Size(41, 17);
            this.txtMinus.TabIndex = 1;
            this.txtMinus.TabStop = true;
            this.txtMinus.Text = "Trừ";
            this.txtMinus.UseVisualStyleBackColor = true;
            this.txtMinus.CheckedChanged += new System.EventHandler(this.txtMinus_CheckedChanged);
            // 
            // txtMultiply
            // 
            this.txtMultiply.AutoSize = true;
            this.txtMultiply.Location = new System.Drawing.Point(289, 42);
            this.txtMultiply.Name = "txtMultiply";
            this.txtMultiply.Size = new System.Drawing.Size(51, 17);
            this.txtMultiply.TabIndex = 2;
            this.txtMultiply.TabStop = true;
            this.txtMultiply.Text = "Nhân";
            this.txtMultiply.UseVisualStyleBackColor = true;
            this.txtMultiply.CheckedChanged += new System.EventHandler(this.txtMultiply_CheckedChanged);
            // 
            // txtDivine
            // 
            this.txtDivine.AutoSize = true;
            this.txtDivine.Location = new System.Drawing.Point(423, 42);
            this.txtDivine.Name = "txtDivine";
            this.txtDivine.Size = new System.Drawing.Size(46, 17);
            this.txtDivine.TabIndex = 3;
            this.txtDivine.TabStop = true;
            this.txtDivine.Text = "Chia";
            this.txtDivine.UseVisualStyleBackColor = true;
            this.txtDivine.CheckedChanged += new System.EventHandler(this.txtDivine_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kết quả";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(215, 351);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(325, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Phép tính";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton txtPlus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton txtDivine;
        private System.Windows.Forms.RadioButton txtMultiply;
        private System.Windows.Forms.RadioButton txtMinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

