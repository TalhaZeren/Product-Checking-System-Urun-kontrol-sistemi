namespace System.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProductList = new DataGridView();
            grupBoxCategory = new GroupBox();
            lblSelectCategory = new Label();
            cbxCategory = new ComboBox();
            grupBoxProduct = new GroupBox();
            txtProducts = new TextBox();
            lblSearchProduct = new Label();
            AddButton = new Button();
            lblCategory = new Label();
            lblPrice = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrice = new TextBox();
            txtProductNameAddBox = new TextBox();
            txtStockAmount = new TextBox();
            txtQuantityPerUnit = new TextBox();
            cbxCategoryIdAddBox = new ComboBox();
            lblProductName = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            updatebutton = new Button();
            txtUpdateQuantityPerUnit = new TextBox();
            txtUpdateStockAmount = new TextBox();
            txtUpdatePrice = new TextBox();
            txtUpdateProductName = new TextBox();
            cbxUpdateCategory = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            deleteButton = new Button();
            ((ComponentModel.ISupportInitialize)dgwProductList).BeginInit();
            grupBoxCategory.SuspendLayout();
            grupBoxProduct.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProductList
            // 
            dgwProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProductList.BackgroundColor = Color.PapayaWhip;
            dgwProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProductList.Location = new Point(12, 200);
            dgwProductList.Name = "dgwProductList";
            dgwProductList.RowHeadersWidth = 51;
            dgwProductList.RowTemplate.Height = 29;
            dgwProductList.Size = new Size(895, 285);
            dgwProductList.TabIndex = 0;
            dgwProductList.CellClick += dgwProductList_CellClick;
            // 
            // grupBoxCategory
            // 
            grupBoxCategory.Controls.Add(lblSelectCategory);
            grupBoxCategory.Controls.Add(cbxCategory);
            grupBoxCategory.Location = new Point(12, 12);
            grupBoxCategory.Name = "grupBoxCategory";
            grupBoxCategory.Size = new Size(895, 84);
            grupBoxCategory.TabIndex = 1;
            grupBoxCategory.TabStop = false;
            grupBoxCategory.Text = "Select Any Category";
            // 
            // lblSelectCategory
            // 
            lblSelectCategory.AutoSize = true;
            lblSelectCategory.Location = new Point(16, 50);
            lblSelectCategory.Name = "lblSelectCategory";
            lblSelectCategory.Size = new Size(69, 20);
            lblSelectCategory.TabIndex = 1;
            lblSelectCategory.Text = "Category";
            // 
            // cbxCategory
            // 
            cbxCategory.BackColor = Color.FromArgb(192, 192, 255);
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(97, 50);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(242, 28);
            cbxCategory.TabIndex = 0;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // grupBoxProduct
            // 
            grupBoxProduct.Controls.Add(txtProducts);
            grupBoxProduct.Controls.Add(lblSearchProduct);
            grupBoxProduct.Location = new Point(12, 103);
            grupBoxProduct.Name = "grupBoxProduct";
            grupBoxProduct.Size = new Size(895, 91);
            grupBoxProduct.TabIndex = 2;
            grupBoxProduct.TabStop = false;
            grupBoxProduct.Text = "Write Any Product Name";
            // 
            // txtProducts
            // 
            txtProducts.BackColor = SystemColors.InactiveBorder;
            txtProducts.Location = new Point(97, 51);
            txtProducts.Name = "txtProducts";
            txtProducts.Size = new Size(242, 27);
            txtProducts.TabIndex = 1;
            txtProducts.TextChanged += txtProducts_TextChanged;
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Location = new Point(16, 51);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(60, 20);
            lblSearchProduct.TabIndex = 0;
            lblSearchProduct.Text = "Product";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(0, 192, 0);
            AddButton.Location = new Point(623, 162);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(102, 29);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(45, 101);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(64, 162);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 34);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "Stock Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 105);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 8;
            label5.Text = "Quantity Per Unit";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.InactiveBorder;
            txtPrice.Location = new Point(138, 159);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(195, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtProductNameAddBox
            // 
            txtProductNameAddBox.BackColor = SystemColors.InactiveBorder;
            txtProductNameAddBox.Location = new Point(138, 34);
            txtProductNameAddBox.Name = "txtProductNameAddBox";
            txtProductNameAddBox.Size = new Size(195, 27);
            txtProductNameAddBox.TabIndex = 10;
            // 
            // txtStockAmount
            // 
            txtStockAmount.BackColor = SystemColors.InactiveBorder;
            txtStockAmount.Location = new Point(587, 34);
            txtStockAmount.Name = "txtStockAmount";
            txtStockAmount.Size = new Size(180, 27);
            txtStockAmount.TabIndex = 11;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.BackColor = SystemColors.InactiveBorder;
            txtQuantityPerUnit.Location = new Point(587, 102);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(180, 27);
            txtQuantityPerUnit.TabIndex = 12;
            // 
            // cbxCategoryIdAddBox
            // 
            cbxCategoryIdAddBox.BackColor = SystemColors.InactiveBorder;
            cbxCategoryIdAddBox.FormattingEnabled = true;
            cbxCategoryIdAddBox.Location = new Point(138, 98);
            cbxCategoryIdAddBox.Name = "cbxCategoryIdAddBox";
            cbxCategoryIdAddBox.Size = new Size(195, 28);
            cbxCategoryIdAddBox.TabIndex = 13;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(28, 37);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Product Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(cbxCategoryIdAddBox);
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Controls.Add(txtQuantityPerUnit);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(txtStockAmount);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(txtProductNameAddBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 555);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 197);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding Process";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(updatebutton);
            groupBox2.Controls.Add(txtUpdateQuantityPerUnit);
            groupBox2.Controls.Add(txtUpdateStockAmount);
            groupBox2.Controls.Add(txtUpdatePrice);
            groupBox2.Controls.Add(txtUpdateProductName);
            groupBox2.Controls.Add(cbxUpdateCategory);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 767);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(895, 226);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Updating Process";
            // 
            // updatebutton
            // 
            updatebutton.BackColor = Color.FromArgb(128, 128, 255);
            updatebutton.Location = new Point(623, 178);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(102, 29);
            updatebutton.TabIndex = 10;
            updatebutton.Text = "Update";
            updatebutton.UseVisualStyleBackColor = false;
            updatebutton.Click += updatebutton_Click;
            // 
            // txtUpdateQuantityPerUnit
            // 
            txtUpdateQuantityPerUnit.BackColor = SystemColors.InactiveBorder;
            txtUpdateQuantityPerUnit.Location = new Point(587, 114);
            txtUpdateQuantityPerUnit.Name = "txtUpdateQuantityPerUnit";
            txtUpdateQuantityPerUnit.Size = new Size(180, 27);
            txtUpdateQuantityPerUnit.TabIndex = 9;
            // 
            // txtUpdateStockAmount
            // 
            txtUpdateStockAmount.BackColor = SystemColors.InactiveBorder;
            txtUpdateStockAmount.Location = new Point(587, 44);
            txtUpdateStockAmount.Name = "txtUpdateStockAmount";
            txtUpdateStockAmount.Size = new Size(180, 27);
            txtUpdateStockAmount.TabIndex = 8;
            // 
            // txtUpdatePrice
            // 
            txtUpdatePrice.BackColor = SystemColors.InactiveBorder;
            txtUpdatePrice.Location = new Point(138, 179);
            txtUpdatePrice.Name = "txtUpdatePrice";
            txtUpdatePrice.Size = new Size(195, 27);
            txtUpdatePrice.TabIndex = 7;
            // 
            // txtUpdateProductName
            // 
            txtUpdateProductName.BackColor = SystemColors.InactiveBorder;
            txtUpdateProductName.Location = new Point(138, 44);
            txtUpdateProductName.Name = "txtUpdateProductName";
            txtUpdateProductName.Size = new Size(195, 27);
            txtUpdateProductName.TabIndex = 6;
            // 
            // cbxUpdateCategory
            // 
            cbxUpdateCategory.BackColor = SystemColors.InactiveCaption;
            cbxUpdateCategory.FormattingEnabled = true;
            cbxUpdateCategory.Location = new Point(138, 109);
            cbxUpdateCategory.Name = "cbxUpdateCategory";
            cbxUpdateCategory.Size = new Size(195, 28);
            cbxUpdateCategory.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(461, 117);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 4;
            label7.Text = "Quantity Per Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 44);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 3;
            label6.Text = "Stock Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 179);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 112);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 47);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Location = new Point(353, 509);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(211, 40);
            deleteButton.TabIndex = 16;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(919, 1018);
            Controls.Add(deleteButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grupBoxProduct);
            Controls.Add(grupBoxCategory);
            Controls.Add(dgwProductList);
            Name = "Form1";
            Text = "Product Checking System";
            Load += Form1_Load;
            ((ComponentModel.ISupportInitialize)dgwProductList).EndInit();
            grupBoxCategory.ResumeLayout(false);
            grupBoxCategory.PerformLayout();
            grupBoxProduct.ResumeLayout(false);
            grupBoxProduct.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dgwProductList;
        private GroupBox grupBoxCategory;
        private Label lblSelectCategory;
        private ComboBox cbxCategory;
        private GroupBox grupBoxProduct;
        private TextBox txtProducts;
        private Label lblSearchProduct;
        private Button AddButton;
        private Label lblCategory;
        private Label lblPrice;
        private Label label4;
        private Label label5;
        private TextBox txtPrice;
        private TextBox txtProductNameAddBox;
        private TextBox txtStockAmount;
        private TextBox txtQuantityPerUnit;
        private ComboBox cbxCategoryIdAddBox;
        private Label lblProductName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtUpdateQuantityPerUnit;
        private TextBox txtUpdateStockAmount;
        private TextBox txtUpdatePrice;
        private TextBox txtUpdateProductName;
        private ComboBox cbxUpdateCategory;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button updatebutton;
        private Button deleteButton;
    }
}