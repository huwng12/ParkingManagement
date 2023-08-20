namespace HTQuanLyXe
{
    partial class contactForm
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
            this.buttonYOU = new System.Windows.Forms.Button();
            this.buttonINS = new System.Windows.Forms.Button();
            this.buttonFB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonYOU
            // 
            this.buttonYOU.BackColor = System.Drawing.Color.White;
            this.buttonYOU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonYOU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYOU.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYOU.Image = global::HTQuanLyXe.Properties.Resources.icons8_youtube_100;
            this.buttonYOU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYOU.Location = new System.Drawing.Point(612, 64);
            this.buttonYOU.Name = "buttonYOU";
            this.buttonYOU.Size = new System.Drawing.Size(259, 137);
            this.buttonYOU.TabIndex = 21;
            this.buttonYOU.Text = "Youtube";
            this.buttonYOU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYOU.UseVisualStyleBackColor = false;
            this.buttonYOU.Click += new System.EventHandler(this.buttonYOU_Click);
            // 
            // buttonINS
            // 
            this.buttonINS.BackColor = System.Drawing.Color.White;
            this.buttonINS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonINS.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonINS.Image = global::HTQuanLyXe.Properties.Resources.icons8_instagram_100;
            this.buttonINS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonINS.Location = new System.Drawing.Point(310, 64);
            this.buttonINS.Name = "buttonINS";
            this.buttonINS.Size = new System.Drawing.Size(259, 137);
            this.buttonINS.TabIndex = 20;
            this.buttonINS.Text = "Instagram";
            this.buttonINS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonINS.UseVisualStyleBackColor = false;
            this.buttonINS.Click += new System.EventHandler(this.buttonINS_Click);
            // 
            // buttonFB
            // 
            this.buttonFB.BackColor = System.Drawing.Color.White;
            this.buttonFB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFB.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFB.Image = global::HTQuanLyXe.Properties.Resources.icons8_facebook_100;
            this.buttonFB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFB.Location = new System.Drawing.Point(12, 64);
            this.buttonFB.Name = "buttonFB";
            this.buttonFB.Size = new System.Drawing.Size(259, 137);
            this.buttonFB.TabIndex = 19;
            this.buttonFB.Text = "Facebook";
            this.buttonFB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFB.UseVisualStyleBackColor = false;
            this.buttonFB.Click += new System.EventHandler(this.buttonFB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kết nối với chúng tôi ngay nào!";
            // 
            // contactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(883, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonYOU);
            this.Controls.Add(this.buttonINS);
            this.Controls.Add(this.buttonFB);
            this.Name = "contactForm";
            this.Text = "contactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFB;
        private System.Windows.Forms.Button buttonINS;
        private System.Windows.Forms.Button buttonYOU;
        private System.Windows.Forms.Label label1;
    }
}