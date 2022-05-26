
namespace moogabox
{
    partial class Form6
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
			this.lbTime = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbSitnum = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtMovie = new System.Windows.Forms.TextBox();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtHallNum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSeatNum = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbMovie = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
			this.lbTime.ForeColor = System.Drawing.Color.White;
			this.lbTime.Location = new System.Drawing.Point(170, 348);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(59, 32);
			this.lbTime.TabIndex = 7;
			this.lbTime.Text = "시간";
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(170, 311);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(59, 32);
			this.lbTitle.TabIndex = 6;
			this.lbTitle.Text = "영화";
			// 
			// lbSitnum
			// 
			this.lbSitnum.AutoSize = true;
			this.lbSitnum.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
			this.lbSitnum.ForeColor = System.Drawing.Color.White;
			this.lbSitnum.Location = new System.Drawing.Point(148, 385);
			this.lbSitnum.Name = "lbSitnum";
			this.lbSitnum.Size = new System.Drawing.Size(81, 32);
			this.lbSitnum.TabIndex = 8;
			this.lbSitnum.Text = "상영관";
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Firebrick;
			this.btnOK.FlatAppearance.BorderSize = 0;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOK.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
			this.btnOK.ForeColor = System.Drawing.Color.White;
			this.btnOK.Location = new System.Drawing.Point(235, 474);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(104, 45);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "확인";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Gray;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(368, 474);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(104, 45);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "취소";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtMovie
			// 
			this.txtMovie.BackColor = System.Drawing.Color.White;
			this.txtMovie.CausesValidation = false;
			this.txtMovie.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.txtMovie.Location = new System.Drawing.Point(235, 317);
			this.txtMovie.Name = "txtMovie";
			this.txtMovie.Size = new System.Drawing.Size(237, 24);
			this.txtMovie.TabIndex = 11;
			// 
			// txtTime
			// 
			this.txtTime.CausesValidation = false;
			this.txtTime.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.txtTime.Location = new System.Drawing.Point(235, 353);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(237, 24);
			this.txtTime.TabIndex = 11;
			// 
			// txtHallNum
			// 
			this.txtHallNum.CausesValidation = false;
			this.txtHallNum.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.txtHallNum.Location = new System.Drawing.Point(235, 389);
			this.txtHallNum.Name = "txtHallNum";
			this.txtHallNum.Size = new System.Drawing.Size(237, 24);
			this.txtHallNum.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(170, 422);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 32);
			this.label1.TabIndex = 8;
			this.label1.Text = "좌석";
			// 
			// txtSeatNum
			// 
			this.txtSeatNum.CausesValidation = false;
			this.txtSeatNum.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.txtSeatNum.Location = new System.Drawing.Point(235, 426);
			this.txtSeatNum.Name = "txtSeatNum";
			this.txtSeatNum.Size = new System.Drawing.Size(237, 24);
			this.txtSeatNum.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::moogabox.Properties.Resources.KakaoTalk_20220525_141938370;
			this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(195, 115);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// pbMovie
			// 
			this.pbMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pbMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbMovie.Location = new System.Drawing.Point(235, 27);
			this.pbMovie.Margin = new System.Windows.Forms.Padding(5);
			this.pbMovie.Name = "pbMovie";
			this.pbMovie.Size = new System.Drawing.Size(237, 270);
			this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbMovie.TabIndex = 5;
			this.pbMovie.TabStop = false;
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(711, 540);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtSeatNum);
			this.Controls.Add(this.txtHallNum);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.txtMovie);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbSitnum);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pbMovie);
			this.Name = "Form6";
			this.Text = "선택 확인";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
			this.Load += new System.EventHandler(this.Form6_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSitnum;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtMovie;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.TextBox txtHallNum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSeatNum;
		private System.Windows.Forms.PictureBox pbMovie;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}