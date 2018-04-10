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
    public partial class LapTheDocGia : MetroFramework.Forms.MetroForm
    {
        public LapTheDocGia()
        {
            InitializeComponent();
            ControlBox = false;
        }

        string IdNguoiDung_FormMain;
        //
        int TuoiMuonSach = 6; 
        int GiaTriThe = 6;     
        

        //Sử Lý Lỗi Không Nhập Hết Các Ô dữ liệu mà vẩn Enter
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



        public void GetPassData_FormMain(string str)
        {
            
            IdNguoiDung_FormMain = str;
        }

        public void GetTuoi_FormMain(int Tuoi_MuonSach)
        {

            TuoiMuonSach = Tuoi_MuonSach;
        }
        public void GetHanSuDung_FormMain(int HanSuDung)
        {

            GiaTriThe = HanSuDung;
        }


        private void LapTheDocGia_Load(object sender, EventArgs e)
        {

            txtHoTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            ntxtCMND.Clear();
            ntxtPhone.Clear();
            rdNam.Checked = true;
            dateTimePicker1.ResetText();

            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            lblGiaTriThe.Text = string.Format("Thẻ Có Giá Trị {0} Tháng Kể Từ Ngày Lập Thẻ", GiaTriThe);
            txtLoaiDocGia.Text = "Chưa Đủ Điều Kiện Mượn Sách";
            lblMaThe.Text = KiemTra.LayIdDocGia().ToString();
            lblNgayLap.Text = DateTime.Now.Day.ToString() + " - " + DateTime.Now.Month.ToString() + " - " + DateTime.Now.Year.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            if ((DateTime.Now.Year - dateTimePicker1.Value.Year) > TuoiMuonSach &&(DateTime.Now.Year - dateTimePicker1.Value.Year) < 18) 
            {
                txtLoaiDocGia.Text = "Độc Giả Vị Thành Niên";
            }
            else if((DateTime.Now.Year - dateTimePicker1.Value.Year) >= 18 && (DateTime.Now.Year - dateTimePicker1.Value.Year) < 35)
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
            else if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Đặt Thẻ ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class.TheDocGia The = new Class.TheDocGia();

                The.IdNguoiLap = IdNguoiDung_FormMain;
                The.HoTen = txtHoTen.Text;
                The.DiaChi = txtDiaChi.Text;
                The.Phone = ntxtPhone.Text;
                The.NgaySinh = dateTimePicker1.Value.ToString();

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
                The.IdDocGia = Convert.ToInt32(lblMaThe.Text);


                Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                KiemTra.LapTheDocGia(The);
                MetroFramework.MetroMessageBox.Show(this, string.Format("Đặt Thẻ Thành Công Cho Đôc Giả :{0} ", The.HoTen));
                LapTheDocGia_Load(sender, e);
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
