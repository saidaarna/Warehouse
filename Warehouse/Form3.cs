using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Form3 : Form
    {
        DBWarehouseEntities db=new DBWarehouseEntities();
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtsilID.Text);
            var x = db.TBLProducts.Find(id);

            if (x != null)
            {
                if (int.Parse(txtsilMiqdar.Text) >= x.Stock)
                {
                    db.TBLProducts.Remove(x);
                    db.SaveChanges();
                    MessageBox.Show("Silindi");
                }
                else
                {
                    
                    x.Stock -= int.Parse(txtsilMiqdar.Text);
                    db.SaveChanges();
                    MessageBox.Show("Stock azaldi");
                }
            }
            else
            {
                MessageBox.Show("Bele bir mehsul yoxdur.");
            }
        }
    }
}
