namespace Warehouse
{
    partial class Form2
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
            this.miqdar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmehsul = new System.Windows.Forms.TextBox();
            this.txtKateqoriya = new System.Windows.Forms.TextBox();
            this.txtmiqdar = new System.Windows.Forms.TextBox();
            this.txtQiymet = new System.Windows.Forms.TextBox();
            this.buttonAddOrUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // miqdar
            // 
            this.miqdar.AutoSize = true;
            this.miqdar.Location = new System.Drawing.Point(30, 38);
            this.miqdar.Name = "miqdar";
            this.miqdar.Size = new System.Drawing.Size(72, 16);
            this.miqdar.TabIndex = 0;
            this.miqdar.Text = "Məhsul adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kateqoriya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miqdar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qiymət";
            // 
            // txtmehsul
            // 
            this.txtmehsul.Location = new System.Drawing.Point(108, 34);
            this.txtmehsul.Name = "txtmehsul";
            this.txtmehsul.Size = new System.Drawing.Size(217, 22);
            this.txtmehsul.TabIndex = 4;
            // 
            // txtKateqoriya
            // 
            this.txtKateqoriya.Location = new System.Drawing.Point(109, 75);
            this.txtKateqoriya.Name = "txtKateqoriya";
            this.txtKateqoriya.Size = new System.Drawing.Size(215, 22);
            this.txtKateqoriya.TabIndex = 5;
            // 
            // txtmiqdar
            // 
            this.txtmiqdar.Location = new System.Drawing.Point(108, 120);
            this.txtmiqdar.Name = "txtmiqdar";
            this.txtmiqdar.Size = new System.Drawing.Size(215, 22);
            this.txtmiqdar.TabIndex = 6;
            // 
            // txtQiymet
            // 
            this.txtQiymet.Location = new System.Drawing.Point(109, 158);
            this.txtQiymet.Name = "txtQiymet";
            this.txtQiymet.Size = new System.Drawing.Size(215, 22);
            this.txtQiymet.TabIndex = 7;
            // 
            // buttonAddOrUpdate
            // 
            this.buttonAddOrUpdate.Location = new System.Drawing.Point(171, 265);
            this.buttonAddOrUpdate.Name = "buttonAddOrUpdate";
            this.buttonAddOrUpdate.Size = new System.Drawing.Size(152, 41);
            this.buttonAddOrUpdate.TabIndex = 8;
            this.buttonAddOrUpdate.Text = "Əlavə et";
            this.buttonAddOrUpdate.UseVisualStyleBackColor = true;
            this.buttonAddOrUpdate.Click += new System.EventHandler(this.buttonAddOrUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Anbar Adresi";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(108, 205);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(215, 22);
            this.txtAdres.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 336);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddOrUpdate);
            this.Controls.Add(this.txtQiymet);
            this.Controls.Add(this.txtmiqdar);
            this.Controls.Add(this.txtKateqoriya);
            this.Controls.Add(this.txtmehsul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.miqdar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label miqdar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmehsul;
        private System.Windows.Forms.TextBox txtKateqoriya;
        private System.Windows.Forms.TextBox txtmiqdar;
        private System.Windows.Forms.TextBox txtQiymet;
        private System.Windows.Forms.Button buttonAddOrUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
    }
}