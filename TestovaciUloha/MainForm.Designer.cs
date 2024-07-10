namespace TestovaciUloha
{
    partial class MainForm
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
            dataGridView_Products = new DataGridView();
            groupBox_ProductOverview = new GroupBox();
            button_ProductAdd = new Button();
            button_ProductEdit = new Button();
            button_ProductDelete = new Button();
            dataGridView_Parts = new DataGridView();
            groupBox_PartOverview = new GroupBox();
            button_PartDelete = new Button();
            button_PartAdd = new Button();
            button_PartEdit = new Button();
            button_refrech = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Products).BeginInit();
            groupBox_ProductOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Parts).BeginInit();
            groupBox_PartOverview.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Products
            // 
            dataGridView_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Products.Location = new Point(6, 22);
            dataGridView_Products.Name = "dataGridView_Products";
            dataGridView_Products.Size = new Size(541, 374);
            dataGridView_Products.TabIndex = 0;
            // 
            // groupBox_ProductOverview
            // 
            groupBox_ProductOverview.Controls.Add(dataGridView_Products);
            groupBox_ProductOverview.Controls.Add(button_ProductAdd);
            groupBox_ProductOverview.Controls.Add(button_ProductEdit);
            groupBox_ProductOverview.Controls.Add(button_ProductDelete);
            groupBox_ProductOverview.Location = new Point(12, 12);
            groupBox_ProductOverview.Name = "groupBox_ProductOverview";
            groupBox_ProductOverview.Size = new Size(558, 442);
            groupBox_ProductOverview.TabIndex = 1;
            groupBox_ProductOverview.TabStop = false;
            groupBox_ProductOverview.Text = "Product overview";
            // 
            // button_ProductAdd
            // 
            button_ProductAdd.Location = new Point(6, 408);
            button_ProductAdd.Name = "button_ProductAdd";
            button_ProductAdd.Size = new Size(75, 23);
            button_ProductAdd.TabIndex = 3;
            button_ProductAdd.Text = "Add";
            button_ProductAdd.UseVisualStyleBackColor = true;
            button_ProductAdd.Click += button_ProductAdd_Click;
            // 
            // button_ProductEdit
            // 
            button_ProductEdit.Location = new Point(87, 408);
            button_ProductEdit.Name = "button_ProductEdit";
            button_ProductEdit.Size = new Size(75, 23);
            button_ProductEdit.TabIndex = 4;
            button_ProductEdit.Text = "Edit";
            button_ProductEdit.UseVisualStyleBackColor = true;
            button_ProductEdit.Click += button_ProductEdit_Click;
            // 
            // button_ProductDelete
            // 
            button_ProductDelete.Location = new Point(168, 408);
            button_ProductDelete.Name = "button_ProductDelete";
            button_ProductDelete.Size = new Size(75, 23);
            button_ProductDelete.TabIndex = 5;
            button_ProductDelete.Text = "Delete";
            button_ProductDelete.UseVisualStyleBackColor = true;
            button_ProductDelete.Click += button_ProductDelete_Click;
            // 
            // dataGridView_Parts
            // 
            dataGridView_Parts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Parts.Location = new Point(6, 22);
            dataGridView_Parts.Name = "dataGridView_Parts";
            dataGridView_Parts.Size = new Size(442, 374);
            dataGridView_Parts.TabIndex = 0;
            dataGridView_Parts.CellContentClick += dataGridView_Parts_CellContentClick;
            // 
            // groupBox_PartOverview
            // 
            groupBox_PartOverview.Controls.Add(dataGridView_Parts);
            groupBox_PartOverview.Controls.Add(button_PartDelete);
            groupBox_PartOverview.Controls.Add(button_PartAdd);
            groupBox_PartOverview.Controls.Add(button_PartEdit);
            groupBox_PartOverview.Location = new Point(576, 12);
            groupBox_PartOverview.Name = "groupBox_PartOverview";
            groupBox_PartOverview.Size = new Size(458, 442);
            groupBox_PartOverview.TabIndex = 2;
            groupBox_PartOverview.TabStop = false;
            groupBox_PartOverview.Text = "Part overview";
            // 
            // button_PartDelete
            // 
            button_PartDelete.Location = new Point(168, 408);
            button_PartDelete.Name = "button_PartDelete";
            button_PartDelete.Size = new Size(75, 23);
            button_PartDelete.TabIndex = 8;
            button_PartDelete.Text = "Delete";
            button_PartDelete.UseVisualStyleBackColor = true;
            button_PartDelete.Click += button_PartDelete_Click;
            // 
            // button_PartAdd
            // 
            button_PartAdd.Location = new Point(6, 408);
            button_PartAdd.Name = "button_PartAdd";
            button_PartAdd.Size = new Size(75, 23);
            button_PartAdd.TabIndex = 6;
            button_PartAdd.Text = "Add";
            button_PartAdd.UseVisualStyleBackColor = true;
            button_PartAdd.Click += button_PartAdd_Click;
            // 
            // button_PartEdit
            // 
            button_PartEdit.Location = new Point(87, 408);
            button_PartEdit.Name = "button_PartEdit";
            button_PartEdit.Size = new Size(75, 23);
            button_PartEdit.TabIndex = 7;
            button_PartEdit.Text = "Edit";
            button_PartEdit.UseVisualStyleBackColor = true;
            button_PartEdit.Click += button_PartEdit_Click;
            // 
            // button_refrech
            // 
            button_refrech.Location = new Point(12, 460);
            button_refrech.Name = "button_refrech";
            button_refrech.Size = new Size(75, 23);
            button_refrech.TabIndex = 9;
            button_refrech.Text = "Refrech";
            button_refrech.UseVisualStyleBackColor = true;
            button_refrech.Click += button_refrech_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 495);
            Controls.Add(button_refrech);
            Controls.Add(groupBox_PartOverview);
            Controls.Add(groupBox_ProductOverview);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Products).EndInit();
            groupBox_ProductOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Parts).EndInit();
            groupBox_PartOverview.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Products;
        private GroupBox groupBox_ProductOverview;
        private DataGridView dataGridView_Parts;
        private GroupBox groupBox_PartOverview;
        private Button button_ProductAdd;
        private Button button_ProductEdit;
        private Button button_ProductDelete;
        private Button button_PartDelete;
        private Button button_PartEdit;
        private Button button_PartAdd;
        private Button button_refrech;
    }
}