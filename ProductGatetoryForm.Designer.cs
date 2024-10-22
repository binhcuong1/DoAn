namespace QuanLyCuaHang
{
    partial class ProductGatetoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGatetoryForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductGatetoryOfForm = new System.Windows.Forms.DataGridView();
            this.btnFilterDataOfProductGate = new System.Windows.Forms.Button();
            this.txtSearchIDorNameOfProduct = new System.Windows.Forms.TextBox();
            this.btnResetGrid = new System.Windows.Forms.Button();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnOpenProductUC = new System.Windows.Forms.Button();
            this.lblOfIDorNameProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductGatetoryOfForm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBackToHomePage_Click);
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddProduct.BackgroundImage")));
            this.pnlAddProduct.Location = new System.Drawing.Point(1865, 73);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(800, 500);
            this.pnlAddProduct.TabIndex = 6;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thể Loại";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nhà Cung Cấp";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // dgvProductGatetoryOfForm
            // 
            this.dgvProductGatetoryOfForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductGatetoryOfForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductGatetoryOfForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProductGatetoryOfForm.Location = new System.Drawing.Point(636, 89);
            this.dgvProductGatetoryOfForm.Name = "dgvProductGatetoryOfForm";
            this.dgvProductGatetoryOfForm.RowHeadersWidth = 82;
            this.dgvProductGatetoryOfForm.RowTemplate.Height = 33;
            this.dgvProductGatetoryOfForm.Size = new System.Drawing.Size(964, 674);
            this.dgvProductGatetoryOfForm.TabIndex = 0;
            this.dgvProductGatetoryOfForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductGatetoryOfForm_CellContentClick);
            // 
            // btnFilterDataOfProductGate
            // 
            this.btnFilterDataOfProductGate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFilterDataOfProductGate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilterDataOfProductGate.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterDataOfProductGate.Location = new System.Drawing.Point(415, 278);
            this.btnFilterDataOfProductGate.Name = "btnFilterDataOfProductGate";
            this.btnFilterDataOfProductGate.Size = new System.Drawing.Size(172, 49);
            this.btnFilterDataOfProductGate.TabIndex = 3;
            this.btnFilterDataOfProductGate.Text = "Lọc";
            this.btnFilterDataOfProductGate.UseVisualStyleBackColor = false;
            this.btnFilterDataOfProductGate.Click += new System.EventHandler(this.BtnFilterDataOfProductGate_Click);
            // 
            // txtSearchIDorNameOfProduct
            // 
            this.txtSearchIDorNameOfProduct.Location = new System.Drawing.Point(169, 107);
            this.txtSearchIDorNameOfProduct.Multiline = true;
            this.txtSearchIDorNameOfProduct.Name = "txtSearchIDorNameOfProduct";
            this.txtSearchIDorNameOfProduct.Size = new System.Drawing.Size(228, 49);
            this.txtSearchIDorNameOfProduct.TabIndex = 1;
            // 
            // btnResetGrid
            // 
            this.btnResetGrid.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnResetGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetGrid.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGrid.Location = new System.Drawing.Point(225, 278);
            this.btnResetGrid.Name = "btnResetGrid";
            this.btnResetGrid.Size = new System.Drawing.Size(172, 49);
            this.btnResetGrid.TabIndex = 3;
            this.btnResetGrid.Text = "Làm Mới";
            this.btnResetGrid.UseVisualStyleBackColor = false;
            this.btnResetGrid.Click += new System.EventHandler(this.btnResetGrid_Click);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(291, 198);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(275, 33);
            this.cmbSupplier.TabIndex = 5;
            // 
            // btnOpenProductUC
            // 
            this.btnOpenProductUC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOpenProductUC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenProductUC.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProductUC.Location = new System.Drawing.Point(356, 458);
            this.btnOpenProductUC.Name = "btnOpenProductUC";
            this.btnOpenProductUC.Size = new System.Drawing.Size(248, 53);
            this.btnOpenProductUC.TabIndex = 3;
            this.btnOpenProductUC.Text = "Thêm Sản Phẩm";
            this.btnOpenProductUC.UseVisualStyleBackColor = false;
            this.btnOpenProductUC.Click += new System.EventHandler(this.btnOpenProductUC_Click);
            // 
            // lblOfIDorNameProduct
            // 
            this.lblOfIDorNameProduct.AutoSize = true;
            this.lblOfIDorNameProduct.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfIDorNameProduct.Location = new System.Drawing.Point(118, 63);
            this.lblOfIDorNameProduct.Name = "lblOfIDorNameProduct";
            this.lblOfIDorNameProduct.Size = new System.Drawing.Size(346, 31);
            this.lblOfIDorNameProduct.TabIndex = 2;
            this.lblOfIDorNameProduct.Text = "Nhập mã hoặc tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn nhà cung cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblOfIDorNameProduct);
            this.groupBox1.Controls.Add(this.btnOpenProductUC);
            this.groupBox1.Controls.Add(this.cmbSupplier);
            this.groupBox1.Controls.Add(this.btnResetGrid);
            this.groupBox1.Controls.Add(this.txtSearchIDorNameOfProduct);
            this.groupBox1.Controls.Add(this.btnFilterDataOfProductGate);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 536);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ProductGatetoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlAddProduct);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvProductGatetoryOfForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductGatetoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Sản Phẩm";
            this.Load += new System.EventHandler(this.ProductGatetoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductGatetoryOfForm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlAddProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvProductGatetoryOfForm;
        private System.Windows.Forms.Button btnFilterDataOfProductGate;
        private System.Windows.Forms.TextBox txtSearchIDorNameOfProduct;
        private System.Windows.Forms.Button btnResetGrid;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnOpenProductUC;
        private System.Windows.Forms.Label lblOfIDorNameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}