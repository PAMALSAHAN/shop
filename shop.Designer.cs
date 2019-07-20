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
            this.storeItemList.Location = new System.Drawing.Point(12, 55);
            this.storeItemList.Name = "storeItemList";
            this.storeItemList.Size = new System.Drawing.Size(86, 24);
            this.storeItemList.TabIndex = 1;
            this.storeItemList.Text = "Store List";
            this.storeItemList.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(20, 85);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(165, 160);
            this.ItemList.TabIndex = 2;
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 290);
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
    }
}

