using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HardwareSupplier.Models
{
    public class SupplierDBHandle
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["supplierconn"].ToString();
            con = new SqlConnection(constring);
        }

        public bool AddSupplier(SupplierModel smodel)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", smodel.Id);
            cmd.Parameters.AddWithValue("@Name", smodel.Name);
            cmd.Parameters.AddWithValue("@Address", smodel.Address);
            cmd.Parameters.AddWithValue("@MobileNumber", smodel.MobileNumber);
            cmd.Parameters.AddWithValue("@State", smodel.State);
            cmd.Parameters.AddWithValue("@City", smodel.City);
            cmd.Parameters.AddWithValue("@Pincode", smodel.Pincode);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

            public List<SupplierModel> DisplayDetail()
        {
            connection();
            List<SupplierModel> supplierlist = new List<SupplierModel>();
 
            SqlCommand cmd = new SqlCommand("DisplayDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
 
            con.Open();
            sd.Fill(dt);
            con.Close();
 
            foreach(DataRow dr in dt.Rows)
            {
                supplierlist.Add(
                    new SupplierModel
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        Name = Convert.ToString(dr["name1"]),
                        Address = Convert.ToString(dr["address"]),
                        MobileNumber = Convert.ToString(dr["mobilenumber"]),
                        State = Convert.ToString(dr["state"]),
                        City = Convert.ToString(dr["city"]),
                        Pincode = Convert.ToString(dr["pincode"])
                    });
            }
            return supplierlist;
        }


        }
    }
