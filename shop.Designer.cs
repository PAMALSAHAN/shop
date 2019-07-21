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
            this.button1 = new System.Windows.Forms.Button();
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
            this.ItemList.Size = new System.Drawing.Size(219, 212);
            this.ItemList.TabIndex = 2;
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
            // 
            // shoppingListBox
            // 
            this.shoppingListBox.FormattingEnabled = true;
            this.shoppingListBox.Location = new System.Drawing.Point(413, 81);
            this.shoppingListBox.Name = "shoppingListBox";
            this.shoppingListBox.Size = new System.Drawing.Size(219, 212);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(498, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 509);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

