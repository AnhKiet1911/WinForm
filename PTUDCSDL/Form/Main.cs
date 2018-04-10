using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDQL
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        string IdNguoiDung = "";
        int Flagged = 0;

        //Thay Đỏi Quy Định
        int TuoiMuonSach = 6; //6 Tuổi Mặc Định
        int GiaTriThe = 6;  //6 Tháng Mặc Định

        int NgayMuonToiDa = 4;  //Mặc Định Là 4 Ngaỳ
        int SoLuongMuonToiDa = 5; //Mặc Định là 5 Cuốn

        public Main()
        {
            InitializeComponent();
            ControlBox = false;



            /// <summary>
            /// transparent label name
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            //TileNameQuanLy Trans
            var NameTile1 = this.TabQuanLy.PointToScreen(TileNameQuanLy.Location);
            NameTile1 = TileQuanLy.PointToClient(NameTile1);
            TileNameQuanLy.Parent = TileQuanLy;
            TileNameQuanLy.Location = NameTile1;
            TileNameQuanLy.BackColor = Color.Transparent;

            ////Label Tiêu Đề Trans
            var trans2 = this.TabQuanLy.PointToScreen(lblTieuTeTabQL.Location);
            trans2 = pictureBox1.PointToClient(trans2);
            lblTieuTeTabQL.Parent = pictureBox1;
            lblTieuTeTabQL.Location = trans2;
            lblTieuTeTabQL.BackColor = Color.Transparent;

            //Tile Chức Năng
            //Tile LapThe trans
            var NhapThe = this.TabQuanLy.PointToScreen(lblTheDocGia.Location);
            NhapThe = TileLapTheDocGia.PointToClient(NhapThe);
            lblTheDocGia.Parent = TileLapTheDocGia;
            lblTheDocGia.Location = NhapThe;
            lblTheDocGia.BackColor = Color.Transparent;

            //Tile TraCuuSach trans
            var TraCuu = this.TabQuanLy.PointToScreen(lblTraCuuSach.Location);
            TraCuu = TileTraCuuSach.PointToClient(TraCuu);
            lblTraCuuSach.Parent = TileTraCuuSach;
            lblTraCuuSach.Location = TraCuu;
            lblTraCuuSach.BackColor = Color.Transparent;

            //Tile Nhận Trả Sách trans
            var NhanTra = this.TabQuanLy.PointToScreen(lblNhanTraSach.Location);
            NhanTra = TileNhanTraSach.PointToClient(NhanTra);
            lblNhanTraSach.Parent = TileNhanTraSach;
            lblNhanTraSach.Location = NhanTra;
            lblNhanTraSach.BackColor = Color.Transparent;

            //Tile Nhận Sách Mới trans
            var NhanSach = this.TabQuanLy.PointToScreen(label2.Location);
            NhanSach = TileNhanSachMoi.PointToClient(NhanSach);
            label2.Parent = TileNhanSachMoi;
            label2.Location = NhanSach;
            label2.BackColor = Color.Transparent;

            //Tile Lập Phiếu Mượn trans
            var PhieuMuon = this.TabQuanLy.PointToScreen(label4.Location);
            PhieuMuon = TileLapPhieuMuon.PointToClient(PhieuMuon);
            label4.Parent = TileLapPhieuMuon;
            label4.Location = PhieuMuon;
            label4.BackColor = Color.Transparent;

            //Tile Lập Thay Đổi Quy Định trans
            var ChangeQuyDinh = this.TabQuanLy.PointToScreen(label6.Location);
            ChangeQuyDinh = TileThayDoiQuyDinh.PointToClient(ChangeQuyDinh);
            label6.Parent = TileThayDoiQuyDinh;
            label6.Location = ChangeQuyDinh;
            label6.BackColor = Color.Transparent;


        }

        public delegate void PassDataDatVe(string IdNguoiDung);
        public delegate void PassDataSuaVe(int IdDocGia);

        //Lây Dữ Liệu Form 1
        public void GetData_Form1(MetroFramework.Controls.MetroTextBox Txt_Login)
        {

            IdNguoiDung = Txt_Login.Text;
        }




        /// <summary>
        /// Animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //about Show
        int HightAbout = 150, aAbout = 1;
        private void TimeAbout_Tick(object sender, EventArgs e)
        {
            try
            {
                HightAbout += aAbout;
                TileAbout.Size = new Size(427, HightAbout);
                if (HightAbout == 300)
                {
                    TileAbout.Size = new Size(427, 150);
                    HightAbout = 150;
                    aAbout = 1;
                    TglAbout.Checked = false;
                }
                else if (HightAbout == 150)
                {
                    aClock = +1;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }



        //Var Move ClockTime
        int HightClock = 75, aClock = 1;
        private void ClockTime_Tick(object sender, EventArgs e)
        {
            try
            {

                HightClock += aClock;
                metroLink1.Size = new Size(HightClock, 29);
                if (HightClock == 2550)
                {
                    metroLink1.Location = new Point(205, 40);
                    metroLink1.Size = new Size(75, 29);
                    HightClock = 75;
                    aClock = 1;
                }
                else if (HightClock == 60)
                {
                    aClock = +1;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        private void GetTime_Tick(object sender, EventArgs e)
        {
            try
            {
                metroLink1.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "\r\n" + DateTime.Now.DayOfWeek + "\r\n - Ngày " + DateTime.Now.Day.ToString() + "\r\n - Tháng " + DateTime.Now.Month.ToString() + "- Năm " + DateTime.Now.Year.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Var Move MoveTitel
        int X = 23, Y = 11, point = 1;
        private void MoveTitel_Tick(object sender, EventArgs e)
        {
            try
            {

                X += point;
                lblTitel.Location = new Point(X, Y);
                if (X == 1095)
                {
                    point = -1;
                }
                else if (X == 206)
                {
                    point = +1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
           

            this.Opacity = metroTrackBar1.Value * 0.01;
            if (this.Opacity <= 0.1)
            {
                this.Opacity = 0.1;
            }

            ToggleDefaul.Checked = false;

        }

        private void TglAbout_CheckedChanged(object sender, EventArgs e)
        {


            if (TglAbout.Checked == true)
            {
                TimeAbout.Enabled = true;
                TileAbout.Visible = true;
                lblCTV.Visible = true;

            }
            else
            {
                TileAbout.Size = new Size(427, 150);
                HightAbout = 150;
                aAbout = 1;
                TimeAbout.Enabled = false;
                TileAbout.Visible = false;
                lblCTV.Visible = false;

            }


        }


        private void lblTitel_Click(object sender, EventArgs e)
        {

            //QuanLy
            lblTieuTeTabQL.Visible = false;
            ImageQuanLy.Visible = false;
            btnChoose.Visible = false;
            btnEditImageQL.Visible = false;
            PannelQuanLy.Visible = false;


            //TimKiemSach
           
            lblTieuTeTabQL.Visible = false;
            GridViewDSS.Visible = false;
          
            panelTraCuuSach.Visible = false;

            //Lập thẻ
            GridViewDSTheDocGia.Visible = false;
            btnDatPhieu.Visible = false;
            btnXoaPhieu.Visible = false;
            btnSuaPhieu.Visible = false;
            btnEXLapThe.Visible = false;
            btnReportTheDocGia.Visible = false;
            //Nhận sách
            btnNhanSach.Visible = false;
            btnXoaSach.Visible = false;
            btnCapNhat.Visible = false;
            btnEXDSS.Visible = false;
            btnReportSach.Visible = false;

            //LapPhieuMuon
            GridViewMuonSach.Visible = false;
            PanelPhieuMuon.Visible = false;
            btnEXDSMuon.Visible = false;

            
            //Tra Sách
            PanelTraSach.Visible = false;
            //CaiDat
            GridViewCaiDat.Visible = false;
            btnCaiDat.Visible = false;
           
        }



        //Đường Dẫn Hình Ảnh Người Dùng
        string DuongDan;
        private void btnSuaAnhNguoiDung_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChonTep = new OpenFileDialog();
            ChonTep.Filter = ChonTep.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|Gif Files (*.gif)|*.gif";
            ChonTep.RestoreDirectory = true;
            if (ChonTep.ShowDialog() == DialogResult.OK)
            {
                ImageQuanLy.ImageLocation = ChonTep.FileName;
                DuongDan = ChonTep.FileName;

            }
        }

        private void btnEditAnhNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                KiemTra.UpdateAvatar(IdNguoiDung, ConvertImageToURL());
                TileQuanLy.Image = Image.FromStream(KiemTra.ReadImage(IdNguoiDung));
                MetroFramework.MetroMessageBox.Show(this,"OKey");
            }
            catch (Exception )
            {
               
            }
        }

        private byte[] ConvertImageToURL()
        {
            FileStream fs;
            fs = new FileStream(DuongDan, FileMode.Open, FileAccess.Read);
            byte[] picture = new byte[fs.Length];
            fs.Read(picture, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picture;
        }

        private void TileQuanLy_Click(object sender, EventArgs e)
        {

            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            try
            {
                ImageQuanLy.Image = Image.FromStream(KiemTra.ReadImage(IdNguoiDung));
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            NguoiDung User = KiemTra.LoadThongTinNguoiDung(IdNguoiDung);

            lblTenQuanLy.Text = User.Ten;
            lblDiaChiQuanLy.Text = User.DiaChi;
            lblGioiTinhQL.Text = User.GioiTinh;
            lblPhoneQuanLy.Text = User.SoDienThoai;
            lblNgaySinhQuanLy.Text = User.NgaySinh;
          

            //reset
            lblTitel_Click(sender, e);
            ImageQuanLy.Visible = true;
            PannelQuanLy.Visible = true;
            btnChoose.Visible = true;
            btnEditImageQL.Visible = true;
            lblTieuTeTabQL.Visible = true;
            lblTieuTeTabQL.Text = "Thông Tin Người Dùng";
        }

        //---------------------------------------------------------><---------------//
        //Slide Panel Nhân Viên
        int Weight_SlideQL = 233;
        private void Visible_PanelQL(bool TorF)
        {
            if (TorF == true)
            {
                TileQuanLy.Visible = true;
                TileLapTheDocGia.Visible = true;
                TileTraCuuSach.Visible = true;
                TileLapPhieuMuon.Visible = true;
                TileNhanTraSach.Visible = true;
                TileThayDoiQuyDinh.Visible = true;
                TileNhanSachMoi.Visible = true;
                SlideCloseQL.Visible = true;
                slideDownQL.Visible = false;
                
                //lblName
                lblTraCuuSach.Visible = true;
                lblNhanTraSach.Visible = true;
                lblTheDocGia.Visible = true;
                //
                IconCaiDatQL.Location = new Point(45, 631);
                IconTurnOffQL.Location = new Point(115, 631);
                IconLogOutQL.Location = new Point(180, 631);

                //Icon
                IconTen.Visible = false;
                IconLapTheDocGia.Visible = false;
                IconThemSach.Visible = false;
                IconTraCuuSach.Visible = false;
                IconLapPhieuMuon.Visible = false;
                IconNhanTraSach.Visible = false;
                IconThayDoiQuyDinh.Visible = false;
            }
            else
            {
                TileQuanLy.Visible = false;
                TileLapTheDocGia.Visible = false;
                TileTraCuuSach.Visible = false;
                TileLapPhieuMuon.Visible = false;
                TileNhanTraSach.Visible = false;
                TileThayDoiQuyDinh.Visible = false;
                TileNhanSachMoi.Visible = false;
                SlideCloseQL.Visible = false;

                slideDownQL.Visible = true;

                //lblName
                lblTraCuuSach.Visible = false;
                lblNhanTraSach.Visible = false;
                lblTheDocGia.Visible = false;

                //setting

                IconCaiDatQL.Location = new Point(4, 631);
                IconTurnOffQL.Location = new Point(4, 580);
                IconLogOutQL.Location = new Point(2, 530);
                //Icon

                IconTen.Visible = true;
                IconLapTheDocGia.Visible = true;
                IconThemSach.Visible = true;
                IconTraCuuSach.Visible = true;
                IconLapPhieuMuon.Visible = true;
                IconNhanTraSach.Visible = true;
                IconThayDoiQuyDinh.Visible = true;

            }
        }
        private void SlideCloseQL_Click(object sender, EventArgs e)
        {
            TimeSlideCloseQL.Enabled = true;
        }

        private void slideDownQL_Click(object sender, EventArgs e)
        {
            TimeSlideDownQL.Enabled = true;
        }

        private void TimeSlideDownQL_Tick(object sender, EventArgs e)
        {
            Visible_PanelQL(true);
            PenalSlideQL.Size = new Size(Weight_SlideQL, 680);
            if (PenalSlideQL.Width >= 233)
            {
                TimeSlideDownQL.Enabled = false;
            }
            else
            {
                Weight_SlideQL += 12;
            }
        }

        private void TimeSlideCloseQL_Tick(object sender, EventArgs e)
        {
            PenalSlideQL.Size = new Size(Weight_SlideQL, 680);
            if (PenalSlideQL.Width <= 58)
            {
                TimeSlideCloseQL.Enabled = false;
                Visible_PanelQL(false);

            }
            else
            {
                Weight_SlideQL -= 12;
            }
        }

        private void IconHome_Click(object sender, EventArgs e)
        {
            this.TabMain.SelectedTab = TabQuanLy;
            lblTitel_Click(sender, e);

        }


        private void DangXuat_CheckedChanged(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Đăng Xuất ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void TileLapTheDocGia_Click(object sender, EventArgs e)
        {

            lblTitel_Click(sender, e);

            GridViewDSTheDocGia.Visible = true;
            GridViewDSTheDocGia.Location = new Point(250,137);
            GridViewDSTheDocGia.Size = new Size(889, 333);

            btnDatPhieu.Visible = true;
            btnDatPhieu.Location = new Point(1155, 432);

            btnSuaPhieu.Visible = true;
            btnSuaPhieu.Location = new Point(1155, 387);

            btnXoaPhieu.Visible = true;
            btnXoaPhieu.Location = new Point(1155, 342);

            btnEXLapThe.Visible = true;
            btnEXLapThe.Location = new Point(1155, 297);

            btnReportTheDocGia.Visible = true;
            btnReportTheDocGia.Location = new Point(1155,259);

            lblTieuTeTabQL.Visible = true;
            lblTieuTeTabQL.Text = "Danh Sách Các Thẻ Độc Giả";


            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            GridViewDSTheDocGia.DataSource = KiemTra.DataViewTheDocGia();
           

        }

        private void btnReportTheDocGia_Click(object sender, EventArgs e)
        {
            frmReportTheDocGia frm = new frmReportTheDocGia();
            frm.ShowDialog();
        }
        private void btnDatPhieu_Click(object sender, EventArgs e)
        {
            //
            string Str = IdNguoiDung;
            //this.Hide();
            LapTheDocGia DV = new LapTheDocGia();
            PassDataDatVe Share = new PassDataDatVe(DV.GetPassData_FormMain);
            PassDataSuaVe TuoiLapPhieu = new PassDataSuaVe(DV.GetTuoi_FormMain);
            PassDataSuaVe ThoiHanSuDungThe = new PassDataSuaVe(DV.GetHanSuDung_FormMain);
            Share(Str);
            TuoiLapPhieu(TuoiMuonSach);
            ThoiHanSuDungThe(GiaTriThe);
            //
            DV.ShowDialog();
            this.TileLapTheDocGia_Click(sender, e);
        }



        string iIdDocGia = "";
        private void GridViewDSTheDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewDSTheDocGia.Rows.Count > 0 && GridViewDSTheDocGia.DataSource != null)
            {
                iIdDocGia = GridViewDSTheDocGia.SelectedRows[0].Cells[0].Value.ToString();
             
            }

            else
            {
                MessageBox.Show("Hiện Chưa Có Thông Tin Gì Để Chọn");
            }
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            if (iIdDocGia != "")
            {
                int Str = Convert.ToInt32(iIdDocGia);
                //this.Hide();
                SuaTheDocGia DV = new SuaTheDocGia();
                PassDataSuaVe Share = new PassDataSuaVe(DV.GetPassData_FormMain);
                PassDataSuaVe Tuoi = new PassDataSuaVe(DV.GetTuoiDatThe_FormMain);
                PassDataSuaVe HanSuDung = new PassDataSuaVe(DV.GetHanDung_FormMain);
                Share(Str);
                Tuoi(TuoiMuonSach);
                HanSuDung(GiaTriThe);
                DV.ShowDialog();
                this.TileLapTheDocGia_Click(sender, e);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Chưa Chọn Thẻ Cần Sửa");
            }
        
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if (iIdDocGia == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Chưa Chọn Thẻ Cần Xoá");
            }
            else if(MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Xoá Thẻ Này", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                    Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                    try
                    {
                        KiemTra.XoaTheDocGia(Convert.ToInt32(iIdDocGia));

                     //reset select row
                     iIdDocGia = "";
                        this.TileLapTheDocGia_Click(sender, e);
                        MetroFramework.MetroMessageBox.Show(this, string.Format("Xoá Thành Công  Đôc Giả "));
                    }
                    catch (Exception )
                    {
                          MetroFramework.MetroMessageBox.Show(this,"Không Thể Xoá Thẻ Này Vì Thẻ Này Đang Mượn Sách","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error );
                        
                    }

                  
            }
        }

        private void TileNhanSachMoi_Click(object sender, EventArgs e)
        {
            lblTitel_Click(sender, e);

            GridViewDSS.Visible = true;
            GridViewDSS.Location = new Point(250, 137);
            GridViewDSS.Size = new Size(889, 333);

            btnNhanSach.Visible = true;
            btnNhanSach.Location = new Point(1155, 432);

            btnCapNhat.Visible = true;
            btnCapNhat.Location = new Point(1155, 387);

            btnXoaSach.Visible = true;
            btnXoaSach.Location = new Point(1155, 342);

            btnEXDSS.Visible = true;
            btnEXDSS.Location = new Point(1155, 297);


            btnReportSach.Visible = true;
            btnReportSach.Location = new Point(1155, 259);




            lblTieuTeTabQL.Visible = true;
            lblTieuTeTabQL.Text = "Nhận Sách Mới";

            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            GridViewDSS.DataSource = KiemTra.DataViewDanhSachSach();

        }

     
        //
        string cMaSach = "";
        private void GridViewDSS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (GridViewDSS.Rows.Count > 0 && GridViewDSS.DataSource != null)
            {
                cMaSach = GridViewDSS.SelectedRows[0].Cells[0].Value.ToString();

            }
            else
            {
                MessageBox.Show("Hiện Chưa Có Thông Tin Gì Để Chọn");
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (cMaSach == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Chưa Chọn Sách Cần Xoá");
            }
            else if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Xoá Sách Này", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                try
                {
                    KiemTra.XoaSach(cMaSach);

                    //reset select row
                    cMaSach = "";
                    this.TileNhanSachMoi_Click(sender, e);
                    MetroFramework.MetroMessageBox.Show(this, string.Format("Xoá Thành Công  Sách {0}", cMaSach));
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Không Thể Xoá Sách Này Vì Sách Này Có Độc Giả  Đang Mượn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnNhanSach_Click(object sender, EventArgs e)
        {
            //
          
            //this.Hide();
            ThongTinSach DV = new ThongTinSach();
            DV.ShowDialog();
            this.TileNhanSachMoi_Click(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cMaSach != "")
            {

                SuaSachTrongKho DV = new SuaSachTrongKho();
                PassDataDatVe Share = new PassDataDatVe(DV.GetPassData_FormMain);
                Share(cMaSach);
                DV.ShowDialog();


                //reset select row

                this.TileNhanSachMoi_Click(sender, e);
               
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Chưa Chọn Sách Cần Sửa");
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {


            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            if (txtTimKiem.Text == " " || txtTimKiem.Text == "  ") 
            {
               
            }
            else
            {
                GridViewTraCuuSach.DataSource = KiemTra.TraCuuSach(txtTimKiem.Text);
                if (GridViewTraCuuSach.DataSource == null || txtTimKiem.Text == null)
                {
                    GridViewTraCuuSach.Rows.Clear();
                    GridViewTraCuuSach.Refresh();
                }
            }
            

        }


        //set defaul đưa toàn bộ cài đặt trở về mặc định
        private void ToggleDefaul_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleDefaul.Checked == true)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Đặt Tất Cả Về Mặc Định", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Bạn Có Muốn Tiếp Tục", "Điều Này Sẽ Đưa Dữ Liệu Cài Đặt Về Trạng Thái Ban Đầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        metroTrackBar1.Value = 100;
                        this.Opacity = metroTrackBar1.Value * 0.01;
                        TuoiMuonSach = 6;
                        GiaTriThe = 6;
                        NgayMuonToiDa = 4;
                        SoLuongMuonToiDa = 5;

                        Class.CaiDat st = new Class.CaiDat();
                        st.TuoiMuonSach = TuoiMuonSach;
                        st.HanSuDungThe = GiaTriThe;
                        st.NgayMuonToiDa = NgayMuonToiDa;
                        st.SachMuonToiDa = SoLuongMuonToiDa;
                        Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                        KiemTra.CaiDatThuVien(st);

                       
                        GridViewCaiDat.DataSource = KiemTra.DGVCaiDat();


                    }
                    else
                    {
                        ToggleDefaul.Checked = false;
                    }
                }
                else
                {
                    ToggleDefaul.Checked = false;
                }
            }
           

        }


        ////////////////////////////////////////////////////

        string cMaMuon = "";
        private void GridViewMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            if (GridViewMuonSach.Rows.Count > 0 && GridViewMuonSach.DataSource != null)
            {
                Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                cMaMuon = GridViewMuonSach.SelectedRows[0].Cells[2].Value.ToString();
                if (Flagged == 1)
                {
                    GridViewTraSach.DataSource = KiemTra.InfoPhieuMuonSach(cMaMuon);
                    txtTraSach.Text = cMaMuon;
                }
                else
                {
                    GridViewChiTietMuon.DataSource = KiemTra.InfoPhieuMuonSach(cMaMuon);
                }
               
                lblTenDocGiaMuonSach.Text = "Sách Độc Giả: " + KiemTra.TenDocGiaMuonSach(cMaMuon)+" : Đang Mượn";
            }
            else
            {
                MessageBox.Show("Hiện Chưa Có Thông Tin Gì Để Chọn");
            }
           
        }


        private void TileLapPhieuMuon_Click(object sender, EventArgs e)
        {
            Flagged = 0;//Cờ Đánh Dấu  Mượn Sách
            lblTitel_Click(sender, e);

            GridViewMuonSach.Visible = true;
            GridViewMuonSach.Location = new Point(251, 168);
            GridViewMuonSach.Size = new Size(302, 285);
            btnEXDSMuon.Visible = true;
            btnEXDSMuon.Location = new Point(251, 457);
            PanelPhieuMuon.Visible = true;
            PanelPhieuMuon.Location = new Point(574, 168);
            PanelPhieuMuon.Size = new Size(500, 285);


            lblTieuTeTabQL.Visible = true;
            lblTieuTeTabQL.Text = "Lập Phiếu Mượn";


            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
            GridViewMuonSach.DataSource = KiemTra.GVMuonSach();

        }

        private void txtKiemTra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnkiemTra_Click(sender, e);
            }
        }

        private void btnkiemTra_Click(object sender, EventArgs e)
        {
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
            if (KiemTra.DaMuonSachRoi(txtKiemTra.Text) == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Độc Giả Vẫn Chưa Trả Sách","Không Thể Mượn Sách",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            else
            {
                if (KiemTra.MaPhieuTonTai(txtKiemTra.Text) == true)
                {
                    PhieuMuonSach DV = new PhieuMuonSach();
                    PassDataDatVe Share = new PassDataDatVe(DV.GetPassData_FormMain);
                    PassDataSuaVe NgayMuon = new PassDataSuaVe(DV.GetNgayToiDaMuon_FormMain);
                    PassDataSuaVe SoLuongMuon = new PassDataSuaVe(DV.GetLuongSach_FormMain);
                    Share(txtKiemTra.Text);
                    NgayMuon(NgayMuonToiDa);
                    SoLuongMuon(SoLuongMuonToiDa);
                    DV.ShowDialog();


                    //reset select row

                    this.TileLapPhieuMuon_Click(sender, e);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Thẻ Không Tồn Tại ","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
        }

        private void TileNhanTraSach_Click(object sender, EventArgs e)
        {
            Flagged = 1;//Cờ Đánh Dấu  Trả Sách
            lblTitel_Click(sender, e);

            GridViewMuonSach.Visible = true;
            GridViewMuonSach.Location = new Point(251, 168);
            GridViewMuonSach.Size = new Size(302, 285);

            PanelTraSach.Visible = true;
            PanelTraSach.Location = new Point(574, 168);
            PanelTraSach.Size = new Size(482, 285);


            lblTieuTeTabQL.Visible = true;
            lblTieuTeTabQL.Text = "Nhận Trả Sách";


            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
            GridViewMuonSach.DataSource = KiemTra.GVMuonSach();
            GridViewChiTietMuon.Rows.Clear();
            GridViewChiTietMuon.Refresh();
            lblTenDocGiaMuonSach.Text = "";
            txtKiemTra.Clear();
            txtTraSach.Clear();
            metroLabel1.Text = "";
        }



        //Trả Sách
        private void metroLink2_Click(object sender, EventArgs e)
        {
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
          

            if (KiemTra.MaPhieuMuonTonTai(txtTraSach.Text) == 1 && KiemTra.DaMuonSachRoi(txtTraSach.Text) == true)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn", "Xác Nhận Trả Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Cập Nhật Lại Số Lượng
                    foreach (var item in KiemTra.LayMaSach(txtTraSach.Text))
                    {
                        KiemTra.Plus_SoLuongSach(item.ToString());
                    }
                    //Xoá Chi Tiết Mượn
                    KiemTra.XoaChiTietMuonSach(txtTraSach.Text);
                    //Xoá Phiếu
                    KiemTra.XoaPhieuMuonSach(txtTraSach.Text);

                    MetroFramework.MetroMessageBox.Show(this, "Complete!");

                    //reset
                    TileNhanTraSach_Click(sender, e);
                    GridViewTraSach.Rows.Clear();
                    GridViewTraSach.Refresh();


                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Độc Giả Này Chưa Mượn Sách ", "Nhầm Lẫn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void TileThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            lblTitel_Click(sender, e);
            GridViewCaiDat.Location = new Point(289, 294);
            GridViewCaiDat.Size = new Size(503, 75);
            btnCaiDat.Location = new Point(800, 345); 
           
            GridViewCaiDat.Visible = true;
            btnCaiDat.Visible = true;
            lblTieuTeTabQL.Visible = true;
            lblTieuTeTabQL.Text = "Thay Đổi Mặc Định";
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            if (TuoiMuonSach != 6 || GiaTriThe != 6 || NgayMuonToiDa != 4 || SoLuongMuonToiDa != 5) 
            {
                ToggleDefaul.Visible = false;
            }
            Setting St = new Setting();
            St.ShowDialog();
            Main_Load(sender, e);
            TileThayDoiQuyDinh_Click(sender, e);
        }

        private void btnExportTimKiem_Click(object sender, EventArgs e)
        {

           
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

              
                for (int i = 0; i < GridViewTraCuuSach.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < GridViewTraCuuSach.Columns.Count; j++)
                    {
                      
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewTraCuuSach.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewTraCuuSach.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

              
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MetroFramework.MetroMessageBox.Show(this,"Export Successful","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }


        }

   
        private void btnEXLapThe_Click(object sender, EventArgs e)
        {
          
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;


                for (int i = 0; i < GridViewDSTheDocGia.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < GridViewDSTheDocGia.Columns.Count; j++)
                    {
                        
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewDSTheDocGia.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewDSTheDocGia.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

            
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MetroFramework.MetroMessageBox.Show(this, "Export Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

       
        private void btnEXDSS_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;


                for (int i = 0; i < GridViewDSS.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < GridViewDSS.Columns.Count; j++)
                    {

                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewDSS.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewDSS.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }


                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MetroFramework.MetroMessageBox.Show(this, "Export Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void btnEXChiTietMuon_Click(object sender, EventArgs e)
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = 0; i < GridViewChiTietMuon.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < GridViewChiTietMuon.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewChiTietMuon.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewChiTietMuon.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MetroFramework.MetroMessageBox.Show(this, "Export Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void btnEXDSMuon_Click(object sender, EventArgs e)
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = 0; i < GridViewMuonSach.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < GridViewMuonSach.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewMuonSach.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GridViewMuonSach.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MetroFramework.MetroMessageBox.Show(this, "Export Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void btnReportSach_Click(object sender, EventArgs e)
        {
            frmReportDDS frm = new frmReportDDS();
            frm.ShowDialog();
        }



        //

        private void TileTraCuuSach_Click(object sender, EventArgs e)
        {
            //reset
            lblTitel_Click(sender, e);

            panelTraCuuSach.Visible = true;
            panelTraCuuSach.Location = new Point(250, 137);
            panelTraCuuSach.Size = new Size(830, 260);
            //

            lblTieuTeTabQL.Visible = true;
            lblTieuTeTabQL.Text = "Danh Sách Các Loại Sách Trong Thư Viện";
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Tắt... ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void IconCaiDat_Click(object sender, EventArgs e)
        {
            this.TabMain.SelectedTab = TabCaiDat;
        }

        //------
        





        private void Main_Load(object sender, EventArgs e)
        {

            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
            GridViewCaiDat.DataSource = KiemTra.DGVCaiDat();
           

            TileTraCuuSach.Text = "Tra Cứu Sách";
            TileLapPhieuMuon.Text = "Lập Thẻ\r\nThư Viện";
            TileNhanTraSach.Text = "Thêm Sách\r\nNhận Sách";
            TileThayDoiQuyDinh.Text = "Thay Đổi\r\nQuy Định";

            //Mặc Định---------------------------------------
            Class.CaiDat Setting = new Class.CaiDat();
            Setting = KiemTra.LayThongTinCaiDat();
            TuoiMuonSach = Setting.TuoiMuonSach;
            GiaTriThe = Setting.HanSuDungThe;  
            NgayMuonToiDa = Setting.NgayMuonToiDa;  
            SoLuongMuonToiDa = Setting.SachMuonToiDa;

            if (TuoiMuonSach != 6 || GiaTriThe != 6 || NgayMuonToiDa != 4 || SoLuongMuonToiDa != 5)
            {
                ToggleDefaul.Checked = false;
            }


            //TileAbout.text
            TileAbout.Text = "Tên:Nguyễn Anh Kiệt   MSSV:1461426     SĐT:01674678354\r\nNguyễn F R   1461426     +841674678354\r\nNguyễn Anh E   1461426     +841674678354\r\nNguyễn Anh W   1461426     +841674678354\r\nNguyễn Anh Q   1461426     +841674678354";

          
            NguoiDung User = KiemTra.LoadThongTinNguoiDung(IdNguoiDung);

            TileNameQuanLy.Text = User.Ten;
            try
            {
                TileQuanLy.Image = Image.FromStream(KiemTra.ReadImage(IdNguoiDung));
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            
        }
    }
}
    

