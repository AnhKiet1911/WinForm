using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDQL
{
    public partial class PhieuMuonSach : MetroFramework.Forms.MetroForm
    {
        public PhieuMuonSach()
        {
            InitializeComponent();
            ControlBox = false;
        }


        string MaVe_FormMain;
        int SoNgayMuonSachToiDa = 4;
        int SoLuongSachMuonToiDa = 5;


        public void GetPassData_FormMain(string str)
        {

            MaVe_FormMain = str;
        }

        public void GetNgayToiDaMuon_FormMain(int NgayToiDa)
        {

            SoNgayMuonSachToiDa = NgayToiDa;
        }
        public void GetLuongSach_FormMain(int SoLuongSach)
        {

            SoLuongSachMuonToiDa = SoLuongSach;
        }




        private void PhieuMuonSach_Load(object sender, EventArgs e)
        {
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            CboxSachTrongKho.DataSource = KiemTra.ComboxSach_FrmPhieuMuon();
            CboxSachTrongKho.DisplayMember = "TenSach";
            CboxSachTrongKho.ValueMember = "MaSach";

            lblTenDocGia.Text = KiemTra.TenDocGia_PhieuMuon(MaVe_FormMain);
            lblNgayMuon.Text = DateTime.Now.Day.ToString() + " - " + DateTime.Now.Month.ToString() + " - " + DateTime.Now.Year.ToString();

            GridViewSachMuon.DataSource = KiemTra.InfoSach_DgvTemp();
            lblThongBaoMuonSach.Text = string.Format("Độc Giả Phải Trả Lại Sách Trong Vòng {0} Ngày Kể Từ Ngày Mượn", SoNgayMuonSachToiDa);


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            if (stt != "")
            {
                KiemTra.Plus_SoLuongSach(KiemTra.LayMaSach_TempView(Convert.ToInt32(stt)));
                KiemTra.RemoveSach_DgvTemp(Convert.ToInt32(stt));

                GridViewSachMuon.DataSource = KiemTra.InfoSach_DgvTemp();
                //reset stt;
                stt = "";
                txtRemoveBook.Clear();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Chưa Chọn Dòng Cần Xoá", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Class.Book_Temp BT = new Class.Book_Temp();
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
            string MaSach = CboxSachTrongKho.SelectedValue.ToString();

          

            if (KiemTra.TinhTrangSach(MaSach) == true) 
            {
                if (KiemTra.LaySTTSachMuon(SoLuongSachMuonToiDa) == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, string.Format("Chỉ Được Mượn Tối Đa {0} Quyển Sách",SoLuongSachMuonToiDa), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    
                    BT = KiemTra.LayTongTinSach_DgvTemp(MaSach);
                    BT.STT = KiemTra.LaySTTSachMuon(SoLuongSachMuonToiDa);
                    BT.MaSach = MaSach;
                    KiemTra.ThemSachVao_DgvTemp(BT);
                    GridViewSachMuon.DataSource = KiemTra.InfoSach_DgvTemp();
                    KiemTra.Sub_SoLuongSach(MaSach);
                }
             
               
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Tạm Thời Hết Sách Này", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        string stt = "";
        private void GridViewSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRemoveBook.Clear();
            
            if (GridViewSachMuon.Rows.Count > 0 && GridViewSachMuon.DataSource != null)
            {
                txtRemoveBook.Text = GridViewSachMuon.SelectedRows[0].Cells[1].Value.ToString();
                stt = GridViewSachMuon.SelectedRows[0].Cells[0].Value.ToString();               
            }
            else
            {
                MessageBox.Show("Hiện Chưa Có Thông Tin Gì Để Chọn");
            }
        }

        private void btnDatThe_Click(object sender, EventArgs e)
        {


            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            if (KiemTra.DemSachTemp() < 1)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Đặt Sách ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int SoLuongSach = KiemTra.DemSachTemp();
                    int STT;
                    string MaSach;
                    KiemTra.XoaPhieuMuonSach(MaVe_FormMain);
                    KiemTra.PhieuMuonSach(lblNgayMuon.Text, MaVe_FormMain);

                    for (int i = 0; i < SoLuongSach; i++)
                    {
                        STT = Convert.ToInt32(GridViewSachMuon.Rows[i].Cells[0].Value.ToString());
                        MaSach = KiemTra.LayMaSach_TempView(STT);

                        KiemTra.ChiTietMuonSach(MaSach, STT, MaVe_FormMain);

                    }


                    //clear DGV_Temp
                    KiemTra.DeleteAll_DgvTemp();
                    MetroFramework.MetroMessageBox.Show(this, string.Format("Đặt Thành Công Cho Độc Giả : {0}", lblTenDocGia.Text), "Thông Báo");
                    this.Close();
                }
            }
        }

        private void GridViewSachMuon_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
            if (KiemTra.DemSachTemp() < 1)
            {
                btnDatThe.Visible = true;
                btnDatThe2.Visible = false;
                lblDat_Close.Visible = true;
                lblDatthe2.Visible = false;

            }
            else
            {
                btnDatThe.Visible = false;
                btnDatThe2.Visible = true;
                lblDat_Close.Visible = false;
                lblDatthe2.Visible = true;
            }
        }
    }
}
