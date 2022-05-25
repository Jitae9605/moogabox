
namespace moogabox
{
    partial class ManagerForm3
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
            this.Btn_StoreStock = new System.Windows.Forms.Button();
            this.Btn_WarehouseStock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_StoreStock
            // 
            this.Btn_StoreStock.Location = new System.Drawing.Point(72, 131);
            this.Btn_StoreStock.Name = "Btn_StoreStock";
            this.Btn_StoreStock.Size = new System.Drawing.Size(165, 149);
            this.Btn_StoreStock.TabIndex = 0;
            this.Btn_StoreStock.Text = "매장 재고";
            this.Btn_StoreStock.UseVisualStyleBackColor = true;
            this.Btn_StoreStock.Click += new System.EventHandler(this.Btn_StoreStock_Click);
            // 
            // Btn_WarehouseStock
            // 
            this.Btn_WarehouseStock.Location = new System.Drawing.Point(328, 131);
            this.Btn_WarehouseStock.Name = "Btn_WarehouseStock";
            this.Btn_WarehouseStock.Size = new System.Drawing.Size(165, 149);
            this.Btn_WarehouseStock.TabIndex = 1;
            this.Btn_WarehouseStock.Text = "창고 재고";
            this.Btn_WarehouseStock.UseVisualStyleBackColor = true;
            this.Btn_WarehouseStock.Click += new System.EventHandler(this.Btn_WarehouseStock_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "뒤로가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_WarehouseStock);
            this.Controls.Add(this.Btn_StoreStock);
            this.Name = "ManagerForm3";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_StoreStock;
        private System.Windows.Forms.Button Btn_WarehouseStock;
        private System.Windows.Forms.Button button1;
    }
}