using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Barroc_IT
{
    class DBHandler
    {
        private SqlConnection con;

        public void Init()
        {
            con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Barroc_IT_Final;Integrated Security=True");
        }

        public bool TestConnection()
        {
            if (!IsOpen())
            {
                try
                {
                    if (IsOpen())
                    {
                        con.Close();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool Connect()
        {
            if (!IsOpen())
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return false;
        }

        public bool Disconnect()
        {
            if (IsOpen())
            {
                try
                {
                    con.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return false;
        }

        //public DataTable FillDT(string query)
        //{
        //    con.Open();

        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetCon());
        //    DataTable dt = new DataTable();
        //    dataAdapter.Fill(dt);

        //    Disconnect();

        //    return dt;
        //}

        public SqlConnection GetCon()
        {
            return con;
        }

        private bool IsOpen()
        {
            return con.State == ConnectionState.Open;
        }

        public bool CheckLoginData(string username, string password, ref Role role)
        {
            Connect();
            try
            {
                SqlDataReader dataReader = new SqlCommand("SELECT * FROM tbl_Login", con).ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader["ussername"].ToString().Trim() == username && dataReader["password"].ToString().Trim() == password)
                    {
                        MessageBox.Show("Login succes");

                        switch ((int)dataReader["id"])
                        {
                            case 1:
                                role = Role.Development; break;
                            case 2:
                                role = Role.Finance; break;
                            case 3:
                                role = Role.Sales; break;
                        }

                        dataReader.Close();

                        return true;
                    }
                }
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Wrong username and/or wrong password");
            return false;
        }
    }
}