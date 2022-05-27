
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInquiry = new System.Windows.Forms.PictureBox();
            this.btnStore = new System.Windows.Forms.PictureBox();
            this.btnticket = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInquiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnticket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnInquiry);
            this.panel1.Controls.Add(this.btnStore);
            this.panel1.Controls.Add(this.btnticket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 661);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::moogabox.Properties.Resources.moogabox;
            this.pictureBox1.Location = new System.Drawing.Point(343, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnInquiry
            // 
            this.btnInquiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnInquiry.Image = ((System.Drawing.Image)(resources.GetObject("btnInquiry.Image")));
            this.btnInquiry.Location = new System.Drawing.Point(65, 180);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(250, 380);
            this.btnInquiry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInquiry.TabIndex = 7;
            this.btnInquiry.TabStop = false;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnStore
            // 
            this.btnStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnStore.Image = ((System.Drawing.Image)(resources.GetObject("btnStore.Image")));
            this.btnStore.Location = new System.Drawing.Point(705, 180);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(250, 380);
            this.btnStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStore.TabIndex = 6;
            this.btnStore.TabStop = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnticket
            // 
            this.btnticket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnticket.Image = ((System.Drawing.Image)(resources.GetObject("btnticket.Image")));
            this.btnticket.Location = new System.Drawing.Point(390, 180);
            this.btnticket.Name = "btnticket";
            this.btnticket.Size = new System.Drawing.Size(250, 380);
            this.btnticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnticket.TabIndex = 5;
            this.btnticket.TabStop = false;
            this.btnticket.Click += new System.EventHandler(this.btnticket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 661);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "메인메뉴";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInquiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnticket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnticket;
        private System.Windows.Forms.PictureBox btnStore;
        private System.Windows.Forms.PictureBox btnInquiry;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}