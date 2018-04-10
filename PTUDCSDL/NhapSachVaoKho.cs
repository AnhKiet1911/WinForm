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
    public partial class ThongTinSach : MetroFramework.Forms.MetroForm
    {
        public ThongTinSach()
        {
            InitializeComponent();
            ControlBox = false;
        }


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
            if (txtTenSach.Text == "")
            {
                Sao1.Visible = true;
                return false;
            }
            if (txtTheLoai.Text == "")
            {
                Sao2.Visible = true;
                return false;
            }
            if (txtTacGia.Text == "")
            {
                Sao3.Visible = true;
                return false;
            }
            if (txtNhaXuatBan.Text == "")
            {
                Sao4.Visible = true;
                return false;
            }
            if (UpDownSL.Value == 0)
            {
                Sao5.Visible = true;
                return false;
            }

            return true;
        }




        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            Visible_Sao();
            if (Compelete() == false)
            {

            }
            else if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Đặt Thẻ ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class.Sach Hon = new Class.Sach();

                Hon.TenSach = txtTenSach.Text;
                Hon.TheLoai = txtTheLoai.Text;
                Hon.TacGia = txtTacGia.Text;
                Hon.NamXuatBan = UpDownNam.Value.ToString();
                Hon.NhaSanXuat = txtNhaXuatBan.Text;
                Hon.NgayVaoKho = dateTimePicker1.Text;
                Hon.SoLuong = Convert.ToInt32(UpDownSL.Value);


                Hon.MaSach = lblMaSach.Text;
               


                Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                KiemTra.ThemSachVaoKho(Hon);
               
                MetroFramework.MetroMessageBox.Show(this, string.Format("Đặt Sách :{0}: Thành Công ", Hon.TenSach));
                ThongTinSach_Load(sender, e);
            }
        }

        private void ThongTinSach_Load(object sender, EventArgs e)
        {
            txtTenSach.Clear();
            txtTheLoai.ResetText();
            txtTacGia.ResetText();
            UpDownSL.ResetText();
            txtNhaXuatBan.ResetText();
            dateTimePicker1.ResetText();
           

          
            txtTenSach_TextChanged(sender, e);
            
            

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSach.Text != "" && txtTheLoai.Text != "" && txtTacGia.Text != "")
            {         //2 Chữ cái đầu tiên của tên sách Chữ cái đầu tiên của thể loai sách  Chữ cái đầu tiên của tác giả  2 số cuối năm xuất bản 
                lblMaSach.Text = txtTenSach.Text.Substring(0, 1) + txtTheLoai.Text.Substring(0, 1) + txtTacGia.Text.Substring(0, 1) + UpDownNam.Value.ToString().Substring(2);
            }
        }

      
    }
}
