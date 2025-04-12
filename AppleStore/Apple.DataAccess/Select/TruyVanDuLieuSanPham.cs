using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace AppleStore.DataAccess.Select
{
   public class TruyVanDuLieuSanPham
    {
       public SqlDataSource Laydulieu()
       {
           SqlDataSource sqldata = new SqlDataSource();
           KetNoi chuoiketnoi = new KetNoi();
           sqldata.ConnectionString = chuoiketnoi.ConnectionString();
           sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
           sqldata.SelectCommand = "SanPham_Select";
           return sqldata;
       }
    }
}
