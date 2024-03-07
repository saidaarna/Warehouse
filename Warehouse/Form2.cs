using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Form2 : Form
    {
        DBWarehouseEntities db = new DBWarehouseEntities();
        public Form2()
        {
            InitializeComponent();
        }





        

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           // System.Windows.Forms.Application.Exit();

        }

        private void buttonAddOrUpdate_Click(object sender, EventArgs e)
        {
            string productName = txtmehsul.Text.Trim();
            string productCategory = txtKateqoriya.Text.Trim();
            string productCount = txtmiqdar.Text.Trim();
            string priceText = txtQiymet.Text.Trim();
            string warehouseAddress = txtAdres.Text.Trim();


            bool nameExists = db.TBLProducts.Any(entry => entry.ProductName == productName);

            if (nameExists)
            {
                int price;
                if (!int.TryParse(priceText, out price))
                {
                    MessageBox.Show("uYGUN QIYMET DEYIL.");
                    return;
                }

                int count;
                if (!int.TryParse(productCount, out count))
                {
                    MessageBox.Show("uYGUN say DEYIL.");
                    return;
                }


                bool warehouseExists = db.TBLWarehouses.Any(entry => entry.Address == warehouseAddress);

                if (warehouseExists)
                {

                    TBLProduct newProduct = new TBLProduct
                    {
                        ProductName = productName,
                        ProductCategory = productCategory,
                        Price = price,
                        Stock = count,
                        WarehouseAddress = warehouseAddress


                    };


                    db.TBLProducts.Add(newProduct);
                    db.SaveChanges();
                    MessageBox.Show("Deyisdirildi.");
                }

                else
                {
                    MessageBox.Show("Anbar Movcud deyil.");
                }

            }

            else
            {
                int price;
                if (!int.TryParse(priceText, out price))
                {
                    MessageBox.Show("uYGUN QIYMET DEYIL.");
                    return;
                }

                int count;
                if (!int.TryParse(productCount, out count))
                {
                    MessageBox.Show("uYGUN say DEYIL.");
                    return;
                }


                bool warehouseExists = db.TBLWarehouses.Any(entry => entry.Address == warehouseAddress);

                if (warehouseExists)
                {

                    TBLProduct newProduct = new TBLProduct
                    {
                        ProductName = productName,
                        ProductCategory = productCategory,
                        Price = price,
                        Stock = count,
                        WarehouseAddress = warehouseAddress


                    };


                    db.TBLProducts.Add(newProduct);
                    db.SaveChanges();
                    MessageBox.Show("Elave edildi.");
                }

                else
                {
                    MessageBox.Show("Anbar Movcud deyil.");
                }

            }
        }
    }
}
