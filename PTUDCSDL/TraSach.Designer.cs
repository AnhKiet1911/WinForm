namespace LTUDQL
{
    partial class TraSach
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtKiemTra = new MetroFramework.Controls.MetroTextBox();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.btnDoiVe = new MetroFramework.Controls.MetroLink();
            this.btnThoat = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 91);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(591, 275);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel12.Location = new System.Drawing.Point(365, 52);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(65, 19);
            this.metroLabel12.TabIndex = 75;
            this.metroLabel12.Text = "Mã Sách";
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // txtKiemTra
            // 
            this.txtKiemTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtKiemTra.CustomButton.Image = null;
            this.txtKiemTra.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtKiemTra.CustomButton.Name = "";
            this.txtKiemTra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKiemTra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKiemTra.CustomButton.TabIndex = 1;
            this.txtKiemTra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKiemTra.CustomButton.UseSelectable = true;
            this.txtKiemTra.CustomButton.Visible = false;
            this.txtKiemTra.Lines = new string[0];
            this.txtKiemTra.Location = new System.Drawing.Point(432, 50);
            this.txtKiemTra.MaxLength = 32767;
            this.txtKiemTra.Name = "txtKiemTra";
            this.txtKiemTra.PasswordChar = '\0';
            this.txtKiemTra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKiemTra.SelectedText = "";
            this.txtKiemTra.SelectionLength = 0;
            this.txtKiemTra.SelectionStart = 0;
            this.txtKiemTra.ShortcutsEnabled = true;
            this.txtKiemTra.Size = new System.Drawing.Size(121, 23);
            this.txtKiemTra.TabIndex = 73;
            this.txtKiemTra.UseSelectable = true;
            this.txtKiemTra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKiemTra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKiemTra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKiemTra_KeyDown);
            // 
            // metroLink3
            // 
            this.metroLink3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLink3.Image = global::LTUDQL.Properties.Resources.i_timkiem;
            this.metroLink3.ImageSize = 32;
            this.metroLink3.Location = new System.Drawing.Point(566, 40);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(35, 39);
            this.metroLink3.TabIndex = 74;
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // btnDoiVe
            // 
            this.btnDoiVe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoiVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiVe.Image = global::LTUDQL.Properties.Resources.Delete;
            this.btnDoiVe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoiVe.ImageSize = 32;
            this.btnDoiVe.Location = new System.Drawing.Point(501, 378);
            this.btnDoiVe.Name = "btnDoiVe";
            this.btnDoiVe.Size = new System.Drawing.Size(57, 50);
            this.btnDoiVe.TabIndex = 78;
            this.btnDoiVe.Text = "Trả Sách";
            this.btnDoiVe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoiVe.UseSelectable = true;
            this.btnDoiVe.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = global::LTUDQL.Properties.Resources.close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.ImageSize = 32;
            this.btnThoat.Location = new System.Drawing.Point(564, 378);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 50);
            this.btnThoat.TabIndex = 77;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseSelectable = true;
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 429);
            this.Controls.Add(this.btnDoiVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txtKiemTra);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroPanel1);
            this.Name = "TraSach";
            this.Text = "Trả Sách";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtKiemTra;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink btnDoiVe;
        private MetroFramework.Controls.MetroLink btnThoat;
    }
}