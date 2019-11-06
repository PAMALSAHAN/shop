namespace shop
{
    partial class shop
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
            this.headerText = new System.Windows.Forms.Label();
            this.storeItemList = new System.Windows.Forms.Label();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingListBox = new System.Windows.Forms.ListBox();
            this.storeItem = new System.Windows.Forms.Label();
            this.purchase = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.vendorList = new System.Windows.Forms.ListBox();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.storeProfit = new System.Windows.Forms.Label();
            this.storeValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(60, 5);
            this.headerText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(72, 39);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "shop ";
            // 
            // storeItemList
            // 
            this.storeItemList.AutoSize = true;
            this.storeItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeItemList.Location = new System.Drawing.Point(23, 54);
            this.storeItemList.Name = "storeItemList";
            this.storeItemList.Size = new System.Drawing.Size(86, 24);
            this.storeItemList.TabIndex = 1;
            this.storeItemList.Text = "Store List";
            this.storeItemList.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(27, 81);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(211, 160);
            this.ItemList.TabIndex = 2;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.Location = new System.Drawing.Point(263, 147);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(134, 39);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add to Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // shoppingListBox
            // 
            this.shoppingListBox.FormattingEnabled = true;
            this.shoppingListBox.Location = new System.Drawing.Point(413, 81);
            this.shoppingListBox.Name = "shoppingListBox";
            this.shoppingListBox.Size = new System.Drawing.Size(219, 160);
            this.shoppingListBox.TabIndex = 5;
            // 
            // storeItem
            // 
            this.storeItem.AutoSize = true;
            this.storeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeItem.Location = new System.Drawing.Point(409, 54);
            this.storeItem.Name = "storeItem";
            this.storeItem.Size = new System.Drawing.Size(103, 24);
            this.storeItem.TabIndex = 4;
            this.storeItem.Text = "Store Items";
            // 
            // purchase
            // 
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase.Location = new System.Drawing.Point(514, 247);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(118, 39);
            this.purchase.TabIndex = 6;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(413, 247);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(95, 39);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // vendorList
            // 
            this.vendorList.FormattingEnabled = true;
            this.vendorList.Location = new System.Drawing.Point(27, 337);
            this.vendorList.Name = "vendorList";
            this.vendorList.Size = new System.Drawing.Size(211, 160);
            this.vendorList.TabIndex = 9;
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorLabel.Location = new System.Drawing.Point(23, 300);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(101, 24);
            this.vendorLabel.TabIndex = 10;
            this.vendorLabel.Text = "vendor List";
            // 
            // storeProfit
            // 
            this.storeProfit.AutoSize = true;
            this.storeProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfit.Location = new System.Drawing.Point(339, 337);
            this.storeProfit.Name = "storeProfit";
            this.storeProfit.Size = new System.Drawing.Size(100, 24);
            this.storeProfit.TabIndex = 11;
            this.storeProfit.Text = "Store Profit";
            // 
            // storeValue
            // 
            this.storeValue.AutoSize = true;
            this.storeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeValue.Location = new System.Drawing.Point(500, 337);
            this.storeValue.Name = "storeValue";
            this.storeValue.Size = new System.Drawing.Size(55, 24);
            this.storeValue.TabIndex = 12;
            this.storeValue.Text = "$0.00";
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 509);
            this.Controls.Add(this.storeValue);
            this.Controls.Add(this.storeProfit);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.vendorList);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.shoppingListBox);
            this.Controls.Add(this.storeItem);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.storeItemList);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "shop";
            this.Text = "shop keeper";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Label storeItemList;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.ListBox shoppingListBox;
        private System.Windows.Forms.Label storeItem;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox vendorList;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.Label storeProfit;
        private System.Windows.Forms.Label storeValue;
    }
}

