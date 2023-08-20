namespace HTQuanLyXe.GUI.ADMIN
{
    partial class admin
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
            this.pnadmin = new System.Windows.Forms.Panel();
            this.chao = new System.Windows.Forms.Label();
            this.loainv = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.btdanhsachnhanvien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnadmin
            // 
            this.pnadmin.BackColor = System.Drawing.SystemColors.Control;
            this.pnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnadmin.Location = new System.Drawing.Point(241, 34);
            this.pnadmin.Margin = new System.Windows.Forms.Padding(4);
            this.pnadmin.Name = "pnadmin";
            this.pnadmin.Size = new System.Drawing.Size(765, 437);
            this.pnadmin.TabIndex = 0;
            // 
            // chao
            // 
            this.chao.AutoSize = true;
            this.chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chao.Location = new System.Drawing.Point(236, 5);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(83, 31);
            this.chao.TabIndex = 2;
            this.chao.Text = "Chào";
            // 
            // loainv
            // 
            this.loainv.AutoSize = true;
            this.loainv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loainv.Location = new System.Drawing.Point(642, 6);
            this.loainv.Name = "loainv";
            this.loainv.Size = new System.Drawing.Size(83, 31);
            this.loainv.TabIndex = 3;
            this.loainv.Text = "Chào";
            // 
            // logout_btn
            // 
            this.logout_btn.AllowDrop = true;
            this.logout_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Image = global::HTQuanLyXe.Properties.Resources.icons8_sign_out_64;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(-3, 292);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(245, 69);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Đăng Xuất";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // btdanhsachnhanvien
            // 
            this.btdanhsachnhanvien.BackColor = System.Drawing.Color.SaddleBrown;
            this.btdanhsachnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdanhsachnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdanhsachnhanvien.Image = global::HTQuanLyXe.Properties.Resources.icons8_user_80;
            this.btdanhsachnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdanhsachnhanvien.Location = new System.Drawing.Point(-3, 183);
            this.btdanhsachnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.btdanhsachnhanvien.Name = "btdanhsachnhanvien";
            this.btdanhsachnhanvien.Size = new System.Drawing.Size(245, 69);
            this.btdanhsachnhanvien.TabIndex = 1;
            this.btdanhsachnhanvien.Text = "Nhân Viên";
            this.btdanhsachnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdanhsachnhanvien.UseVisualStyleBackColor = false;
            this.btdanhsachnhanvien.Click += new System.EventHandler(this.btdanhsachnhanvien_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1005, 471);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.loainv);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.btdanhsachnhanvien);
            this.Controls.Add(this.pnadmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnadmin;
        private System.Windows.Forms.Button btdanhsachnhanvien;
        private System.Windows.Forms.Label chao;
        private System.Windows.Forms.Label loainv;
        private System.Windows.Forms.Button logout_btn;
    }
}