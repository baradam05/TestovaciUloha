using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TestovaciUloha.Model;

namespace TestovaciUloha
{
    public partial class MainForm : Form
    {
        public Context context = new Context();

        public MainForm()
        {
            InitializeComponent();
            SetProducts();
        }

        #region Product

        private void button_ProductAdd_Click(object sender, EventArgs e)
        {
            Product_InsertEdit_Form newProduct = new Product_InsertEdit_Form();

            if (newProduct.ShowDialog() == DialogResult.OK)
            {
                this.context.Product.Add(new Product()
                {
                    name = newProduct.textBox_Name.Text,
                    description = newProduct.textBox_Description.Text,
                    price = Convert.ToDouble(newProduct.textBox_Price.Text.Replace('.', ',')),
                    note = newProduct.textBox_Note.Text,
                });

                this.context.SaveChanges();
                this.SetProducts();
            }
        }

        private void button_ProductEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_Products.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row was selected");
                return;
            }

            int selectedIndex = this.dataGridView_Products.CurrentCell.RowIndex;
            Product selected = this.context.Product.ToList()[selectedIndex];

            Product_InsertEdit_Form newProduct = new Product_InsertEdit_Form();
            newProduct.textBox_Name.Text = selected.name;
            newProduct.textBox_Description.Text = selected.description;
            newProduct.textBox_Price.Text = selected.price.ToString();
            newProduct.textBox_Note.Text = selected.note;

            if (newProduct.ShowDialog() == DialogResult.OK)
            {
                selected.name = newProduct.textBox_Name.Text;
                selected.description = newProduct.textBox_Description.Text;
                selected.price = Convert.ToInt32(newProduct.textBox_Price.Text);
                selected.note = newProduct.textBox_Note.Text;

                context.SaveChanges();
                this.SetProducts();
            }
        }

        private void button_ProductDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_Products.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row was selected");
                return;
            }

            int removingIndex = this.dataGridView_Products.CurrentCell.RowIndex;
            int removingId = (int)this.context.Product.ToList()[removingIndex].id;
            Product removing = this.context.Product.Find(removingId);
            this.context.Product.Remove(removing);

            List<Part> removingParts = this.context.Part.Where(x => x.productId == removing.id).ToList();
            this.context.Part.RemoveRange(removingParts);

            this.context.SaveChanges();
            this.SetProducts();
        }

        private void dataGridView_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetParts((int)this.context.Product.ToList()[this.dataGridView_Products.CurrentCell.RowIndex].id);
        }

        #endregion

        #region Part

        private void button_PartAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        private void button_PartEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        private void button_PartDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_Parts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row was selected");
                return;
            }

            int removingIndex = this.dataGridView_Parts.SelectedRows[0].Index;
            int removingId = (int)this.context.Part.ToList()[removingIndex].id;
            Part removing = this.context.Part.Find(removingId);
            this.context.Part.Remove(removing);
            this.context.SaveChanges();

            SetParts((int)this.context.Product.ToList()[this.dataGridView_Products.CurrentCell.RowIndex].id);
        }

        #endregion

        private void button_refrech_Click(object sender, EventArgs e)
        {
            SetProducts();
        }

        #region GridMethods
        private void SetProducts()
        {
            List<ProductDto> products = new List<ProductDto>();
            foreach (Product product in context.Product.ToList())
            {
                ProductDto productDto = new ProductDto(product);
                productDto.Parts = context.Part.Where(x => x.productId == product.id).ToList().Count;

                products.Add(productDto);
            }

            this.dataGridView_Products.DataSource = products;
        }

        private void SetParts(int ProductId)
        {
            List<Part> parts = this.context.Part.Where(x => x.productId == ProductId).ToList();
            this.dataGridView_Parts.DataSource = parts;
        }
        #endregion
    }
}
