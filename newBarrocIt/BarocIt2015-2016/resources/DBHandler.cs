using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BarrocITApp
{
    class DBHandler
    {
        private SqlConnection con;

        private bool isOpen;
        
        public DBHandler()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename="+@"C:\Users\Jeebes\Documents\Visual Studio 2013\Projects\test\test\Database1.mdf"+";Integrated Security=True");
        }

        public bool TestConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    if (con.Open())
                    {
                        con.Close();
                        return true;
                    }
                    else
                        return false;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }        
        }

        public bool OpenConnectionToDB()
        {
            if(!isOpen)
            {
                try
                {
                    con.open();
                    return true;
                }
                catch(Exception e)
                { 
                }
                return false;
            }
        }

        public void CloseConnectionToDB()
        {
            if (isOpen)
            {
                try
                {
                    con.close();
                    return true;
                }
                catch (Exception e)
                {

                }
                return false;
            }
        }

        public DataTable FillDT(string query)
        {
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetCon());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            
            CloseConnectionToDB();

            return dt;
        }

        public SqlConnection GetCon()
        {
            return con;
        }

        private bool IsOpen()
        {
            return con.State == ConnectionState.Open;
        }
    }
}