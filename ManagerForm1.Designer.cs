
namespace moogabox
{
    partial class ManagerForm1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Stock = new System.Windows.Forms.Button();
            this.Btn_Sale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Stock
            // 
            this.Btn_Stock.Location = new System.Drawing.Point(338, 120);
            this.Btn_Stock.Name = "Btn_Stock";
            this.Btn_Stock.Size = new System.Drawing.Size(165, 149);
            this.Btn_Stock.TabIndex = 3;
            this.Btn_Stock.Text = "재고관리";
            this.Btn_Stock.UseVisualStyleBackColor = true;
            // 
            // Btn_Sale
            // 
            this.Btn_Sale.Location = new System.Drawing.Point(82, 120);
            this.Btn_Sale.Name = "Btn_Sale";
            this.Btn_Sale.Size = new System.Drawing.Size(165, 149);
            this.Btn_Sale.TabIndex = 2;
            this.Btn_Sale.Text = "매출관리";
            this.Btn_Sale.UseVisualStyleBackColor = true;
            this.Btn_Sale.Click += new System.EventHandler(this.Btn_Sale_Click);
            // 
            // ManagerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.Btn_Stock);
            this.Controls.Add(this.Btn_Sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManagerForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManagerForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Stock;
        private System.Windows.Forms.Button Btn_Sale;
    }
}

