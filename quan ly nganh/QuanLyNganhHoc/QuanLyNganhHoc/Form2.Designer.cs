namespace QuanLyNganhHoc
{
    partial class Form2
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
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNganhTV = new System.Windows.Forms.TextBox();
            this.txtTenNganhTA = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.cbKhoaQuanLy = new System.Windows.Forms.ComboBox();
            this.dtNgayMo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Location = new System.Drawing.Point(123, 57);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(73, 17);
            this.lbMaNganh.TabIndex = 0;
            this.lbMaNganh.Text = "Mã Ngành";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(202, 55);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(100, 22);
            this.txtMaNganh.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(167, 320);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 42);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(472, 320);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 42);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Ngành Tiếng Việt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Ngành Tiếng Anh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khoa Quản Lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Mở";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mô Tả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTenNganhTV
            // 
            this.txtTenNganhTV.Location = new System.Drawing.Point(202, 122);
            this.txtTenNganhTV.Name = "txtTenNganhTV";
            this.txtTenNganhTV.Size = new System.Drawing.Size(186, 22);
            this.txtTenNganhTV.TabIndex = 9;
            // 
            // txtTenNganhTA
            // 
            this.txtTenNganhTA.Location = new System.Drawing.Point(202, 188);
            this.txtTenNganhTA.Name = "txtTenNganhTA";
            this.txtTenNganhTA.Size = new System.Drawing.Size(186, 22);
            this.txtTenNganhTA.TabIndex = 10;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(568, 190);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(230, 104);
            this.txtMoTa.TabIndex = 13;
            // 
            // cbKhoaQuanLy
            // 
            this.cbKhoaQuanLy.FormattingEnabled = true;
            this.cbKhoaQuanLy.Items.AddRange(new object[] {
            "Toán Tin\t",
            "Ngôn Ngữ",
            "Kinh Tế",
            "Khoa Học Sức Khỏe"});
            this.cbKhoaQuanLy.Location = new System.Drawing.Point(568, 55);
            this.cbKhoaQuanLy.Name = "cbKhoaQuanLy";
            this.cbKhoaQuanLy.Size = new System.Drawing.Size(150, 24);
            this.cbKhoaQuanLy.TabIndex = 14;
            // 
            // dtNgayMo
            // 
            this.dtNgayMo.CustomFormat = "yyyy.MM.dd";
            this.dtNgayMo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayMo.Location = new System.Drawing.Point(568, 120);
            this.dtNgayMo.Name = "dtNgayMo";
            this.dtNgayMo.Size = new System.Drawing.Size(150, 22);
            this.dtNgayMo.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtNgayMo);
            this.Controls.Add(this.cbKhoaQuanLy);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenNganhTA);
            this.Controls.Add(this.txtTenNganhTV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtMaNganh);
            this.Controls.Add(this.lbMaNganh);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNganhTV;
        private System.Windows.Forms.TextBox txtTenNganhTA;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.ComboBox cbKhoaQuanLy;
        private System.Windows.Forms.DateTimePicker dtNgayMo;
    }
}