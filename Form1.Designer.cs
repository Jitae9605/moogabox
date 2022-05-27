
namespace moogabox
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnInquiry = new System.Windows.Forms.PictureBox();
			this.btnStore = new System.Windows.Forms.PictureBox();
			this.btnticket = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnInquiry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnStore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnticket)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(143, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(498, 94);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.btnInquiry);
			this.panel1.Controls.Add(this.btnStore);
			this.panel1.Controls.Add(this.btnticket);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(748, 395);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnInquiry
			// 
			this.btnInquiry.Image = ((System.Drawing.Image)(resources.GetObject("btnInquiry.Image")));
			this.btnInquiry.Location = new System.Drawing.Point(42, 124);
			this.btnInquiry.Name = "btnInquiry";
			this.btnInquiry.Size = new System.Drawing.Size(191, 237);
			this.btnInquiry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnInquiry.TabIndex = 7;
			this.btnInquiry.TabStop = false;
			this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
			// 
			// btnStore
			// 
			this.btnStore.Image = ((System.Drawing.Image)(resources.GetObject("btnStore.Image")));
			this.btnStore.Location = new System.Drawing.Point(515, 124);
			this.btnStore.Name = "btnStore";
			this.btnStore.Size = new System.Drawing.Size(191, 237);
			this.btnStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnStore.TabIndex = 6;
			this.btnStore.TabStop = false;
			this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
			// 
			// btnticket
			// 
			this.btnticket.Image = ((System.Drawing.Image)(resources.GetObject("btnticket.Image")));
			this.btnticket.Location = new System.Drawing.Point(279, 124);
			this.btnticket.Name = "btnticket";
			this.btnticket.Size = new System.Drawing.Size(191, 237);
			this.btnticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnticket.TabIndex = 5;
			this.btnticket.TabStop = false;
			this.btnticket.Click += new System.EventHandler(this.btnticket_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 395);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "메인메뉴";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnInquiry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnStore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnticket)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnticket;
        private System.Windows.Forms.PictureBox btnStore;
        private System.Windows.Forms.PictureBox btnInquiry;
    }
}