using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;


namespace QL_BanHang.Control
{
    class KhachHangCtr
    {
        KhachHangMod khMod = new KhachHangMod();
        public string AutoUpdateFK()
        {
            return khMod.AutoUpdateFK();
        }
        public DataTable GetData()
        {
            return khMod.GetData();
        }
        public bool AddData(KhachHangObj khObj)
        {
            return khMod.AddData(khObj);
        }
        public bool UpdData(KhachHangObj khObj)
        {
            return khMod.UpdData(khObj);
        }

        public bool UpdDiem(KhachHangObj khObj)
        {
            return khMod.UpdDiem(khObj);
        }

        public bool DelData(string ma)
        {
            return khMod.DelData(ma);
        }
        public int GetDiem(string ma)
        {
            return khMod.GetDiem(ma);
        }
    }
}
