namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mulai = new System.Windows.Forms.Button();
            this.txtangka = new System.Windows.Forms.TextBox();
            this.lsthasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "angka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "terbilang";
            // 
            // mulai
            // 
            this.mulai.Location = new System.Drawing.Point(175, 19);
            this.mulai.Name = "mulai";
            this.mulai.Size = new System.Drawing.Size(75, 23);
            this.mulai.TabIndex = 2;
            this.mulai.Text = "mulai";
            this.mulai.UseVisualStyleBackColor = true;
            this.mulai.Click += new System.EventHandler(this.mulai_Click);
            // 
            // txtangka
            // 
            this.txtangka.Location = new System.Drawing.Point(61, 19);
            this.txtangka.Name = "txtangka";
            this.txtangka.Size = new System.Drawing.Size(100, 20);
            this.txtangka.TabIndex = 3;
            // 
            // lsthasil
            // 
            this.lsthasil.Location = new System.Drawing.Point(61, 58);
            this.lsthasil.Multiline = true;
            this.lsthasil.Name = "lsthasil";
            this.lsthasil.Size = new System.Drawing.Size(189, 98);
            this.lsthasil.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lsthasil);
            this.Controls.Add(this.txtangka);
            this.Controls.Add(this.mulai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mulai;
        private System.Windows.Forms.TextBox txtangka;
        private System.Windows.Forms.TextBox lsthasil;
    }
}

