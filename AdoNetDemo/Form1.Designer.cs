namespace AdoNetDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxProductPrice = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.createBox = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.updateBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.tbxProductId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.createBox.SuspendLayout();
            this.updateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgwProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 142);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(1164, 197);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellDoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.IndianRed;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(78, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // tbxProductName
            // 
            this.tbxProductName.BackColor = System.Drawing.Color.IndianRed;
            this.tbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbxProductName.Location = new System.Drawing.Point(154, 32);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(188, 31);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.IndianRed;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnitPrice.Location = new System.Drawing.Point(49, 75);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(105, 25);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "UnitPrice:";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.BackColor = System.Drawing.Color.IndianRed;
            this.lblStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStockAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockAmount.Location = new System.Drawing.Point(13, 115);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(145, 25);
            this.lblStockAmount.TabIndex = 4;
            this.lblStockAmount.Text = "StockAmount:";
            // 
            // tbxProductPrice
            // 
            this.tbxProductPrice.BackColor = System.Drawing.Color.IndianRed;
            this.tbxProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductPrice.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbxProductPrice.Location = new System.Drawing.Point(154, 72);
            this.tbxProductPrice.Multiline = true;
            this.tbxProductPrice.Name = "tbxProductPrice";
            this.tbxProductPrice.Size = new System.Drawing.Size(188, 34);
            this.tbxProductPrice.TabIndex = 5;
            this.tbxProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.BackColor = System.Drawing.Color.IndianRed;
            this.tbxStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStockAmount.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbxStockAmount.Location = new System.Drawing.Point(154, 112);
            this.tbxStockAmount.Multiline = true;
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(188, 34);
            this.tbxStockAmount.TabIndex = 6;
            this.tbxStockAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createBox
            // 
            this.createBox.Controls.Add(this.btnAddProduct);
            this.createBox.Controls.Add(this.tbxStockAmount);
            this.createBox.Controls.Add(this.lblName);
            this.createBox.Controls.Add(this.tbxProductPrice);
            this.createBox.Controls.Add(this.tbxProductName);
            this.createBox.Controls.Add(this.lblStockAmount);
            this.createBox.Controls.Add(this.lblUnitPrice);
            this.createBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createBox.Location = new System.Drawing.Point(48, 345);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(528, 202);
            this.createBox.TabIndex = 7;
            this.createBox.TabStop = false;
            this.createBox.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("NSimSun", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(348, 108);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(126, 38);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // updateBox
            // 
            this.updateBox.Controls.Add(this.lblProductId);
            this.updateBox.Controls.Add(this.tbxProductId);
            this.updateBox.Controls.Add(this.button1);
            this.updateBox.Controls.Add(this.tbxStockAmountUpdate);
            this.updateBox.Controls.Add(this.lblNameUpdate);
            this.updateBox.Controls.Add(this.tbxUnitPriceUpdate);
            this.updateBox.Controls.Add(this.tbxNameUpdate);
            this.updateBox.Controls.Add(this.lblStockAmountUpdate);
            this.updateBox.Controls.Add(this.lblUnitPriceUpdate);
            this.updateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateBox.Location = new System.Drawing.Point(608, 345);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(532, 202);
            this.updateBox.TabIndex = 8;
            this.updateBox.TabStop = false;
            this.updateBox.Text = "Update a Product";
            this.updateBox.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("NSimSun", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(348, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.tbxStockAmountUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStockAmountUpdate.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(154, 151);
            this.tbxStockAmountUpdate.Multiline = true;
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(188, 34);
            this.tbxStockAmountUpdate.TabIndex = 6;
            this.tbxStockAmountUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.lblNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameUpdate.Location = new System.Drawing.Point(78, 74);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(74, 25);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name:";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.tbxUnitPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUnitPriceUpdate.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(154, 111);
            this.tbxUnitPriceUpdate.Multiline = true;
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(188, 34);
            this.tbxUnitPriceUpdate.TabIndex = 5;
            this.tbxUnitPriceUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.tbxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNameUpdate.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbxNameUpdate.Location = new System.Drawing.Point(154, 71);
            this.tbxNameUpdate.Multiline = true;
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(188, 34);
            this.tbxNameUpdate.TabIndex = 2;
            this.tbxNameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.lblStockAmountUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStockAmountUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(13, 154);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(145, 25);
            this.lblStockAmountUpdate.TabIndex = 4;
            this.lblStockAmountUpdate.Text = "StockAmount:";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.lblUnitPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPriceUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(49, 114);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(105, 25);
            this.lblUnitPriceUpdate.TabIndex = 3;
            this.lblUnitPriceUpdate.Text = "UnitPrice:";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.IndianRed;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductId.Location = new System.Drawing.Point(110, 35);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(38, 25);
            this.lblProductId.TabIndex = 8;
            this.lblProductId.Text = "ID:";
            // 
            // tbxProductId
            // 
            this.tbxProductId.BackColor = System.Drawing.Color.White;
            this.tbxProductId.Enabled = false;
            this.tbxProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductId.ForeColor = System.Drawing.Color.Black;
            this.tbxProductId.Location = new System.Drawing.Point(154, 32);
            this.tbxProductId.Multiline = true;
            this.tbxProductId.Name = "tbxProductId";
            this.tbxProductId.Size = new System.Drawing.Size(188, 34);
            this.tbxProductId.TabIndex = 9;
            this.tbxProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("NSimSun", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1041, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1198, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.createBox);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.createBox.ResumeLayout(false);
            this.createBox.PerformLayout();
            this.updateBox.ResumeLayout(false);
            this.updateBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxProductPrice;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.GroupBox createBox;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox updateBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox tbxProductId;
        private System.Windows.Forms.Button button2;
    }
}

