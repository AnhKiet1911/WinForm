namespace LTUDQL
{
    partial class PhieuMuonSach
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblNgayMuon = new MetroFramework.Controls.MetroLabel();
            this.lblTenDocGia = new MetroFramework.Controls.MetroLabel();
            this.GridViewSachMuon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDat_Close = new MetroFramework.Controls.MetroLabel();
            this.btnDatThe = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroLink();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnRemove = new MetroFramework.Controls.MetroLink();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtRemoveBook = new System.Windows.Forms.TextBox();
            this.lblThongBaoMuonSach = new MetroFramework.Controls.MetroLabel();
            this.CboxSachTrongKho = new LTUDQL.AutoCompeleteComboBox();
            this.lblDatthe2 = new MetroFramework.Controls.MetroLabel();
            this.btnDatThe2 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(51, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên Độc Giả:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(381, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Ngày Mượn:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNgayMuon.Location = new System.Drawing.Point(480, 77);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(83, 19);
            this.lblNgayMuon.TabIndex = 2;
            this.lblNgayMuon.Text = "11/11/2016";
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTenDocGia.Location = new System.Drawing.Point(142, 77);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(45, 38);
            this.lblTenDocGia.TabIndex = 3;
            this.lblTenDocGia.Text = "Name\r\n";
            // 
            // GridViewSachMuon
            // 
            this.GridViewSachMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GridViewSachMuon.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridViewSachMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridViewSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Sach,
            this.TheLoai,
            this.TacGia});
            this.GridViewSachMuon.GridColor = System.Drawing.Color.SeaShell;
            this.GridViewSachMuon.Location = new System.Drawing.Point(23, 103);
            this.GridViewSachMuon.Name = "GridViewSachMuon";
            this.GridViewSachMuon.ReadOnly = true;
            this.GridViewSachMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.GridViewSachMuon.RowHeadersVisible = false;
            this.GridViewSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewSachMuon.Size = new System.Drawing.Size(601, 170);
            this.GridViewSachMuon.TabIndex = 4;
            this.GridViewSachMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSachMuon_CellClick);
            this.GridViewSachMuon.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.GridViewSachMuon_RowStateChanged);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Sach
            // 
            this.Sach.DataPropertyName = "Sach";
            this.Sach.HeaderText = "Sách";
            this.Sach.Name = "Sach";
            this.Sach.ReadOnly = true;
            this.Sach.Width = 200;
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            this.TacGia.Width = 200;
            // 
            // lblDat_Close
            // 
            this.lblDat_Close.AutoSize = true;
            this.lblDat_Close.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDat_Close.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDat_Close.Location = new System.Drawing.Point(582, 331);
            this.lblDat_Close.Name = "lblDat_Close";
            this.lblDat_Close.Size = new System.Drawing.Size(44, 19);
            this.lblDat_Close.TabIndex = 27;
            this.lblDat_Close.Text = "Thoát";
            this.lblDat_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDat_Close.UseCustomForeColor = true;
            // 
            // btnDatThe
            // 
            this.btnDatThe.Image = global::LTUDQL.Properties.Resources.close;
            this.btnDatThe.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDatThe.ImageSize = 35;
            this.btnDatThe.Location = new System.Drawing.Point(586, 289);
            this.btnDatThe.Name = "btnDatThe";
            this.btnDatThe.Size = new System.Drawing.Size(38, 39);
            this.btnDatThe.TabIndex = 25;
            this.btnDatThe.UseSelectable = true;
            this.btnDatThe.Click += new System.EventHandler(this.btnDatThe_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(334, 289);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(29, 15);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Add";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::LTUDQL.Properties.Resources.Add;
            this.btnAdd.ImageSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(312, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 21);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Red;
            this.metroLabel4.Location = new System.Drawing.Point(336, 330);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 15);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "Remove";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::LTUDQL.Properties.Resources.Delete;
            this.btnRemove.ImageSize = 20;
            this.btnRemove.Location = new System.Drawing.Point(312, 325);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 22);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.Purple;
            this.metroLabel5.Location = new System.Drawing.Point(23, 288);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Thêm Sách:";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.Purple;
            this.metroLabel6.Location = new System.Drawing.Point(23, 327);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Bỏ Sách:";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txtRemoveBook
            // 
            this.txtRemoveBook.Location = new System.Drawing.Point(110, 327);
            this.txtRemoveBook.Name = "txtRemoveBook";
            this.txtRemoveBook.ReadOnly = true;
            this.txtRemoveBook.Size = new System.Drawing.Size(173, 20);
            this.txtRemoveBook.TabIndex = 36;
            // 
            // lblThongBaoMuonSach
            // 
            this.lblThongBaoMuonSach.AutoSize = true;
            this.lblThongBaoMuonSach.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblThongBaoMuonSach.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblThongBaoMuonSach.Location = new System.Drawing.Point(125, 371);
            this.lblThongBaoMuonSach.Name = "lblThongBaoMuonSach";
            this.lblThongBaoMuonSach.Size = new System.Drawing.Size(400, 19);
            this.lblThongBaoMuonSach.TabIndex = 38;
            this.lblThongBaoMuonSach.Text = "Độc Giả Phải Trả Lại Sách Trong Vòng 4 Ngày Kể Từ Ngày Mượn";
            this.lblThongBaoMuonSach.UseCustomForeColor = true;
            // 
            // CboxSachTrongKho
            // 
            this.CboxSachTrongKho.FormattingEnabled = true;
            this.CboxSachTrongKho.Location = new System.Drawing.Point(110, 288);
            this.CboxSachTrongKho.Name = "CboxSachTrongKho";
            this.CboxSachTrongKho.Size = new System.Drawing.Size(173, 21);
            this.CboxSachTrongKho.TabIndex = 37;
            // 
            // lblDatthe2
            // 
            this.lblDatthe2.AutoSize = true;
            this.lblDatthe2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDatthe2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDatthe2.Location = new System.Drawing.Point(581, 332);
            this.lblDatthe2.Name = "lblDatthe2";
            this.lblDatthe2.Size = new System.Drawing.Size(50, 19);
            this.lblDatthe2.TabIndex = 40;
            this.lblDatthe2.Text = "Đặt Vé";
            this.lblDatthe2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDatthe2.UseCustomForeColor = true;
            this.lblDatthe2.Visible = false;
            // 
            // btnDatThe2
            // 
            this.btnDatThe2.Image = global::LTUDQL.Properties.Resources.Save;
            this.btnDatThe2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDatThe2.ImageSize = 35;
            this.btnDatThe2.Location = new System.Drawing.Point(586, 289);
            this.btnDatThe2.Name = "btnDatThe2";
            this.btnDatThe2.Size = new System.Drawing.Size(38, 39);
            this.btnDatThe2.TabIndex = 39;
            this.btnDatThe2.UseSelectable = true;
            this.btnDatThe2.Visible = false;
            this.btnDatThe2.Click += new System.EventHandler(this.btnDatThe_Click);
            // 
            // PhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 396);
            this.Controls.Add(this.lblDatthe2);
            this.Controls.Add(this.btnDatThe2);
            this.Controls.Add(this.lblThongBaoMuonSach);
            this.Controls.Add(this.CboxSachTrongKho);
            this.Controls.Add(this.txtRemoveBook);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDat_Close);
            this.Controls.Add(this.btnDatThe);
            this.Controls.Add(this.GridViewSachMuon);
            this.Controls.Add(this.lblTenDocGia);
            this.Controls.Add(this.lblNgayMuon);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "PhieuMuonSach";
            this.Text = "Phiếu Mượn Sách";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.PhieuMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblNgayMuon;
        private MetroFramework.Controls.MetroLabel lblTenDocGia;
        private System.Windows.Forms.DataGridView GridViewSachMuon;
        private MetroFramework.Controls.MetroLabel lblDat_Close;
        private MetroFramework.Controls.MetroLink btnDatThe;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink btnRemove;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtRemoveBook;
        private AutoCompeleteComboBox CboxSachTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private MetroFramework.Controls.MetroLabel lblThongBaoMuonSach;
        private MetroFramework.Controls.MetroLabel lblDatthe2;
        private MetroFramework.Controls.MetroLink btnDatThe2;
    }
}