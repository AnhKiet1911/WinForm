using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUDQL.Class
{
    class Book_Temp
    {
        string _MaSach;
        string _TenSach;
        string _TheLoai;
        string _TacGia;
        int _STT;

        public string TacGia
        {
            get
            {
                return _TacGia;
            }

            set
            {
                _TacGia = value;
            }
        }

        public string TheLoai
        {
            get
            {
                return _TheLoai;
            }

            set
            {
                _TheLoai = value;
            }
        }

        public string TenSach
        {
            get
            {
                return _TenSach;
            }

            set
            {
                _TenSach = value;
            }
        }

        public string MaSach
        {
            get
            {
                return _MaSach;
            }

            set
            {
                _MaSach = value;
            }
        }

        public int STT
        {
            get
            {
                return _STT;
            }

            set
            {
                _STT = value;
            }
        }
    }
}
