namespace HTQuanLyXe
{
    partial class FirstForm
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
            this.btnConnectFB = new System.Windows.Forms.Button();
            this.linklbTermCondition = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnectFB
            // 
            this.btnConnectFB.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectFB.Location = new System.Drawing.Point(196, 571);
            this.btnConnectFB.Name = "btnConnectFB";
            this.btnConnectFB.Size = new System.Drawing.Size(594, 60);
            this.btnConnectFB.TabIndex = 10;
            this.btnConnectFB.Text = "CONNECT WITH FACEBOOK";
            this.btnConnectFB.UseVisualStyleBackColor = true;
            this.btnConnectFB.Click += new System.EventHandler(this.btnConnectFB_Click);
            // 
            // linklbTermCondition
            // 
            this.linklbTermCondition.AutoSize = true;
            this.linklbTermCondition.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbTermCondition.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linklbTermCondition.Location = new System.Drawing.Point(404, 685);
            this.linklbTermCondition.Name = "linklbTermCondition";
            this.linklbTermCondition.Size = new System.Drawing.Size(197, 17);
            this.linklbTermCondition.TabIndex = 9;
            this.linklbTermCondition.TabStop = true;
            this.linklbTermCondition.Text = "Terms and Conditions.";
            this.linklbTermCondition.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbTermCondition_LinkClicked);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(576, 463);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(214, 59);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(196, 463);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 59);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSlogan.Font = new System.Drawing.Font("Microsoft New Tai Lue", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(44, 264);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(903, 44);
            this.lblSlogan.TabIndex = 6;
            this.lblSlogan.Text = "The most fulfilling take care your vehicles application for you.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::HTQuanLyXe.Properties.Resources.Phong_cách_hiện_đại_cho_người_phụ_nữ_hiện_đại__1_;
            this.pictureBox1.Location = new System.Drawing.Point(370, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HTQuanLyXe.Properties.Resources._5100e57acef179ce01ae73dbaec1d997;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 717);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConnectFB);
            this.Controls.Add(this.linklbTermCondition);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSlogan);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConnectFB;
        private System.Windows.Forms.LinkLabel linklbTermCondition;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Label lblSlogan;
    }
}