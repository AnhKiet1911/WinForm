using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Collections;
using System.IO;

namespace LTUDQL.Class
{

    class XuLyThuVien
    {
       static Data.QuanLyThuVienDataContext KetNoi  = null;
       
       
        public int DangNhap(string Id ,string Passwd)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();

            var Query = (from Login in KetNoi.TaiKhoans
                         where Login.IdNguoiDung == Id.Trim() && Login.PassND == Passwd
                         select Login).SingleOrDefault();
                
            if (Query == null)
            {
                return 0;
            }
            return 1;
        }



        public Stream ReadImage(string IdNguoiDung)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();

            var Query = (from p in KetNoi.Anhs
                        where p.IdNguoiDung == IdNguoiDung
                        select p.Images).First();

            return new MemoryStream(Query.ToArray());

        }

        public void UpdateAvatar(string IdNguoiDung, Binary AnhNguoiDung)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            Data.Anh Temp2 = new Data.Anh();
            Temp2 = KetNoi.Anhs.Where(s => s.IdNguoiDung == IdNguoiDung).Single();
            Temp2.Images = AnhNguoiDung;
            KetNoi.SubmitChanges();
        }


        public NguoiDung LoadThongTinNguoiDung(string IdNguoiDung)
        {

            NguoiDung Temp = new NguoiDung();
            KetNoi = new Data.QuanLyThuVienDataContext();

            //LayTen
            Temp.Ten = (from linq in KetNoi.TaiKhoans
                        where linq.IdNguoiDung == IdNguoiDung
                        select linq.HoTen).Single();

            //LayGioiTinh
            Temp.GioiTinh = (from linq in KetNoi.TaiKhoans
                             where linq.IdNguoiDung == IdNguoiDung
                             select linq.GioiTinh).Single();

            //LayNgaySinh
            Temp.NgaySinh = (from linq in KetNoi.TaiKhoans
                             where linq.IdNguoiDung == IdNguoiDung
                             select linq.NgaySinh).Single();

            int index = Temp.NgaySinh.IndexOf(" ");
            if (index != -1)
            {
                Temp.NgaySinh = Temp.NgaySinh.Substring(0, index);
            }

            //LayDienThoai
            Temp.SoDienThoai = (from linq in KetNoi.TaiKhoans
                                where linq.IdNguoiDung == IdNguoiDung
                                select linq.SoDT).Single();

            //LayDiaChi
            Temp.DiaChi = (from linq in KetNoi.TaiKhoans
                           where linq.IdNguoiDung == IdNguoiDung
                           select linq.DiaChi).Single();


            return Temp;


        }


        public void LapTheDocGia(TheDocGia TheDocGia)
        {

            Data.LapPhieu Temp = new Data.LapPhieu();
            Data.DocGia Temp2 = new Data.DocGia();

            Temp.IdNguoiLap = TheDocGia.IdNguoiLap;
            Temp.MaPhieu = TheDocGia.MaVe;



            Temp2.IdDocGia = TheDocGia.IdDocGia;
            Temp2.TenDocGia = TheDocGia.HoTen;
            Temp2.NgaySinh = TheDocGia.NgaySinh;
            Temp2.CMND = TheDocGia.CMND;
            Temp2.GioiTinh = TheDocGia.GioiTinh;
            Temp2.DiaChi = TheDocGia.DiaChi;
            Temp2.SDT = TheDocGia.Phone;
            Temp2.Email = TheDocGia.Mail;
            Temp2.LoaiDocGia = TheDocGia.LoaiDocGia;
            Temp2.NgayLap = TheDocGia.NgayLapThe;
            Temp2.MaPhieu = TheDocGia.MaVe;





            KetNoi = new Data.QuanLyThuVienDataContext();

            KetNoi.LapPhieus.InsertOnSubmit(Temp);
            KetNoi.DocGias.InsertOnSubmit(Temp2);
            KetNoi.SubmitChanges();

        }


        public int LayIdDocGia()
        {
            int Temp = 0;

            KetNoi = new Data.QuanLyThuVienDataContext();


            var Query = (from DK in KetNoi.DocGias
                         select DK).FirstOrDefault();

            if (Query == null)
            {
                return Temp = 1;
            }

            else
            {

                Temp = (from linq in KetNoi.DocGias
                        select linq.IdDocGia).Max();
                return (Temp+1);
            }

        }

        public IQueryable DataViewTheDocGia()
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            IQueryable sql = (from DG in KetNoi.DocGias
                      select new {DG.IdDocGia,DG.TenDocGia,DG.NgaySinh,DG.CMND,DG.GioiTinh,DG.DiaChi,DG.SDT,DG.Email,DG.LoaiDocGia,DG.NgayLap ,DG.MaPhieu});
           

            return sql;
        }




        //
        public TheDocGia InfoPhieuDocGia(int IdDocGia)
        {


            TheDocGia Temp = new TheDocGia();
            KetNoi = new Data.QuanLyThuVienDataContext();

            //LayTen
            Temp.HoTen = (from linq in KetNoi.DocGias
                          where linq.IdDocGia == IdDocGia
                          select linq.TenDocGia).Single();

            //LayGioiTinh
            Temp.GioiTinh = (from linq in KetNoi.DocGias
                             where linq.IdDocGia == IdDocGia
                             select linq.GioiTinh).Single();

            //LayNgaySinh
            Temp.NgaySinh = (from linq in KetNoi.DocGias
                             where linq.IdDocGia == IdDocGia
                             select linq.NgaySinh).Single();

            //LayDienThoai
            Temp.Phone = (from linq in KetNoi.DocGias
                          where linq.IdDocGia == IdDocGia
                          select linq.SDT).Single();

            //LayDiaChi
            Temp.DiaChi = (from linq in KetNoi.DocGias
                           where linq.IdDocGia == IdDocGia
                           select linq.DiaChi).Single();

            //LayCMND

            Temp.CMND = (from linq in KetNoi.DocGias
                         where linq.IdDocGia == IdDocGia
                         select linq.CMND).Single();

            //LayMail

            Temp.Mail = (from linq in KetNoi.DocGias
                         where linq.IdDocGia == IdDocGia
                         select linq.Email).Single();

            //LayNgayLap

            Temp.NgayLapThe = (from linq in KetNoi.DocGias
                               where linq.IdDocGia == IdDocGia
                               select linq.NgayLap).Single();

            //LayMaPhieu

            Temp.MaVe = (from linq in KetNoi.DocGias
                         where linq.IdDocGia == IdDocGia
                         select linq.MaPhieu).Single();


            return Temp;
        }

        //
        public void SuaTheDocGia(TheDocGia TheDocGia, int IdDocGia)
        {


            KetNoi = new Data.QuanLyThuVienDataContext();
            Data.DocGia Temp2 = new Data.DocGia();
            Temp2 = KetNoi.DocGias.Where(s => s.IdDocGia == IdDocGia).Single();
            Temp2.TenDocGia = TheDocGia.HoTen;
            Temp2.NgaySinh = TheDocGia.NgaySinh;
            Temp2.CMND = TheDocGia.CMND;
            Temp2.GioiTinh = TheDocGia.GioiTinh;
            Temp2.DiaChi = TheDocGia.DiaChi;
            Temp2.SDT = TheDocGia.Phone;
            Temp2.Email = TheDocGia.Mail;
            Temp2.LoaiDocGia = TheDocGia.LoaiDocGia;


            KetNoi.SubmitChanges();
        }


        public void XoaTheDocGia(int IdDocGia)
        {

            KetNoi = new Data.QuanLyThuVienDataContext();

            Data.DocGia Temp2 = new Data.DocGia();
            Data.LapPhieu Temp1 = new Data.LapPhieu();
            Temp2 = KetNoi.DocGias.Where(s => s.IdDocGia == IdDocGia).Single();
            Temp1 = KetNoi.LapPhieus.Where(s => s.MaPhieu == IdDocGia.ToString()).Single();
            KetNoi.DocGias.DeleteOnSubmit(Temp2);
            KetNoi.LapPhieus.DeleteOnSubmit(Temp1);
            KetNoi.SubmitChanges();


        }


        //


        public IQueryable DataViewDanhSachSach()
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            IQueryable sql = (from DG in KetNoi.Saches
                              select DG) /*new { DG.IdDocGia, DG.TenDocGia, DG.NgaySinh, DG.CMND, DG.GioiTinh, DG.DiaChi, DG.SDT, DG.Email, DG.LoaiDocGia, DG.NgayLap, DG.MaPhieu })*/;


            return sql;
        }


        //
        public void XoaSach(string MaSach)
        {

            KetNoi = new Data.QuanLyThuVienDataContext();


            Data.Sach Temp1 = new Data.Sach();
            Temp1 = KetNoi.Saches.Where(s => s.MaSach == MaSach.ToString()).Single();
            KetNoi.Saches.DeleteOnSubmit(Temp1);
            KetNoi.SubmitChanges();
        }
        //

        public void ThemSachVaoKho(Sach Book)
        {

            Data.Sach Temp = new Data.Sach();

            Temp.MaSach = Book.MaSach;
            Temp.TenSach = Book.TenSach;
            Temp.SoLuong = Book.SoLuong;
            Temp.NamXuatBan = Book.NamXuatBan;
            Temp.NhaXuatBan = Book.NhaSanXuat;
            Temp.NgayVaoKho = Book.NgayVaoKho;
            Temp.TheLoai = Book.TheLoai;
            Temp.TenTacGia = Book.TacGia;
            

            KetNoi = new Data.QuanLyThuVienDataContext();

            KetNoi.Saches.InsertOnSubmit(Temp); 
            KetNoi.SubmitChanges();

        }



        public Sach InfoSach(string MaSach)
        {
            
            Sach Temp = new Sach();
            KetNoi = new Data.QuanLyThuVienDataContext();

            //LayMaSach
            Temp.MaSach = MaSach;

            //LayTenSach
            Temp.TenSach = (from linq in KetNoi.Saches
                                where linq.MaSach == MaSach
                                select linq.TenSach).Single();

            //LaySoLuong
            Temp.SoLuong = Convert.ToInt32((from linq in KetNoi.Saches
                                where linq.MaSach == MaSach
                            select linq.SoLuong).Single());

              
            return Temp;
    
        }

        public void CapNhatSachTrongKho(int SoLuong,string MaSach)
        {

            KetNoi = new Data.QuanLyThuVienDataContext();
            Data.Sach Temp2 = new Data.Sach();
            Temp2 = KetNoi.Saches.Where(s => s.MaSach == MaSach).Single();
            Temp2.SoLuong = SoLuong;
            KetNoi.SubmitChanges();

        }

        public IList TraCuuSach(string str)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            var sql = (from timkiem in KetNoi.Saches
                              where timkiem.TheLoai.Contains(str)
                              || timkiem.TenSach.Contains(str)
                              select timkiem).ToList() ;

            return sql;
        }



        public bool MaPhieuTonTai(string MaPhieu)
        {

            KetNoi = new Data.QuanLyThuVienDataContext();
            var Query = (from Test in KetNoi.LapPhieus
                         where Test.MaPhieu == MaPhieu
                         select Test).SingleOrDefault();

            if (Query == null)
            {
                return false;
            }

            return true;
        }


        public IQueryable GVMuonSach()
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            IQueryable sql = (from p in KetNoi.PhieuMuonSaches
                              from d in KetNoi.DocGias
                              from l in KetNoi.LapPhieus

                              where (p.MaPhieu == l.MaPhieu) && (l.MaPhieu == d.MaPhieu)
                              select new { d.TenDocGia, p.NgayMuon ,p.MaMuon });

            return sql;
        }


        public string TenDocGiaMuonSach(string MaMuon)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();

            
           string temp  =(from p in KetNoi.PhieuMuonSaches
                          from d in KetNoi.DocGias
                          from l in KetNoi.LapPhieus

                          where (p.MaPhieu == l.MaPhieu) && (l.MaPhieu == d.MaPhieu) && (p.MaMuon == MaMuon)
                          select d.TenDocGia).Single();

            return temp;
        }




        public IQueryable InfoPhieuMuonSach(string MaMuon)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            IQueryable sql = (from p in KetNoi.PhieuMuonSaches
                              from c in KetNoi.ChiTietMuonSaches
                              from s in KetNoi.Saches

                              where (p.MaMuon == c.MaMuon) && (c.MaSach == s.MaSach) && (p.MaMuon == MaMuon)
                              select new {c.SoTT, s.TenSach,s.TheLoai,s.TenTacGia });

            return sql;
        }

       

        public string TenDocGia_PhieuMuon(string MaPhieu)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();


            string temp = (from d in KetNoi.DocGias
                           from l in KetNoi.LapPhieus

                           where (d.MaPhieu == l.MaPhieu) && (l.MaPhieu == MaPhieu)
                            select d.TenDocGia).Single();

            return temp;
        }

        public IQueryable ComboxSach_FrmPhieuMuon()
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            IQueryable sql = (from i in KetNoi.Saches
                              select i);
            return sql;
        }



        public bool TinhTrangSach(string MaSach)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            int Query = Convert.ToInt32((from Test in KetNoi.Saches
                         where Test.MaSach == MaSach
                         select Test.SoLuong).Single());

            if (Query < 1)
            {
                return false;
            }

            return true;
        }





        public void ThemSachVao_DgvTemp(Book_Temp Book)
        {
            Data.TempTable_MuonSach Temp = new Data.TempTable_MuonSach();
            
            
           
            Temp.Sach = Book.TenSach;
            Temp.TheLoai = Book.TheLoai;
            Temp.TacGia = Book.TacGia;
            Temp.STT = Book.STT;
            Temp.MaSach = Book.MaSach;

            KetNoi = new Data.QuanLyThuVienDataContext();

            KetNoi.TempTable_MuonSaches.InsertOnSubmit(Temp);
            KetNoi.SubmitChanges();

        }


        //view
        public IQueryable InfoSach_DgvTemp()
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            IQueryable sql = (from T in KetNoi.TempTable_MuonSaches
                              
                              select new { T.STT,T.Sach,T.TacGia,T.TheLoai});

            return sql;
        }


        //Lấy Thông Tin Sách Nhờ Mã Sách
        public Book_Temp LayTongTinSach_DgvTemp(string MaSach)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            Book_Temp Temp = new Book_Temp();

            Temp.TenSach = (from S in KetNoi.Saches
                           where S.MaSach == MaSach
                           select S.TenSach ).Single();

            Temp.TacGia = (from S in KetNoi.Saches
                            where S.MaSach == MaSach
                            select S.TenTacGia).Single();

            Temp.TheLoai = (from S in KetNoi.Saches
                            where S.MaSach == MaSach
                            select S.TheLoai).Single();

            return Temp;
        }



        //LaySoLuongSach
        public int LaySoLuongSach(string MaSach)
        {
            int SoLuong = Convert.ToInt32((from linq in KetNoi.Saches
                                            where linq.MaSach == MaSach
                                            select linq.SoLuong).Single());
            return SoLuong;
        }

        //Trừ SoLuongSach
        public void Sub_SoLuongSach(string MaSach)
        {
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
            int SoLuong = KiemTra.LaySoLuongSach(MaSach);

            KetNoi = new Data.QuanLyThuVienDataContext();
            Data.Sach Temp2 = new Data.Sach();
            Temp2 = KetNoi.Saches.Where(s => s.MaSach == MaSach).Single();
            Temp2.SoLuong = SoLuong - 1;
            KetNoi.SubmitChanges();
        }
        //Cộng SoLuongSach
        public void Plus_SoLuongSach(string MaSach)
        {
            Class.XuLyThuVien KiemTra = new Class.XuLyThuVien();
            int SoLuong = KiemTra.LaySoLuongSach(MaSach);

            KetNoi = new Data.QuanLyThuVienDataContext();
            Data.Sach Temp2 = new Data.Sach();
            Temp2 = KetNoi.Saches.Where(s => s.MaSach == MaSach).Single();
            Temp2.SoLuong = SoLuong + 1;
            KetNoi.SubmitChanges();
        }

        public int LaySTTSachMuon(int MaxiMum)
        {
            int Temp = 0;

            KetNoi = new Data.QuanLyThuVienDataContext();


            var Query = (from DK in KetNoi.TempTable_MuonSaches
                         select DK).FirstOrDefault();

            if (Query == null)
            {
                return Temp = 1;
            }

            else
            {

                Temp = (from linq in KetNoi.TempTable_MuonSaches
                        select linq.STT).Max();
                if (Temp < MaxiMum)
                {
                    return (Temp + 1);
                }
                else
                {
                    return Temp = 0;
                }
               
            }

        }

        // Lấy Mã Sách
        public string LayMaSach_TempView(int STT)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            string MaSach;

            MaSach = (from linq in KetNoi.TempTable_MuonSaches
                               where linq.STT == STT
                               select linq.MaSach).Single();

            return MaSach;

        }


        public void RemoveSach_DgvTemp(int STT)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();


            Data.TempTable_MuonSach Temp = new Data.TempTable_MuonSach();
            Temp = KetNoi.TempTable_MuonSaches.Where(s => s.STT == STT).Single();
            KetNoi.TempTable_MuonSaches.DeleteOnSubmit(Temp);
            KetNoi.SubmitChanges();
        }


        //Dếm Sách Mượn Tạm Trong Bảng TempView
        public int DemSachTemp()
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            int Temp = (from sql in KetNoi.TempTable_MuonSaches
                        select sql.STT).Count();
            // KetNoi.TempTable_MuonSaches.Count(); Count * form ......                   

            return Temp;

        }



        public void DeleteAll_DgvTemp()
        {

            KetNoi = new Data.QuanLyThuVienDataContext();
            KetNoi.ExecuteCommand("DELETE From TempTable_MuonSach");
        }




        //Đặt Sách ->Insert 2 bảng PhieuMuonSach và Chi Tiết Mượn Sách<-
        public void PhieuMuonSach(string NgayMuon,string MaMuon)
        {

          
            Data.PhieuMuonSach pms = new Data.PhieuMuonSach();

            pms.MaPhieu = MaMuon;
            pms.MaMuon = MaMuon;
            pms.NgayMuon = NgayMuon;

          
            KetNoi = new Data.QuanLyThuVienDataContext();


            KetNoi.PhieuMuonSaches.InsertOnSubmit(pms);
          
            
            KetNoi.SubmitChanges();
          
        }

        public void ChiTietMuonSach(string MaSach, int STT,string MaMuon)
        {

            Data.ChiTietMuonSach ctms = new Data.ChiTietMuonSach();
 
            ctms.SoTT = STT;
            ctms.MaSach = MaSach;
            ctms.MaMuon = MaMuon;

            KetNoi = new Data.QuanLyThuVienDataContext();
          
            KetNoi.ChiTietMuonSaches.InsertOnSubmit(ctms);


            KetNoi.SubmitChanges();

        }

        //XoaPhieuMuonSach

        public int MaPhieuMuonTonTai( string MaPhieu)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();

            var Query = (from p in KetNoi.PhieuMuonSaches
                         where p.MaPhieu == MaPhieu
                         select p).SingleOrDefault();

            if (Query == null)
            {
                return 0;
            }
            return 1;
        }
        public void XoaPhieuMuonSach(string  MaPhieu)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();


            Data.PhieuMuonSach Temp = new Data.PhieuMuonSach();
            if (MaPhieuMuonTonTai(MaPhieu)==1)
            {
                Temp = KetNoi.PhieuMuonSaches.Where(s => s.MaPhieu == MaPhieu).Single();
                KetNoi.PhieuMuonSaches.DeleteOnSubmit(Temp);
                KetNoi.SubmitChanges();
            }  
        }

        public void XoaChiTietMuonSach(string MaMuon)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();


           
            if (DaMuonSachRoi(MaMuon) == true)
            {
                var Temp = from sql in KetNoi.ChiTietMuonSaches where sql.MaMuon == MaMuon select sql;
                foreach (var item in Temp)
                {
                    KetNoi.ChiTietMuonSaches.DeleteOnSubmit(item);
                }
               
                KetNoi.SubmitChanges();
            }
        }



        public bool DaMuonSachRoi(string MaMuon)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();

            var Query = (from c in KetNoi.ChiTietMuonSaches
                         where c.MaMuon == MaMuon
                         select c).FirstOrDefault();

            if (Query == null) 
            {
                return false;
            }

            return true;
        }


        public IList LayMaSach(string MaMuon)
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            var sql = (from b in KetNoi.Saches
                       from c in KetNoi.ChiTietMuonSaches
                       where b.MaSach == c.MaSach && c.MaMuon == MaMuon
                       select b.MaSach).ToList();
            return sql;
        }


        public void CaiDatThuVien(Class.CaiDat Setting)
        {

            KetNoi = new Data.QuanLyThuVienDataContext();
            Data.CaiDat Temp = new Data.CaiDat();

            Temp = KetNoi.CaiDats.Where(s => s.i == 1).Single();

            Temp.TuoiMuonSach = Setting.TuoiMuonSach;
            Temp.HanSuDungThe = Setting.HanSuDungThe;
            Temp.NgayMuonToiDa = Setting.NgayMuonToiDa;
            Temp.SoLuongSachMuonToiDa = Setting.SachMuonToiDa;

            KetNoi.SubmitChanges();

        }

        public IQueryable DGVCaiDat()
        {

            KetNoi = new Data.QuanLyThuVienDataContext();
            IQueryable sql = (from T in KetNoi.CaiDats
                              select new {T.TuoiMuonSach,T.HanSuDungThe,T.NgayMuonToiDa,T.SoLuongSachMuonToiDa});
            return sql;

        }

        //Lấy Thông Tin Cai Dat
        public Class.CaiDat LayThongTinCaiDat()
        {
            KetNoi = new Data.QuanLyThuVienDataContext();
            Class.CaiDat Temp = new Class.CaiDat();

            Temp.TuoiMuonSach = Convert.ToInt32((from S in KetNoi.CaiDats
                                 select S.TuoiMuonSach).Single());

            Temp.HanSuDungThe = Convert.ToInt32((from S in KetNoi.CaiDats
                                                 select S.HanSuDungThe).Single());

            Temp.NgayMuonToiDa = Convert.ToInt32((from S in KetNoi.CaiDats
                                                 select S.NgayMuonToiDa).Single());

            Temp.SachMuonToiDa = Convert.ToInt32((from S in KetNoi.CaiDats
                                                 select S.SoLuongSachMuonToiDa).Single());

            return Temp;
        }

    }
}
