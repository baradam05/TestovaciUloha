using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestovaciUloha
{
    public partial class Part_InsertEdit_Form : Form
    {
        public Part_InsertEdit_Form()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox_Name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_Name, "Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_Name, "");

            }
        }

        private void textBox_Price_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Price.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_Price, "Required");
            }
            else if (!Regex.IsMatch(textBox_Price.Text, "^[0-9]+(\\.[0-9]+)?$"))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_Price, "Number must be in this format: 123.45");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_Price, "");
            }
        }
    }
}
