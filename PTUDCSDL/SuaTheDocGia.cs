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
    public partial class SuaTheDocGia : MetroFramework.Forms.MetroForm
    {
        public SuaTheDocGia()
        {
            InitializeComponent();
            ControlBox = false;
        }

        int IdDocGia_FormMain;
        int GiaTriThe = 6;
        int TuoiMuonSach = 6;


        public void GetPassData_FormMain(int str)
        {

            IdDocGia_FormMain = str;
        }
        public void GetTuoiDatThe_FormMain(int Tuoi)
        {

            TuoiMuonSach = Tuoi;
        }
        public void GetHanDung_FormMain(int HanDung)
        {

            GiaTriThe = HanDung;
        }

        //
        private void Visible_Sao()
        {
            Sao1.Visible = false;
            Sao4.Visible = false;
            Sao2.Visible = false;
            Sao3.Visible = false;
            Sao5.Visible = false;
        }

        private bool Compelete()
        {
            if (txtHoTen.Text == "")
            {
                Sao1.Visible = true;
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                Sao2.Visible = true;
                return false;
            }
            if (ntxtPhone.Text == "")
            {
                Sao3.Visible = true;
                return false;
            }
            if (txtEmail.Text == "")
            {
                Sao4.Visible = true;
                return false;
            }
            if (ntxtCMND.Text == "")
            {
                Sao5.Visible = true;
                return false;
            }

            return true;
        }


        //
        private void LapTheDocGia_Load(object sender, EventArgs e)
        {

          

            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            Class.TheDocGia The = KiemTra.InfoPhieuDocGia(IdDocGia_FormMain);

            txtHoTen.Text = The.HoTen;
            txtEmail.Text=The.Mail;
            txtDiaChi.Text = The.DiaChi;
            ntxtCMND.Text = The.CMND;
            ntxtPhone.Text = The.Phone;
            if (The.GioiTinh=="Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }


           
            dateTimePicker1.Value = DateTime.Parse(The.NgaySinh);


            lblGiaTriThe.Text = string.Format("Thẻ Có Giá Trị {0} Tháng Kể Từ Ngày Lập Thẻ", GiaTriThe);
            lblMaThe.Text = The.MaVe;
            lblNgayLap.Text = The.NgayLapThe;
           





        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if ((DateTime.Now.Year - dateTimePicker1.Value.Year) > TuoiMuonSach && (DateTime.Now.Year - dateTimePicker1.Value.Year) < 18)
            {
                txtLoaiDocGia.Text = "Độc Giả Vị Thành Niên";
            }
            else if ((DateTime.Now.Year - dateTimePicker1.Value.Year) >= 18 && (DateTime.Now.Year - dateTimePicker1.Value.Year) < 35)
            {
                txtLoaiDocGia.Text = "Độc Giả Trẻ";
            }
            else if ((DateTime.Now.Year - dateTimePicker1.Value.Year) >= 35)
            {
                txtLoaiDocGia.Text = "Độc Giả Trung Niên";
            }
            else
            {
                txtLoaiDocGia.Text = "Chưa Đủ Điều Kiện Mượn Sách";
            }
        }

        private void btnDatThe_Click(object sender, EventArgs e)
        {
            Visible_Sao();
            if (Compelete() == false)
            {

            }
            else if ((DateTime.Now.Year - dateTimePicker1.Value.Year) <= TuoiMuonSach)
            {
                MetroFramework.MetroMessageBox.Show(this, "Độc Giả Chưa Đủ Độ Tuổi Mượn Sách", "Không Được Phép", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Sửa Thẻ Này", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class.TheDocGia The = new Class.TheDocGia();


                The.HoTen = txtHoTen.Text;
                The.DiaChi = txtDiaChi.Text;
                The.Phone = ntxtPhone.Text;
                The.NgaySinh = dateTimePicker1.Text.ToString();

                if (rdNam.Checked == true)
                {
                    The.GioiTinh = "Nam";
                }
                else
                {
                    The.GioiTinh = "Nữ";
                }
                The.Mail = txtEmail.Text;
                The.CMND = ntxtCMND.Text;
                The.LoaiDocGia = txtLoaiDocGia.Text;
                The.MaVe = lblMaThe.Text;
                The.NgayLapThe = lblNgayLap.Text;



                Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                KiemTra.SuaTheDocGia(The, IdDocGia_FormMain);
                MetroFramework.MetroMessageBox.Show(this, string.Format("Sửa Thẻ Thành Công Cho Độc Giả :{0} ", The.HoTen));
                this.Close();
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
