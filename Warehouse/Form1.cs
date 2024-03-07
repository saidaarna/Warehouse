using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Warehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WeatherDLL.Hava hava = new WeatherDLL.Hava();

            label1.Text = hava.get();

        }

        private void mallarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DBWarehouseEntities db=new DBWarehouseEntities();
            dataGridView1.DataSource=db.TBLProducts.ToList();
        }

        private void anbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DBWarehouseEntities db = new DBWarehouseEntities();
            dataGridView1.DataSource = db.TBLWarehouses.ToList();

        }

        private void alToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void satToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void əvvələQayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
