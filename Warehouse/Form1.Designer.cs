namespace Warehouse
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mallarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.anbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.əvvələQayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(130, 28);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mallarToolStripMenuItem1,
            this.anbarToolStripMenuItem,
            this.alToolStripMenuItem,
            this.satToolStripMenuItem,
            this.əvvələQayıtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mallarToolStripMenuItem1
            // 
            this.mallarToolStripMenuItem1.Name = "mallarToolStripMenuItem1";
            this.mallarToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.mallarToolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.mallarToolStripMenuItem1.Text = "Mallar";
            this.mallarToolStripMenuItem1.Click += new System.EventHandler(this.mallarToolStripMenuItem1_Click);
            // 
            // anbarToolStripMenuItem
            // 
            this.anbarToolStripMenuItem.Name = "anbarToolStripMenuItem";
            this.anbarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.anbarToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.anbarToolStripMenuItem.Text = "Anbar";
            this.anbarToolStripMenuItem.Click += new System.EventHandler(this.anbarToolStripMenuItem_Click);
            // 
            // alToolStripMenuItem
            // 
            this.alToolStripMenuItem.Name = "alToolStripMenuItem";
            this.alToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.alToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.alToolStripMenuItem.Text = "Idxal";
            this.alToolStripMenuItem.Click += new System.EventHandler(this.alToolStripMenuItem_Click);
            // 
            // satToolStripMenuItem
            // 
            this.satToolStripMenuItem.Name = "satToolStripMenuItem";
            this.satToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.satToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.satToolStripMenuItem.Text = "Ixrac";
            this.satToolStripMenuItem.Click += new System.EventHandler(this.satToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(210, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(2, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 462);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // əvvələQayıtToolStripMenuItem
            // 
            this.əvvələQayıtToolStripMenuItem.Name = "əvvələQayıtToolStripMenuItem";
            this.əvvələQayıtToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.əvvələQayıtToolStripMenuItem.Text = "Əvvələ qayıt";
            this.əvvələQayıtToolStripMenuItem.Click += new System.EventHandler(this.əvvələQayıtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warehouse.Properties.Resources.sky_mvehfqz6w2ges2dj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Anbar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mallarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem əvvələQayıtToolStripMenuItem;
    }
}

