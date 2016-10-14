using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test250915
{
    static class DatabaseManager
    {
        public static Table customersTable { get; private set; }
        public static Table projectsTable { get; private set; }

        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\Visual Studio 2015\Projects\test250915\test250915\MainDatabase.mdf;Integrated Security = True";
        private static SqlConnection connection;

        private static string SQLCOM_INSERTTEST;
        private static string SQLCOM_CHECKLOGINDATA;
        private static string SQLCOM_GETCUSTOMERSTABLE;
        //private static string SQLCOM_INSERTCUSTOMER;

        public static void Init()
        {
            connection = new SqlConnection(connectionString);

            SQLCOM_INSERTTEST = "INSERT INTO Table_Login (username, password) VALUES ('antho', 'haha')";
            SQLCOM_CHECKLOGINDATA = "SELECT * FROM Table_Login";
            SQLCOM_GETCUSTOMERSTABLE = "SELECT * FROM Table_Customers";
            //SQLCOM_INSERTCUSTOMER = "INSERT INTO Table_Customers (id, name, email, phone) VALUES ()";

            Connect();
            
            Column[] tmpColumns = new Column[4] { new Column(true, false, "id"), new Column("name"), new Column("email"), new Column("phone") };

            customersTable = new Table(tmpColumns, "Table_Customers", "INSERT INTO Table_Customers VALUES (@id, @name, @email, @phone)", "UPDATE Table_Projects SET id=@newId, Address=@newName WHERE Id=@Id");
            FillTableCustomers();

            Column[] tmpColums2 = new Column[3] { new Column(true, false, "id"), new Column("name"), new Column("clientid") };

            projectsTable = new Table(tmpColums2, "Table_Projects", "INSERT INTO Table_Projects VALUES (@Id, @Name, @Clientid)", "test");
            FillTableProjects();
        }

        public static bool Connect()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                MessageBox.Show("Connected to database");
                return true;
            }
            else
                return false;  
        }

        public static bool Disconnect()
        {
            if (connection.State != ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                MessageBox.Show("Disconnected");
                return true;
            }
            else
                return false;
        }

        //public static bool InsertTest()
        //{
        //    SqlCommand command = new SqlCommand(SQLCOM_INSERTTEST, connection);

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //    }
        //    catch(SqlException ex)
        //    {
        //        MessageBox.Show("unable to insert data : " + ex);
        //        return false;
        //    }

        //    MessageBox.Show("Data inserted");
        //    return true;
        //}

        public static bool CheckLoginData(string username, string password)
        {
            try
            {
                SqlDataReader dataReader = new SqlCommand(SQLCOM_CHECKLOGINDATA, connection).ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader["username"].ToString().Trim() == username && dataReader["password"].ToString().Trim() == password)
                    {
                        MessageBox.Show("Login succes");
                        dataReader.Close();
                        return true;
                    }
                }
                dataReader.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Wrong username and/or wrong password");
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

        public static bool InsertRow(Table table, Row row)
        {
            object[] rows = row.datas;

            string rowString = "";
            for(int i = 1; i < table.columns.Count() - 1; i ++)
            {
                rowString += rows[i] + "', '";
            }
            rowString += rows[table.columns.Count() - 1];

            string columnString = "(id";
            for(int i = 1; i < table.columns.Count(); i++)
            {
                columnString += ", " + table.columns[i].name;
            }
            columnString += ")";

            //TODO: SQL INJECTION PROTECTION

            SqlCommand command = new SqlCommand(("INSERT INTO " + table.name + columnString + " VALUES ('" + (table.rows.Count() + 1) + "', '" + rowString+ "')").ToString(), connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to insert data : " + ex);
                return false;
            }

            MessageBox.Show("Data inserted");
            return true;
        }


        public static void UpdataRow(Table table, Row row)
        {


            SqlCommand command = new SqlCommand("UPDATE @table SET @column");
        }

        public static void FillTableCustomers()
        {
            customersTable.ClearRows();

            SqlDataReader dataReader = new SqlCommand(SQLCOM_GETCUSTOMERSTABLE, connection).ExecuteReader();

            while (dataReader.Read())
            {
                customersTable.AddRows(new Row((new object[4] { dataReader["id"].ToString(), dataReader["name"].ToString(), dataReader["email"].ToString(), dataReader["phone"].ToString() })));
            }
            dataReader.Close();
        }

        public static void FillTableProjects()
        {
            projectsTable.ClearRows();

            SqlDataReader dataReader = new SqlCommand("SELECT * FROM Table_Projects", connection).ExecuteReader();

            while (dataReader.Read())
            {
                projectsTable.AddRows(new Row((new object[3] { dataReader["id"].ToString(), dataReader["name"].ToString(), dataReader["Clientid"].ToString() })));
            }
            dataReader.Close();
        }
    
    }
}
