namespace TestovaciUloha
{
    partial class Part_InsertEdit_Form
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
            groupBox_Part = new GroupBox();
            comboBox_Product = new ComboBox();
            label4 = new Label();
            textBox_Description = new TextBox();
            textBox_Price = new TextBox();
            textBox_Name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_done = new Button();
            button_Cancel = new Button();
            errorProvider = new ErrorProvider(components);
            groupBox_Part.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Part
            // 
            groupBox_Part.Controls.Add(comboBox_Product);
            groupBox_Part.Controls.Add(label4);
            groupBox_Part.Controls.Add(textBox_Description);
            groupBox_Part.Controls.Add(textBox_Price);
            groupBox_Part.Controls.Add(textBox_Name);
            groupBox_Part.Controls.Add(label3);
            groupBox_Part.Controls.Add(label2);
            groupBox_Part.Controls.Add(label1);
            groupBox_Part.Location = new Point(12, 12);
            groupBox_Part.Name = "groupBox_Part";
            groupBox_Part.Size = new Size(475, 165);
            groupBox_Part.TabIndex = 1;
            groupBox_Part.TabStop = false;
            groupBox_Part.Text = "Part";
            // 
            // comboBox_Product
            // 
            comboBox_Product.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Product.FormattingEnabled = true;
            comboBox_Product.Location = new Point(343, 131);
            comboBox_Product.Name = "comboBox_Product";
            comboBox_Product.Size = new Size(121, 23);
            comboBox_Product.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 134);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Product";
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(79, 45);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(385, 80);
            textBox_Description.TabIndex = 7;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(79, 131);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(100, 23);
            textBox_Price.TabIndex = 9;
            textBox_Price.Validating += textBox_Price_Validating;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(79, 16);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(100, 23);
            textBox_Name.TabIndex = 5;
            textBox_Name.Validating += textBox_Name_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 134);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // button_done
            // 
            button_done.Location = new Point(412, 183);
            button_done.Name = "button_done";
            button_done.Size = new Size(75, 23);
            button_done.TabIndex = 11;
            button_done.Text = "Done";
            button_done.UseVisualStyleBackColor = true;
            button_done.Click += button_done_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(331, 183);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 10;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Part_InsertEdit_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 217);
            Controls.Add(button_done);
            Controls.Add(button_Cancel);
            Controls.Add(groupBox_Part);
            Name = "Part_InsertEdit_Form";
            Text = "Part_InsertEdit_Form";
            groupBox_Part.ResumeLayout(false);
            groupBox_Part.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox_Part;
        public TextBox textBox_Description;
        public TextBox textBox_Price;
        public TextBox textBox_Name;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_done;
        private Button button_Cancel;
        private Label label4;
        public ComboBox comboBox_Product;
        private ErrorProvider errorProvider;
    }
}