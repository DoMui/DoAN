using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_CTHoaDonXuat
    {
        DAL_CTHoaDonXuat daCTHDX = new DAL_CTHoaDonXuat();
        public DataTable getCTHDX()
        {
            return daCTHDX.getCTHDX();
        }
        public int kiemtramatrung(int maCTHDX)
        {
            return daCTHDX.kiemtramatrung(maCTHDX);
        }
        public bool themCTHDX(DTO_CTHoaDonXuat CTHDX)
        {
            return daCTHDX.themCTHDX(CTHDX);
        }
        public bool suaCTHDX(DTO_CTHoaDonXuat CTHDX)
        {
            return daCTHDX.suaCTHDX(CTHDX);
        }
        public bool xoaCTHDX(int maCTHDX)
        {
            return daCTHDX.xoaCTHDX(maCTHDX);
        }
    }
}
