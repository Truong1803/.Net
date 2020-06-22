namespace caro3
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
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.PVE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxPlayername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.Color.White;
            this.pnlBanCo.Location = new System.Drawing.Point(12, 11);
            this.pnlBanCo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(668, 617);
            this.pnlBanCo.TabIndex = 0;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            this.pnlBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(686, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "PvP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PVP);
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Location = new System.Drawing.Point(686, 552);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(327, 75);
            this.NewGame.TabIndex = 10;
            this.NewGame.Text = "New Game";
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // PVE
            // 
            this.PVE.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVE.Location = new System.Drawing.Point(686, 471);
            this.PVE.Name = "PVE";
            this.PVE.Size = new System.Drawing.Size(327, 75);
            this.PVE.TabIndex = 7;
            this.PVE.Text = "PvE";
            this.PVE.UseVisualStyleBackColor = true;
            this.PVE.Click += new System.EventHandler(this.PVE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::caro3.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(686, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbxPlayername
            // 
            this.tbxPlayername.Enabled = false;
            this.tbxPlayername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbxPlayername.Location = new System.Drawing.Point(838, 301);
            this.tbxPlayername.Multiline = true;
            this.tbxPlayername.Name = "tbxPlayername";
            this.tbxPlayername.ReadOnly = true;
            this.tbxPlayername.Size = new System.Drawing.Size(175, 53);
            this.tbxPlayername.TabIndex = 8;
            this.tbxPlayername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPlayername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 112);
            this.label2.TabIndex = 9;
            this.label2.Text = "Người Chơi Đánh Kế Tiếp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPlayername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.PVE);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PVE;
        private System.Windows.Forms.TextBox tbxPlayername;
        private System.Windows.Forms.Label label2;
    }
}

