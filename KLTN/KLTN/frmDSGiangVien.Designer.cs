namespace KLTN
{
    partial class frmDSGiangVien
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
            this.DSGiangVien = new System.Windows.Forms.DataGridView();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DSGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // DSGiangVien
            // 
            this.DSGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName});
            this.DSGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DSGiangVien.Location = new System.Drawing.Point(0, 0);
            this.DSGiangVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DSGiangVien.Name = "DSGiangVien";
            this.DSGiangVien.RowHeadersWidth = 51;
            this.DSGiangVien.Size = new System.Drawing.Size(837, 603);
            this.DSGiangVien.TabIndex = 0;
            this.DSGiangVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clName
            // 
            this.clName.HeaderText = "Tên";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.Width = 125;
            // 
            // frmDSGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 603);
            this.Controls.Add(this.DSGiangVien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDSGiangVien";
            this.Text = "frmDSGiangVien";
            ((System.ComponentModel.ISupportInitialize)(this.DSGiangVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DSGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
    }
}