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
    public partial class SuaSachTrongKho : MetroFramework.Forms.MetroForm
    {
        public SuaSachTrongKho()
        {
            InitializeComponent();
            ControlBox = false; 
        }


        string MaSach_FormMain;



        public void GetPassData_FormMain(string str)
        {

            MaSach_FormMain = str;
        }

        private void SuaSachTrongKho_Load(object sender, EventArgs e)
        {
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            Class.Sach Book = KiemTra.InfoSach(MaSach_FormMain);

            lblMaSach.Text = Book.MaSach;
            txtTenSach.Text = Book.TenSach;
            UpDownSL.Value = Book.SoLuong;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();

            KiemTra.CapNhatSachTrongKho(Convert.ToInt32(UpDownSL.Value), MaSach_FormMain);
            MetroFramework.MetroMessageBox.Show(this, string.Format("Sửa Thẻ Thành Công Sách:{0} ", txtTenSach.Text));
            this.Close();
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
