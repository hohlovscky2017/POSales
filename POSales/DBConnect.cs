﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSales
{
    class DBConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;
        public string myConnection()
        {
            con = @"Data Source=DESKTOP-E3LB6O2\SQLEXPRESS;Initial Catalog=DBPOSALE;Integrated Security=True;Encrypt=False";
            return con;
        }

        public DataTable getTable(string query)
        {
            cn.ConnectionString = myConnection();
            cm = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
