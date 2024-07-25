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
            Product firstProduct = this.context.Product.FirstOrDefault();
            if (firstProduct != null)
            {
                SetParts((int)firstProduct.id);
            }
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
            if (this.dataGridView_Products.CurrentCell.RowIndex == -1)
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
            if (this.dataGridView_Products.CurrentCell.RowIndex == -1)
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
            Part_InsertEdit_Form newPartForm = new();

            List<string> ProductDataSource = new();
            int i = 0;
            int selectedProductIndex = -1;

            List<Product> products = this.context.Product.ToList();
            foreach(Product product in products)
            {
                ProductDataSource.Add(product.name);
                
                if(product.id == (int)products[dataGridView_Products.CurrentCell.RowIndex].id)
                {
                    selectedProductIndex = i;
                }

                i++;
            }
            newPartForm.comboBox_Product.DataSource = ProductDataSource;
            newPartForm.comboBox_Product.SelectedIndex = selectedProductIndex;

            if (newPartForm.ShowDialog() == DialogResult.OK)
            {
                this.context.Part.Add(new Part()
                {
                    productId = (int)products[newPartForm.comboBox_Product.SelectedIndex].id,
                    name = newPartForm.textBox_Name.Text,
                    description = newPartForm.textBox_Description.Text,
                    price = Convert.ToDouble(newPartForm.textBox_Price.Text.Replace('.', ',')),
                });

                this.context.SaveChanges();
                SetParts((int)products[this.dataGridView_Products.CurrentCell.RowIndex].id);
            }
        }

        private void button_PartEdit_Click(object sender, EventArgs e)
        {
            Part_InsertEdit_Form newPartForm = new();

            List<string> ProductDataSource = new();
            int i = 0;
            int selectedProductIndex = -1;

            List<Product> products = this.context.Product.ToList();
            foreach (Product product in products)
            {
                ProductDataSource.Add(product.name);

                if (product.id == (int)products[dataGridView_Products.CurrentCell.RowIndex].id)
                {
                    selectedProductIndex = i;
                }

                i++;
            }
            newPartForm.comboBox_Product.DataSource = ProductDataSource;
             


            int selectedIndex = this.dataGridView_Parts.CurrentCell.RowIndex;
            Part selected = this.context.Part.ToList()[selectedIndex];

            newPartForm.textBox_Name.Text = selected.name;
            newPartForm.textBox_Description.Text = selected.description;
            newPartForm.textBox_Price.Text = selected.price.ToString();

            if (newPartForm.ShowDialog() == DialogResult.OK)
            {
                selected.productId = (int)products[newPartForm.comboBox_Product.SelectedIndex].id;
                selected.name = newPartForm.textBox_Name.Text;
                selected.description = newPartForm.textBox_Description.Text;
                selected.price = Convert.ToDouble(newPartForm.textBox_Price.Text.Replace('.', ','));

                this.context.SaveChanges();
                SetParts((int)products[this.dataGridView_Products.CurrentCell.RowIndex].id);
            }
        }

        private void button_PartDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_Products.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No row was selected");
                return;
            }

            List<Product> products = this.context.Product.ToList();
            List<Part> parts = this.context.Part.ToList();

            int removingIndex = this.dataGridView_Parts.CurrentCell.RowIndex;            
            int productId = (int)products[this.dataGridView_Products.CurrentCell.RowIndex].id;
            int removingId = (int)parts.Where(x => x.productId == productId).ToList()[removingIndex].id;
            Part removing = parts.Where(x => x.id == removingId).FirstOrDefault();
            this.context.Part.Remove(removing);
            this.context.SaveChanges();

            SetParts((int)products[this.dataGridView_Products.CurrentCell.RowIndex].id);
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
            this.groupBox_PartOverview.Text = $"{this.context.Product.Find(ProductId).name} parts overview";
            List<Part> parts = this.context.Part.Where(x => x.productId == ProductId).ToList();
            this.dataGridView_Parts.DataSource = parts;
        }
        #endregion
    }
}
