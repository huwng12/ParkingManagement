namespace HTQuanLyXe
{
    partial class ChiaCaForm
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
            this.dataGridViewChiaCaNV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSaveWord = new System.Windows.Forms.Button();
            this.radioButtonSang = new System.Windows.Forms.RadioButton();
            this.radioButtonToi = new System.Windows.Forms.RadioButton();
            this.radioButtonTrua = new System.Windows.Forms.RadioButton();
            this.buttonChiaCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiaCaNV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewChiaCaNV
            // 
            this.dataGridViewChiaCaNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiaCaNV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChiaCaNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiaCaNV.Location = new System.Drawing.Point(12, 196);
            this.dataGridViewChiaCaNV.Name = "dataGridViewChiaCaNV";
            this.dataGridViewChiaCaNV.RowHeadersWidth = 51;
            this.dataGridViewChiaCaNV.RowTemplate.Height = 24;
            this.dataGridViewChiaCaNV.Size = new System.Drawing.Size(1177, 338);
            this.dataGridViewChiaCaNV.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 129);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radioButtonSang);
            this.panel1.Controls.Add(this.radioButtonToi);
            this.panel1.Controls.Add(this.radioButtonTrua);
            this.panel1.Location = new System.Drawing.Point(23, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 97);
            this.panel1.TabIndex = 24;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Image = global::HTQuanLyXe.Properties.Resources.print_icon;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(719, 540);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(175, 58);
            this.buttonPrint.TabIndex = 151;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSaveWord
            // 
            this.buttonSaveWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonSaveWord.FlatAppearance.BorderSize = 0;
            this.buttonSaveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveWord.ForeColor = System.Drawing.Color.White;
            this.buttonSaveWord.Image = global::HTQuanLyXe.Properties.Resources.Save_icon;
            this.buttonSaveWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveWord.Location = new System.Drawing.Point(341, 540);
            this.buttonSaveWord.Name = "buttonSaveWord";
            this.buttonSaveWord.Size = new System.Drawing.Size(177, 58);
            this.buttonSaveWord.TabIndex = 150;
            this.buttonSaveWord.Text = "Save Word";
            this.buttonSaveWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveWord.UseVisualStyleBackColor = false;
            this.buttonSaveWord.Click += new System.EventHandler(this.buttonSaveWord_Click);
            // 
            // radioButtonSang
            // 
            this.radioButtonSang.BackColor = System.Drawing.Color.White;
            this.radioButtonSang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonSang.Image = global::HTQuanLyXe.Properties.Resources.Sang;
            this.radioButtonSang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonSang.Location = new System.Drawing.Point(39, 23);
            this.radioButtonSang.Name = "radioButtonSang";
            this.radioButtonSang.Size = new System.Drawing.Size(258, 56);
            this.radioButtonSang.TabIndex = 13;
            this.radioButtonSang.TabStop = true;
            this.radioButtonSang.Text = "  Ca Sáng 7h - 11h";
            this.radioButtonSang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonSang.UseVisualStyleBackColor = false;
            // 
            // radioButtonToi
            // 
            this.radioButtonToi.BackColor = System.Drawing.Color.White;
            this.radioButtonToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonToi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonToi.Image = global::HTQuanLyXe.Properties.Resources.Toi;
            this.radioButtonToi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonToi.Location = new System.Drawing.Point(651, 23);
            this.radioButtonToi.Name = "radioButtonToi";
            this.radioButtonToi.Size = new System.Drawing.Size(272, 56);
            this.radioButtonToi.TabIndex = 15;
            this.radioButtonToi.TabStop = true;
            this.radioButtonToi.Text = "Ca Tối 18h - 22h";
            this.radioButtonToi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonToi.UseVisualStyleBackColor = false;
            // 
            // radioButtonTrua
            // 
            this.radioButtonTrua.BackColor = System.Drawing.Color.White;
            this.radioButtonTrua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonTrua.Image = global::HTQuanLyXe.Properties.Resources.free_sun_icon_1846_thumb;
            this.radioButtonTrua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonTrua.Location = new System.Drawing.Point(351, 23);
            this.radioButtonTrua.Name = "radioButtonTrua";
            this.radioButtonTrua.Size = new System.Drawing.Size(279, 56);
            this.radioButtonTrua.TabIndex = 14;
            this.radioButtonTrua.TabStop = true;
            this.radioButtonTrua.Text = "Ca Trưa 11h - 14h";
            this.radioButtonTrua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonTrua.UseVisualStyleBackColor = false;
            // 
            // buttonChiaCa
            // 
            this.buttonChiaCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonChiaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiaCa.ForeColor = System.Drawing.Color.White;
            this.buttonChiaCa.Image = global::HTQuanLyXe.Properties.Resources.ok_icon;
            this.buttonChiaCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChiaCa.Location = new System.Drawing.Point(528, 147);
            this.buttonChiaCa.Name = "buttonChiaCa";
            this.buttonChiaCa.Size = new System.Drawing.Size(154, 43);
            this.buttonChiaCa.TabIndex = 13;
            this.buttonChiaCa.Text = "Chia Ca";
            this.buttonChiaCa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChiaCa.UseVisualStyleBackColor = false;
            this.buttonChiaCa.Click += new System.EventHandler(this.buttonChiaCa_Click);
            // 
            // ChiaCaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 635);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSaveWord);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonChiaCa);
            this.Controls.Add(this.dataGridViewChiaCaNV);
            this.Name = "ChiaCaForm";
            this.Text = "ChiaCaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiaCaNV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChiaCa;
        private System.Windows.Forms.DataGridView dataGridViewChiaCaNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonSang;
        private System.Windows.Forms.RadioButton radioButtonToi;
        private System.Windows.Forms.RadioButton radioButtonTrua;
        private System.Windows.Forms.Button buttonSaveWord;
        private System.Windows.Forms.Button buttonPrint;
    }
}