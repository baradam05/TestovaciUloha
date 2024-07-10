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
        
        public BindingList<ProductDto> Products = new BindingList<ProductDto>();
        public BindingList<Part> Parts = new BindingList<Part>();

        public MainForm()
        {
            InitializeComponent();

            button_refrech_Click(null, null);            
        }

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
            }
        }

        private void button_ProductEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_Products.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row was selected");
                return;
            }

            int selectedIndex = this.dataGridView_Products.SelectedRows[0].Index;
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
            }
        }

        private void button_ProductDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_Products.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row was selected");
                return;
            }

            int removingIndex = this.dataGridView_Products.SelectedRows[0].Index;
            int removingId = (int)this.Products[removingIndex].id;
            Product removing = this.context.Product.Find(removingId);
            this.context.Product.Remove(removing);

            List<Part> removingParts = this.context.Part.Where(x => x.productId == removing.id).ToList();
            this.context.Part.RemoveRange(removingParts);

            this.context.SaveChanges();
        }


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
            int removingId = (int)this.Parts[removingIndex].id;
            Part removing = this.context.Part.Find(removingId);
            this.context.Part.Remove(removing);
            this.context.SaveChanges();
        }


        private void button_refrech_Click(object sender, EventArgs e)
        {
            BindingList<ProductDto> products = new BindingList<ProductDto>();
            List<Product> productList = context.Product.ToList();
            BindingList<Product> contextProducts = new BindingList<Product>(productList);

            foreach (Product product in contextProducts)
            {
                ProductDto productDto = new ProductDto(product);
                productDto.Parts = context.Part.Where(x => x.productId == product.id).ToList().Count;

                products.Add(productDto);
            }

            this.Products = products;
            this.Parts = new BindingList<Part>(context.Part.ToList());

            this.dataGridView_Products.DataSource = Products;
            this.dataGridView_Parts.DataSource = Parts;
        }

        private void dataGridView_Parts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
