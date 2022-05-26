
namespace moogabox
{
    partial class ManagerForm1
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
            this.Btn_Sale = new System.Windows.Forms.Button();
            this.Btn_Stock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Sale
            // 
            this.Btn_Sale.Location = new System.Drawing.Point(72, 131);
            this.Btn_Sale.Name = "Btn_Sale";
            this.Btn_Sale.Size = new System.Drawing.Size(165, 149);
            this.Btn_Sale.TabIndex = 0;
            this.Btn_Sale.Text = "매출관리";
            this.Btn_Sale.UseVisualStyleBackColor = true;
            // 
            // Btn_Stock
            // 
            this.Btn_Stock.Location = new System.Drawing.Point(328, 131);
            this.Btn_Stock.Name = "Btn_Stock";
            this.Btn_Stock.Size = new System.Drawing.Size(165, 149);
            this.Btn_Stock.TabIndex = 1;
            this.Btn_Stock.Text = "재고관리";
            this.Btn_Stock.UseVisualStyleBackColor = true;
            this.Btn_Stock.Click += new System.EventHandler(this.Btn_Stock_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "뒤로가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Stock);
            this.Controls.Add(this.Btn_Sale);
            this.Name = "ManagerForm1";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sale;
        private System.Windows.Forms.Button Btn_Stock;
        private System.Windows.Forms.Button button1;
    }
}