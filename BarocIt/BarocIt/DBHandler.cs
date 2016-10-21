using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarocIt
{
    class DBHandler
    {
        private static SqlConnection con;

        public static void Init()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\BarocItDb.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public static bool TestConnection()
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

        private static bool Connect()
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

        public static bool Disconnect()
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

                }
            }
            return false;
        }

        public static DataTable FillDT(string query)
        {
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetCon());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            Disconnect();

            return dt;
        }

        public static SqlConnection GetCon()
        {
            return con;
        }

        private static bool IsOpen()
        {
            return con.State == ConnectionState.Open;
        }

        internal static bool CheckLoginData(string username, string password, ref MainForm mainForm)
        {
            Connect();

            bool validUsername = false;
            bool validPassword = false;

            try
            {
                SqlDataReader dataReader = new SqlCommand("SELECT * FROM tbl_login", con).ExecuteReader();

                string error = "";

                while (dataReader.Read())
                {
                    if(dataReader["username"].ToString().Trim() == username)
                    {
                        validUsername = true;
                    }
                    if(dataReader["password"].ToString().Trim() == password)
                    {
                        validPassword = true;
                    }


                    if (validUsername & validPassword)
                    {
                        //MessageBox.Show("Login succes"); for test

                        switch ((int)dataReader["id"])
                        {
                            case 0:
                                mainForm = new DevelopmentForm(); break;
                            case 1:
                                mainForm = new SalesForm(); break;
                            case 2:
                                mainForm = new FinanceForm(); break;
                            case 3:
                                mainForm = new AdminForm(); break;
                        }

                        dataReader.Close();
                        return true;
                    }
                }

                if (!validUsername)
                    error = "Wrong Username";
                else
                    error = "Wrong Password";

                MessageBox.Show(error);
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
            return false;
        }

        //public static bool InsertCustomer(Row row)
        //{
        //    object[] rows = row.datas;

        //    //string s = "INSERT INTO Table_Customers (id, name, email, phone) VALUES ('{}', '{}')";

        //    SqlCommand command = new SqlCommand(("INSERT INTO Table_Customers (id, name, email, phone) VALUES ('" + (customersTable.rows.Count() + 1) + "', '" + rows[1] + "', '" + rows[2] + "', '" + rows[3] + "')").ToString(), connection);

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Unable to insert data : " + ex);
        //        return false;
        //    }

        //    MessageBox.Show("Data inserted");
        //    return true;
        //}

        public static bool AddMeeting(int projectId, DateTime date, string subject)
        {
            


            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_meetings (p_projectId, m_date, m_subject) VALUES (@ProjectId, @Date, @Subject)", con);
            cmd.Parameters.AddWithValue("@ProjectId", projectId);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Subject", subject);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to insert data : " + ex);
                return false;
            }

            MessageBox.Show("Data inserted");
            return true;
        }
        
        public static bool AddApplication(int projectId, string name, string version)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_applications (p_projectId, a_name, a_version) VALUES (@ProjectId, @Name, @Version)", con);
            cmd.Parameters.AddWithValue("@ProjectId", projectId);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Version", version);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Unable to insert data : " + ex);
                return false;
            }

            MessageBox.Show("Data inserted");
            return true;
        }
                
        public static bool AddClient(object[] clientDatas) //to lazy to make 14 parameters sry
        {
            Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_clients (c_companyName, c_adress1, c_zipcode1, c_city1, c_adress2, c_zipcode2, c_city2, c_contactPerson, c_initials, c_phoneNumber1, c_phoneNumber2, c_fax, c_email) VALUES (@CompanyName, @Adress1, @Zipcode1, @City1, @Adress2, @Zipcode2, @City2, @ContactPerson, @Initials, @PhoneNumber1, @PhoneNumber2, @Fax, @Email)", con);
            cmd.Parameters.AddWithValue("@CompanyName", clientDatas[0]);
            cmd.Parameters.AddWithValue("@Adress1", clientDatas[1]);
            cmd.Parameters.AddWithValue("@Zipcode1", clientDatas[2]);
            cmd.Parameters.AddWithValue("@City1", clientDatas[3]);
            cmd.Parameters.AddWithValue("@Adress2", clientDatas[4]);
            cmd.Parameters.AddWithValue("@Zipcode2", clientDatas[5]);
            cmd.Parameters.AddWithValue("@City2", clientDatas[6]);
            cmd.Parameters.AddWithValue("@ContactPerson", clientDatas[7]);
            cmd.Parameters.AddWithValue("@Initials", clientDatas[8]);
            cmd.Parameters.AddWithValue("@PhoneNumber1", clientDatas[9]);
            cmd.Parameters.AddWithValue("@PhoneNumber2", clientDatas[10]);
            cmd.Parameters.AddWithValue("@Fax", clientDatas[11]);
            cmd.Parameters.AddWithValue("@Email", clientDatas[12]);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to insert data : " + ex);
                return false;
            }

            MessageBox.Show("Data inserted");
            return true;
        }

        public static bool AddProject(int clientId, int quotationId, DateTime lastAppointment, string lastAction, DateTime nextAppointment, string nextAction)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_salesProjects (c_clientId, p_quotationId, p_lastAppointment, p_lastAction, p_nextAppointment, p_nextAction) VALUES (@ClientId, @QuotationId, @LastAppointment, @LastAction, @NextAppointment, @NextAction)", con);
            cmd.Parameters.AddWithValue("@ClientId", clientId);
            cmd.Parameters.AddWithValue("@QuotationId", quotationId);
            cmd.Parameters.AddWithValue("@LastAppointment", lastAppointment);
            cmd.Parameters.AddWithValue("@LastAction", lastAction);
            cmd.Parameters.AddWithValue("@NextAppointment", nextAppointment);
            cmd.Parameters.AddWithValue("@NextAction", nextAction);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to insert data : " + ex);
                return false;
            }

            MessageBox.Show("Data inserted");
            return true;
        }

        public static string[] ClientDatasToArray(int clientId)
        {
            string[] result = new string[13];
            SqlCommand cmd = new SqlCommand("SELECT * tbl_clients");

            try
            {
                SqlDataReader dataReader = new SqlCommand("SELECT * FROM tbl_clients", con).ExecuteReader();

                //string error = "";

                while (dataReader.Read())
                {
                    if (dataReader["c_clientId"].ToString().Trim() == clientId.ToString())
                    {
                        result[0] += dataReader["c_clientId"].ToString().Trim();//+= ?
                        result[1] += dataReader["c_companyName"].ToString().Trim();
                        result[2] += dataReader["c_adress1"].ToString().Trim();
                        result[3] += dataReader["c_zipcode1"].ToString().Trim();
                        result[4] += dataReader["c_city1"].ToString().Trim();
                        result[5] += dataReader["c_adress2"].ToString().Trim();
                        result[6] += dataReader["c_zipcode2"].ToString().Trim();
                        result[7] += dataReader["c_city2"].ToString().Trim();
                        result[8] += dataReader["c_contactPerson"].ToString().Trim();
                        result[9] += dataReader["c_initials"].ToString().Trim();
                        result[10] += dataReader["c_phoneNumber1"].ToString().Trim();
                        result[11] += dataReader["c_fax"].ToString().Trim();
                        result[12] += dataReader["c_email"].ToString().Trim();

                        dataReader.Close();
                        return result;
                    }
                }
                    
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return result;
        }

        public static string[] DebtorDatasToArray(int clientId)
        {
            Connect();
            string[] result = new string[7];
            SqlCommand cmd = new SqlCommand("SELECT * tbl_debtors", con);

            try
            {
                SqlDataReader dataReader = new SqlCommand("SELECT * FROM tbl_debtors", con).ExecuteReader();

                //string error = "";

                while (dataReader.Read())
                {
                    if (dataReader["c_clientId"].ToString().Trim() == clientId.ToString().Trim())
                    {
                        result[0] = dataReader["d_bankAccountNumber"].ToString().Trim();
                        result[1] = dataReader["d_creditBalance"].ToString().Trim();
                        result[2] = dataReader["d_numberOfInvoices"].ToString().Trim();
                        result[3] = dataReader["d_grossRevenue"].ToString().Trim();
                        result[4] = dataReader["d_limit"].ToString().Trim();
                        result[5] = dataReader["d_ledgerAccountNumber"].ToString().Trim();
                        result[6] = dataReader["d_taxCode"].ToString().Trim();

                        dataReader.Close();
                        return result;
                    }
                }

                dataReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to get debtor informations" + ex.ToString());
            }

            
            return null;
        }

        public static object[] CreditorDatasToArray()
        {
            Connect();
            object[] result = new object[19];
            SqlCommand cmd = new SqlCommand("SELECT * tbl_creditor", con);

            try
            {
                SqlDataReader dataReader = new SqlCommand("SELECT * FROM tbl_creditor", con).ExecuteReader();

                //result[0] = dataReader["d_bankAccountNumber"].ToString().Trim();

                while (dataReader.Read())
                {
                    result[0] = dataReader["companyName"];
                    result[1] = dataReader["adress1"];
                    result[2] = dataReader["zipcode1"];
                    result[3] = dataReader["city1"];
                    result[4] = dataReader["adress2"];
                    result[5] = dataReader["zipcode2"];
                    result[6] = dataReader["city2"];
                    result[7] = dataReader["contactPerson"];
                    result[8] = dataReader["initials"];
                    result[9] = dataReader["phoneNumber"];
                    result[10] = dataReader["fax"];
                    result[11] = dataReader["email"];
                    result[12] = dataReader["bankAccountNumber"];
                    result[13] = dataReader["creditBalance"];
                    result[14] = dataReader["numberOfInvoices"];
                    result[15] = dataReader["grossRevenue"];
                    result[16] = dataReader["limit"];
                    result[17] = dataReader["ledgerAccountNumber"];
                    result[18] = dataReader["taxCode"];
                }

                dataReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to get debtor informations" + ex.ToString());
            }


            return result;
        }

        public static string[,] LoginDatasToArray()
        {
            Connect();
            //object[] result = new object[2];
            string[,] result = new string[4, 2];
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_login");

            try
            {
                SqlDataReader dataReader = new SqlCommand("SELECT * FROM tbl_login", con).ExecuteReader();

                //result[0] = dataReader["d_bankAccountNumber"].ToString().Trim();

                int i = 0;
                while (dataReader.Read())
                {
                    result[i, 0] = dataReader["username"].ToString().Trim();
                    result[i, 1] = dataReader["password"].ToString().Trim();
                    i++;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Unable to get login informations" + ex.ToString());
            }

            return result;
        }

        public static DataTable SearchInTabel(DataGridView dg, string txt)
        {
            Connect();
            //SqlDataAdapter adapt = new SqlDataAdapter("select * from {0} where " dg.nam)


            try
            {
                //cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Unable to search data..." + ex);
            }


            //cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            return dt;
        }

        public static bool UpdateSingleValue(string tabelName, string columnName, int rowIndex, string indexColumnName ,object value)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("Update " + tabelName + " Set " + columnName + "=@Value WHERE " + indexColumnName + "=" + rowIndex, con);
            cmd.Parameters.AddWithValue("@Value", value);

            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Unable to update data" + ex);
                return false;
            }


            MessageBox.Show("Data updated");
            return true;
        }
    } 
}
