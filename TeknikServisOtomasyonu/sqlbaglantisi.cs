﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TeknikServisOtomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = DESKTOP-7SB9ON7\SQLEXPRESS; Initial Catalog = TeknikServis; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
