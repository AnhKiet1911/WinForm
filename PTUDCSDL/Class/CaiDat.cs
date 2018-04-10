using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUDQL.Class
{
    class CaiDat
    {
        int _TuoiMuonSach;
        int _HanSuDungThe;
        int _NgayMuonToiDa;
        int _SachMuonToiDa;

        public int TuoiMuonSach
        {
            get
            {
                return _TuoiMuonSach;
            }

            set
            {
                _TuoiMuonSach = value;
            }
        }

        public int HanSuDungThe
        {
            get
            {
                return _HanSuDungThe;
            }

            set
            {
                _HanSuDungThe = value;
            }
        }

        public int NgayMuonToiDa
        {
            get
            {
                return _NgayMuonToiDa;
            }

            set
            {
                _NgayMuonToiDa = value;
            }
        }

        public int SachMuonToiDa
        {
            get
            {
                return _SachMuonToiDa;
            }

            set
            {
                _SachMuonToiDa = value;
            }
        }
    }
}
