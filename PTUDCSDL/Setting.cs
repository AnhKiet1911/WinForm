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
    public partial class Setting : MetroFramework.Forms.MetroForm
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            Class.CaiDat  St = new Class.CaiDat();

            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();


            St = KiemTra.LayThongTinCaiDat();
            UpDownTuoi.Value = St.TuoiMuonSach;
            UpDownThang.Value = St.HanSuDungThe;
            UpDownQuyen.Value = St.SachMuonToiDa;
            UpDownNgay.Value = St.NgayMuonToiDa;

        }

        private void btnOkey_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn", "Xác Nhận Thay Đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class.CaiDat St = new Class.CaiDat();
                St.TuoiMuonSach = Convert.ToInt32(UpDownTuoi.Value);
                St.HanSuDungThe = Convert.ToInt32(UpDownThang.Value);
                St.SachMuonToiDa = Convert.ToInt32(UpDownQuyen.Value);
                St.NgayMuonToiDa = Convert.ToInt32(UpDownNgay.Value);


                Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
                KiemTra.CaiDatThuVien(St);
                this.Close();
            }

        }

        private void metroLink9_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Chắc Chắn Hay Không", "Bạn Muốn Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
