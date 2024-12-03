using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BanBUS
    {

        BanDAL BanDAL = new BanDAL();
        //load ban
        public List<BanET> LoadBan()
        {
            List<BanET> list = new List<BanET>();
            DataTable dt = BanDAL.DanhSachBan();
            foreach (DataRow item in dt.Rows)
            {
                BanET t = new BanET(item);
                list.Add(t);
            }
            return list;
        }
        //hien thi ban
        public DataTable DanhSachBan()
        {
            return BanDAL.DanhSachBan();
        }
        //them ban
        public int ThemBan(BanET tableET)
        {
            return BanDAL.ThemBan(tableET);
        }
        //sua ban
        public int SuaBan(BanET tableET)
        {
            return BanDAL.SuaBan(tableET);
        }
        //sua trang thai ban
        public int SuaTrangThaiBan(BanET tableET)
        {
            return BanDAL.SuaBan(tableET);
        }
        //Xoa ban
        public int XoaBan(BanET tableET)
        {
            return BanDAL.XoaBan(tableET);
        }
        //Tong so ban
        public object TongSoBan()
        {
            return BanDAL.TongSoBan();
        }
    }
}
