namespace BTTH4._3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btn_Display = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Kq1 = new System.Windows.Forms.Label();
            this.lbl_Kq2 = new System.Windows.Forms.Label();
            this.lbl_Kq3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số n";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(245, 80);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(147, 20);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            this.txtN.Leave += new System.EventHandler(this.txtN_Leave);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(412, 77);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(75, 23);
            this.btn_Display.TabIndex = 2;
            this.btn_Display.Text = "Hiển thị";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_DisplayClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Các số nguyên tố nhỏ hơn n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Các số chính phương nhỏ hơn n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lbl_Kq1
            // 
            this.lbl_Kq1.AutoSize = true;
            this.lbl_Kq1.Location = new System.Drawing.Point(331, 117);
            this.lbl_Kq1.Name = "lbl_Kq1";
            this.lbl_Kq1.Size = new System.Drawing.Size(0, 13);
            this.lbl_Kq1.TabIndex = 7;
            // 
            // lbl_Kq2
            // 
            this.lbl_Kq2.AutoSize = true;
            this.lbl_Kq2.Location = new System.Drawing.Point(345, 146);
            this.lbl_Kq2.Name = "lbl_Kq2";
            this.lbl_Kq2.Size = new System.Drawing.Size(0, 13);
            this.lbl_Kq2.TabIndex = 8;
            // 
            // lbl_Kq3
            // 
            this.lbl_Kq3.AutoSize = true;
            this.lbl_Kq3.Location = new System.Drawing.Point(337, 182);
            this.lbl_Kq3.Name = "lbl_Kq3";
            this.lbl_Kq3.Size = new System.Drawing.Size(0, 13);
            this.lbl_Kq3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 293);
            this.Controls.Add(this.lbl_Kq3);
            this.Controls.Add(this.lbl_Kq2);
            this.Controls.Add(this.lbl_Kq1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lbl_Kq3;
        private System.Windows.Forms.Label lbl_Kq2;
        private System.Windows.Forms.Label lbl_Kq1;
    }
}

