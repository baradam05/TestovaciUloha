namespace TestovaciUloha
{
    partial class Product_InsertEdit_Form
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
            components = new System.ComponentModel.Container();
            groupBox_Product = new GroupBox();
            textBox_Description = new TextBox();
            textBox_Price = new TextBox();
            textBox_Note = new TextBox();
            textBox_Name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_Cancel = new Button();
            button_done = new Button();
            errorProvider = new ErrorProvider(components);
            groupBox_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Product
            // 
            groupBox_Product.Controls.Add(textBox_Description);
            groupBox_Product.Controls.Add(textBox_Price);
            groupBox_Product.Controls.Add(textBox_Note);
            groupBox_Product.Controls.Add(textBox_Name);
            groupBox_Product.Controls.Add(label4);
            groupBox_Product.Controls.Add(label3);
            groupBox_Product.Controls.Add(label2);
            groupBox_Product.Controls.Add(label1);
            groupBox_Product.Location = new Point(12, 12);
            groupBox_Product.Name = "groupBox_Product";
            groupBox_Product.Size = new Size(475, 171);
            groupBox_Product.TabIndex = 0;
            groupBox_Product.TabStop = false;
            groupBox_Product.Text = "Product";
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(79, 50);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(385, 80);
            textBox_Description.TabIndex = 7;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(79, 136);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(100, 23);
            textBox_Price.TabIndex = 6;
            textBox_Price.Validating += textBox_Price_Validating;
            // 
            // textBox_Note
            // 
            textBox_Note.Location = new Point(364, 136);
            textBox_Note.Name = "textBox_Note";
            textBox_Note.Size = new Size(100, 23);
            textBox_Note.TabIndex = 5;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(79, 21);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(100, 23);
            textBox_Name.TabIndex = 4;
            textBox_Name.Validating += textBox_Name_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 139);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 139);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(331, 189);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_done
            // 
            button_done.Location = new Point(412, 189);
            button_done.Name = "button_done";
            button_done.Size = new Size(75, 23);
            button_done.TabIndex = 2;
            button_done.Text = "Done";
            button_done.UseVisualStyleBackColor = true;
            button_done.Click += button_done_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Product_InsertEdit_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 222);
            Controls.Add(button_done);
            Controls.Add(button_Cancel);
            Controls.Add(groupBox_Product);
            Name = "Product_InsertEdit_Form";
            Text = "Product_InsertEdit_Form";
            groupBox_Product.ResumeLayout(false);
            groupBox_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Product;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button_Cancel;
        private Button button_done;
        public TextBox textBox_Description;
        public TextBox textBox_Price;
        public TextBox textBox_Note;
        public TextBox textBox_Name;
        private ErrorProvider errorProvider;
    }
}