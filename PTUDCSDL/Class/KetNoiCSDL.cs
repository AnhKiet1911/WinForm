using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUDQL
{
    class KetNoiCSDL
    {
        public static SqlConnection KetNoiSQL()
        {
            var Con = new SqlConnection();
            Con.ConnectionString = "Data Source=AK-PC;Initial Catalog=QuanLyThuVien;Integrated Security=True";//Đường dẫn database
            return Con;
        }
    }
}
