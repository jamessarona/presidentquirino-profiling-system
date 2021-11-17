using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace PresidentQuirino
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "db_presquirino";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        /*  THIS BLOCK IS FOR BARANGAY  */

        //Select statement
        public List<string>[] SelectBarangay()
        {
            string query = "SELECT b_id, b_name FROM barangay ORDER BY b_name";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["b_id"] + "");
                    list[1].Add(dataReader["b_name"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Insert statement
        public void InsertBarangay(string name)
        {
            string query = "INSERT INTO barangay (b_name) VALUES('" + name + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void UpdateBarangay(string id, string name)
        {
            string query = "UPDATE barangay SET B_name='" + name + "' WHERE b_id=" + id + "";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void DeleteBarangay(string id)
        {
            string query = "DELETE FROM barangay WHERE b_id=" + id + "";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public int CountBarangayLeader(string id)
        {
            string query = "SELECT COUNT(bl_id) FROM brgy_leader WHERE barangay_b_id=" + id + ";";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        /*  THIS BLOCK IS FOR BARANGAYLEADER  */

        //Select statement
        public List<string>[] SelectBarangayLeader(string id)
        {
            string query = "SELECT bl_id, CONCAT(bl_lastname, ', ', bl_firstname, ' ', IF(bl_middlename <> '', CONCAT(LEFT(bl_middlename, 1), '. '), ''), IFNULL(bl_suffix, '')) as  'bl_name', bl_precinctno, bl_contactno, bl_birthdate FROM brgy_leader WHERE barangay_b_id = " + id + " ORDER BY CONCAT(bl_lastname, bl_firstname, bl_middlename, bl_suffix)";
            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["bl_id"] + "");
                    list[1].Add(dataReader["bl_name"] + "");
                    list[2].Add(dataReader["bl_precinctno"] + "");
                    list[3].Add(dataReader["bl_contactno"] + "");
                    list[4].Add(dataReader["bl_birthdate"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Select statement
        public List<string>[] SelectBarangayLeaderFilter(string id, string search)
        {
            string query = "SELECT bl_id, CONCAT(bl_lastname, ', ', bl_firstname, ' ', IF(bl_middlename <> '', CONCAT(LEFT(bl_middlename, 1), '. '), ''), IFNULL(bl_suffix, '')) as  'bl_name', bl_precinctno, bl_contactno, bl_birthdate FROM brgy_leader WHERE barangay_b_id = " + id + " AND CONCAT(bl_firstname, ' ', bl_middlename, ' ', bl_lastname, ' ', bl_precinctno) LIKE '%" + search + "%' ORDER BY CONCAT(bl_lastname, bl_firstname, bl_middlename, bl_suffix)";
            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["bl_id"] + "");
                    list[1].Add(dataReader["bl_name"] + "");
                    list[2].Add(dataReader["bl_precinctno"] + "");
                    list[3].Add(dataReader["bl_contactno"] + "");
                    list[4].Add(dataReader["bl_birthdate"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectBarangayLeaderFilterLite(string search)
        {
            string query = "SELECT b_name, CONCAT(bl_lastname, ', ', bl_firstname, ' ', IF(bl_middlename <> '', CONCAT(LEFT(bl_middlename, 1), '. '), ''), IFNULL(bl_suffix, '')) as  'bl_name' FROM barangay " +
                            "LEFT JOIN brgy_leader on b_id = barangay_b_id WHERE CONCAT(bl_firstname, ' ', bl_middlename, ' ', bl_lastname, ' ', bl_precinctno) LIKE '%" + search + "%'; ";
            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["b_name"] + "");
                    list[1].Add(dataReader["bl_name"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Insert statement
        public void InsertBarangayLeader(string b_id, string lastname, string firstname, string middlename, string suffix, string precinctno, string contactno, string birthdate)
        {
            string query = "INSERT INTO brgy_leader (barangay_b_id, bl_firstname, bl_middlename, bl_lastname, bl_suffix, bl_precinctno, bl_contactno, bl_birthdate) VALUES( " + b_id + ", '" + firstname + "', '" + middlename + "', '" + lastname + "', '" + suffix + "', '" + precinctno + "', '" + contactno + "', STR_TO_DATE('" + birthdate + "', '%d-%m-%Y'))";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void UpdateBarangayLeader(string b_id, string bl_id, string lastname, string firstname, string middlename, string suffix, string precinctNo, string contactno, string birthdate)
        {
            string query = "UPDATE brgy_leader SET barangay_b_id = '" + b_id + "', bl_firstname = '" + firstname + "', bl_middlename = '" + middlename + "', bl_lastname = '" + lastname + "', bl_suffix = '" + suffix + "', bl_precinctno = '" + precinctNo + "', bl_contactno = '" + contactno + "', bl_birthdate = STR_TO_DATE('" + birthdate + "', '%d-%m-%Y') WHERE (bl_id = " + bl_id + ");";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void DeleteBarangayLeader(string id)
        {
            string query = "DELETE FROM brgy_leader WHERE bl_id=" + id + "";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public int CountFamilyLeader(string id)
        {
            string query = "SELECT COUNT(fl_id) FROM fam_leader WHERE brgy_leader_bl_id=" + id + ";";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        /*  THIS BLOCK IS FOR FAMILY LEADER  */

        public List<string>[] SelectFamilyLeader(string id)
        {
            string query = "SELECT fl_id, CONCAT(fl_lastname, ', ', fl_firstname, ' ', IF(fl_middlename <> '', CONCAT(LEFT(fl_middlename, 1), '. '), ''), IFNULL(fl_suffix, '')) as  'fl_name', fl_precinctno, fl_contactno, fl_birthdate FROM fam_leader WHERE brgy_leader_bl_id = " + id + " ORDER BY CONCAT(fl_lastname, fl_firstname, fl_middlename, fl_suffix)";
            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["fl_id"] + "");
                    list[1].Add(dataReader["fl_name"] + "");
                    list[2].Add(dataReader["fl_precinctno"] + "");
                    list[3].Add(dataReader["fl_contactno"] + "");
                    list[4].Add(dataReader["fl_birthdate"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectFamilyLeaderFilter(string id, string search)
        {
            string query = "SELECT fl_id, CONCAT(fl_lastname, ', ', fl_firstname, ' ', IF(fl_middlename <> '', CONCAT(LEFT(fl_middlename, 1), '. '), ''), IFNULL(fl_suffix, '')) as  'fl_name', fl_precinctno, fl_contactno, fl_birthdate FROM fam_leader WHERE brgy_leader_bl_id = " + id + " AND CONCAT(fl_firstname, ' ', fl_middlename, ' ', fl_lastname, ' ', fl_precinctno) LIKE '%" + search + "%' ORDER BY CONCAT(fl_lastname, fl_firstname, fl_middlename, fl_suffix)";
            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["fl_id"] + "");
                    list[1].Add(dataReader["fl_name"] + "");
                    list[2].Add(dataReader["fl_precinctno"] + "");
                    list[3].Add(dataReader["fl_contactno"] + "");
                    list[4].Add(dataReader["fl_birthdate"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectFamilyLeaderFilterLite(string search)
        {
            string query = "SELECT b_name, CONCAT(bl_lastname, ', ', bl_firstname, ' ', IF(bl_middlename <> '', CONCAT(LEFT(bl_middlename, 1), '. '), ''), IFNULL(bl_suffix, '')) as  'bl_name', CONCAT(fl_lastname, ', ', fl_firstname, ' ', IF(fl_middlename <> '', CONCAT(LEFT(fl_middlename, 1), '. '), ''), IFNULL(fl_suffix, '')) as  'fl_name' FROM barangay LEFT JOIN brgy_leader on b_id=barangay_b_id LEFT JOIN fam_leader on bl_id = brgy_leader_bl_id WHERE CONCAT(fl_firstname, ' ', fl_middlename, ' ', fl_lastname, ' ', fl_precinctno) LIKE '%" + search + "%'; ";
            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["b_name"] + "");
                    list[1].Add(dataReader["bl_name"] + "");
                    list[2].Add(dataReader["fl_name"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Insert statement
        public void InsertFamilyLeader(string bl_id, string lastname, string firstname, string middlename, string suffix, string precinctno, string contactno, string birthdate)
        {
            string query = "INSERT INTO fam_leader (brgy_leader_bl_id, fl_firstname, fl_middlename, fl_lastname, fl_suffix, fl_precinctno, fl_contactno, fl_birthdate) VALUES( " + bl_id + ", '" + firstname + "', '" + middlename + "', '" + lastname + "', '" + suffix + "', '" + precinctno + "', '" + contactno + "', STR_TO_DATE('" + birthdate + "', '%d-%m-%Y'))";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void UpdateFamilyLeader(string bl_id, string fl_id, string lastname, string firstname, string middlename, string suffix, string precinctNo, string contactno, string birthdate)
        {
            string query = "UPDATE fam_leader SET brgy_leader_bl_id = '" + bl_id + "', fl_firstname = '" + firstname + "', fl_middlename = '" + middlename + "', fl_lastname = '" + lastname + "', fl_suffix = '" + suffix + "', fl_precinctno = '" + precinctNo + "', fl_contactno = '" + contactno + "', fl_birthdate = STR_TO_DATE('" + birthdate + "', '%d-%m-%Y') WHERE (fl_id = " + fl_id + ");";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void DeleteFamilyLeader(string id)
        {
            string query = "DELETE FROM fam_leader WHERE fl_id=" + id + "";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public int CountFamilyMember(string id)
        {
            string query = "SELECT COUNT(fm_id) FROM fam_member WHERE fam_leader_fl_id=" + id + ";";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        /*  THIS BLOCK IS FOR FAMILYMEMBER  */

        //Select Statement
        public List<string>[] SelectFamilyMember(string id)
        {
            string query = "SELECT fm_id, CONCAT(fm_lastname, ', ', fm_firstname, ' ', IF(fm_middlename <> '', CONCAT(LEFT(fm_middlename, 1), '. '), ''), IFNULL(fm_suffix, '')) as  'fm_name', fm_precinctno, fm_contactno, fm_birthdate FROM fam_member WHERE fam_leader_fl_id = " + id + " ORDER BY CONCAT(fm_lastname, fm_firstname, fm_middlename, fm_suffix)";
            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["fm_id"] + "");
                    list[1].Add(dataReader["fm_name"] + "");
                    list[2].Add(dataReader["fm_precinctno"] + "");
                    list[3].Add(dataReader["fm_contactno"] + "");
                    list[4].Add(dataReader["fm_birthdate"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        //Select Statement Filter
        public List<string>[] SelectFamilyMemberFilter(string id, string search)
        {
            string query = "SELECT fm_id, CONCAT(fm_lastname, ', ', fm_firstname, ' ', IF(fm_middlename <> '', CONCAT(LEFT(fm_middlename, 1), '. '), ''), IFNULL(fm_suffix, '')) as  'fm_name', fm_precinctno, fm_contactno, fm_birthdate FROM fam_member WHERE fam_leader_fl_id = " + id + " AND CONCAT(fm_firstname, ' ', fm_middlename, ' ', fm_lastname, ' ', fm_precinctno) LIKE '%" + search + "%' ORDER BY CONCAT(fm_lastname, fm_firstname, fm_middlename, fm_suffix)";

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["fm_id"] + "");
                    list[1].Add(dataReader["fm_name"] + "");
                    list[2].Add(dataReader["fm_precinctno"] + "");
                    list[3].Add(dataReader["fm_contactno"] + "");
                    list[4].Add(dataReader["fm_birthdate"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectFamilyMemberFilterLite(string search)
        {
            string query = "SELECT b_name, CONCAT(bl_lastname, ', ', bl_firstname, ' ', IF(bl_middlename <> '', CONCAT(LEFT(bl_middlename, 1), '. '), ''), IFNULL(bl_suffix, '')) as  'bl_name', CONCAT(fl_lastname, ', ', fl_firstname, ' ', IF(fl_middlename <> '', CONCAT(LEFT(fl_middlename, 1), '. '), ''), IFNULL(fl_suffix, '')) as  'fl_name', CONCAT(fm_lastname, ', ', fm_firstname, ' ', IF(fm_middlename <> '', CONCAT(LEFT(fm_middlename, 1), '. '), ''), IFNULL(fm_suffix, '')) as  'fm_name' FROM barangay LEFT JOIN brgy_leader on b_id = barangay_b_id LEFT JOIN fam_leader on bl_id = brgy_leader_bl_id LEFT JOIN fam_member on fl_id = fam_leader_fl_id WHERE CONCAT(fm_firstname, ' ', fm_middlename, ' ', fm_lastname, ' ', fm_precinctno) LIKE '%" + search + "%'; ";

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["b_name"] + "");
                    list[1].Add(dataReader["bl_name"] + "");
                    list[2].Add(dataReader["fl_name"] + "");
                    list[3].Add(dataReader["fm_name"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Insert statement
        public void InsertFamilyMember(string fl_id, string lastname, string firstname, string middlename, string suffix, string precinctno, string contactno, string birthdate)
        {
            string query = "INSERT INTO fam_member (fam_leader_fl_id, fm_firstname, fm_middlename, fm_lastname, fm_suffix, fm_precinctno, fm_contactno, fm_birthdate) VALUES( " + fl_id + ", '" + firstname + "', '" + middlename + "', '" + lastname + "', '" + suffix + "', '" + precinctno + "', '" + contactno + "', STR_TO_DATE('" + birthdate + "', '%d-%m-%Y'))";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void UpdateFamilyMember(string fl_id, string fm_id, string lastname, string firstname, string middlename, string suffix, string precinctNo, string contactno, string birthdate)
        {
            string query = "UPDATE fam_member SET fam_leader_fl_id = '" + fl_id + "', fm_firstname = '" + firstname + "', fm_middlename = '" + middlename + "', fm_lastname = '" + lastname + "', fm_suffix = '" + suffix + "', fm_precinctno = '" + precinctNo + "', fm_contactno = '" + contactno + "', fm_birthdate = STR_TO_DATE('" + birthdate + "', '%d-%m-%Y') WHERE (fm_id = " + fm_id + ");";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void DeleteFamilyMember(string id)
        {
            string query = "DELETE FROM fam_member WHERE fm_id=" + id + "";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /* THIS BLOCK IS FOR GENERAL. RETRIEVES PERSON DETAILS */

        public List<string> SelectPersonDetail(string table, string id)
        {
            string personId, personFirstname, personLastname, personMiddlename,
                   personSuffix, personPrecinctNo, personContactNo, personBirthdate;

            if (table.CompareTo("brgy_leader") == 0)
            {
                personId = "bl_id";
                personFirstname = "bl_firstname";
                personMiddlename = "bl_middlename";
                personLastname = "bl_lastname";
                personSuffix = "bl_suffix";
                personPrecinctNo = "bl_precinctno";
                personContactNo = "bl_contactno";
                personBirthdate = "bl_birthdate";
            }
            else if (table.CompareTo("fam_leader") == 0)
            {
                personId = "fl_id";
                personFirstname = "fl_firstname";
                personMiddlename = "fl_middlename";
                personLastname = "fl_lastname";
                personSuffix = "fl_suffix";
                personPrecinctNo = "fl_precinctno";
                personContactNo = "fl_contactno";
                personBirthdate = "fl_birthdate";
            }
            else
            {
                personId = "fm_id";
                personFirstname = "fm_firstname";
                personMiddlename = "fm_middlename";
                personLastname = "fm_lastname";
                personSuffix = "fm_suffix";
                personPrecinctNo = "fm_precinctno";
                personContactNo = "fm_contactno";
                personBirthdate = "fm_birthdate";
            }

            string query = "SELECT " + personId + " as 'id'," + personFirstname + " as 'firstname'," + personMiddlename + " as 'middlename'," + personLastname + " as 'lastname'," + personSuffix +
                        " as 'suffix'," + personPrecinctNo + " as 'precinctno'," + personContactNo + " as 'contactno', DATE_FORMAT(" + personBirthdate + ", '%d-%m-%Y') as 'birthdate' FROM " + table + " WHERE " + personId + " = " + id + "";
            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["id"] + "");
                    list.Add(dataReader["firstname"] + "");
                    list.Add(dataReader["lastname"] + "");
                    list.Add(dataReader["middlename"] + "");
                    list.Add(dataReader["suffix"] + "");
                    list.Add(dataReader["precinctno"] + "");
                    list.Add(dataReader["contactno"] + "");
                    list.Add(dataReader["birthdate"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }

        }

        public List<string> GetLeaderName(string table, string id)
        {
            string parentIdField1;
            string parentIdField2;
            string parentName;
            string parentTable;
            string idField;
            if(table.CompareTo("brgy_leader") == 0)
            {
                parentIdField1 = "b_id";
                parentIdField2 = "barangay_b_id";
                parentName = "b_name";
                parentTable = "barangay";
                idField = "bl_id";
            }
            else if(table.CompareTo("fam_leader") == 0)
            {
                parentIdField1 = "bl_id";
                parentIdField2 = "brgy_leader_bl_id";
                parentName = "CONCAT(bl_firstname, ' ', IFNULL(CONCAT(bl_middlename, ' '), ''), bl_lastname, IFNULL(CONCAT(' ', bl_suffix), ''))";
                parentTable = "brgy_leader";
                idField = "fl_id";
            }
            else
            {
                parentIdField1 = "fl_id";
                parentIdField2 = "fam_leader_fl_id";
                parentName = "CONCAT(fl_firstname, ' ', IFNULL(CONCAT(fl_middlename, ' '), ''), fl_lastname, IFNULL(CONCAT(' ', fl_suffix), ''))";
                parentTable = "fam_leader";
                idField = "fm_id";
            }
            //SELECT CONCAT(bl_firstname, ' ', IFNULL(CONCAT(bl_middlename, ' '), ''), bl_lastname, IFNULL(CONCAT(' ', bl_suffix), '')) as name FROM brgy_leader WHERE bl_id = 11;
            string query = "SELECT " + parentIdField1 + " as id, " + parentName + " as name FROM " + parentTable + " WHERE " + parentIdField1 + " = (SELECT " + parentIdField2 + " FROM " + table + " WHERE " + idField + " = " + id + ");";

            List<string> list = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["id"] + "");
                    list.Add(dataReader["name"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public int CountSubordinates(string task, string table, string id)
        {
            string query;
            if (task.CompareTo("1") == 0)
            {
                if(table.CompareTo("fam_leader") == 0)
                {
                    query = " SELECT COUNT(fl_id) FROM " + table + " WHERE brgy_leader_bl_id = " + id + "";
                }
                else
                {
                    query = " SELECT COUNT(fm_id) FROM " + table + " WHERE fam_leader_fl_id = " + id + "";
                } 
            }
            else
            {
                query = "SELECT COUNT(fm_id) FROM fam_member LEFT JOIN fam_leader ON fam_member.fam_leader_fl_id = fam_leader.fl_id WHERE fam_leader.brgy_leader_bl_id = " + id;
            }
            
            int Count = 0;

            //Open connection
            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }

        }
        
        /* THIS BLOCK CHECKS IF PERSON EXIST IN RECORD */

        public int PersonValidation(string idname, string lastname, string firstname, string middlename, string suffix, string id = "-1")
        {
            string table = idname + "_id" == "bl_id" ? "brgy_leader" : idname + "_id" == "fl_id" ? "fam_leader" : "fam_member";

            string query = "SELECT COUNT(" + idname + "_id" + ") FROM " + table + " WHERE CONCAT(" + idname + "_firstname, ' ', " + idname + "_middlename, ' ', " + idname + "_lastname, ' ', " + idname + "_suffix) = '" + firstname + " " + middlename + " " + lastname + " " + suffix + "' AND " + idname + "_id<>" + id + ";";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
        
        /* THIS BLOCK IS FOR PAYMENT*/

        public List<string>[] SelectPayment(string id, string position)
        {
            string query = "SELECT payment_id, DATE_FORMAT(date, '%d-%m-%Y') as 'date_format', amount FROM payment WHERE person_id=" + id + " AND person_position='" + position + "' ORDER BY date ASC";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["payment_id"] + "");
                    list[1].Add(dataReader["date_format"] + "");
                    list[2].Add(dataReader["amount"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public void InsertPayment(string id, string position, string date, string amount)
        {
            string query = "INSERT INTO payment (person_id, person_position, date, amount) VALUES(" + id + ", '" + position + "', STR_TO_DATE('" + date + "', '%d-%m-%Y'), " + amount + ")";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void DeletePayment(string id)
        {
            string query = "DELETE FROM payment WHERE payment_id=" + id + "";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeletePayments(string person_id, string person_position)
        {
            /* !!!THIS IS FOR SET SQL_SAFE_UPDATES!!!
             * It looks like your MySql session has the safe-updates option set. 
             * This means that you can't update or delete records without specifying a key 
             * (ex. primary key) in the where clause.
             * 
             * https://stackoverflow.com/questions/11448068/mysql-error-code-1175-during-update-in-mysql-workbench
             */

            //without setting SQL_SAFE_UPDATES to 0 the deletion of multiple row will not continue
            string query = "SET SQL_SAFE_UPDATES = 0;";

            query += "DELETE FROM payment WHERE person_id = " + person_id + " AND person_position = '" + person_position + "';";
            
            query += "SET SQL_SAFE_UPDATES = 1;";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        
        //Count statement
        public int CountPayment(string id, string position)
        {
            string query = "SELECT COUNT(payment_id) FROM payment WHERE PERSON_ID=" + id + " AND PERSON_POSITION='" + position + "'";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public List<int> CountPopulation(string position, string barangay)
        {
            List<int> list = new List<int>();
            string query = "";
            switch (position)
            {
                case "bl":
                    query = "SELECT COUNT(bl_id) as 'count' FROM barangay LEFT JOIN brgy_leader ON b_id = barangay_b_id WHERE b_name = '" + barangay + "' GROUP BY b_id";
                    break;
                case "fl":
                    query = "SELECT count(fl_id) as 'count' FROM barangay LEFT JOIN brgy_leader ON b_id = barangay_b_id LEFT JOIN fam_leader ON bl_id = brgy_leader_bl_id WHERE b_name = '" + barangay + "' GROUP BY bl_id";
                    break;
                case "fm":
                    query = "SELECT count(fm_id) as 'count' FROM barangay LEFT JOIN brgy_leader ON b_id = barangay_b_id LEFT JOIN fam_leader ON bl_id = brgy_leader_bl_id LEFT JOIN fam_member ON fl_id = fam_leader_fl_id WHERE b_name = '" + barangay + "' GROUP BY fl_id";
                    break;
            }

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(Int32.Parse(dataReader["count"] + ""));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<int> CountPositionPayment(string position, string barangay)
        {
            List<int> list = new List<int>();
            string query = "";
            switch (position)
            {
                case "bl":
                    query = "SELECT COUNT(payment_id) as 'count' FROM barangay LEFT JOIN brgy_leader ON b_id=barangay_b_id LEFT JOIN payment ON bl_id=person_id AND person_position='BL' WHERE b_name='" + barangay + "' AND bl_id IS NOT NULL GROUP BY bl_id";
                    break;
                case "fl":
                    query = "SELECT COUNT(payment_id) as 'count' FROM barangay LEFT JOIN brgy_leader ON b_id=barangay_b_id LEFT JOIN fam_leader ON bl_id=brgy_leader_bl_id LEFT JOIN payment ON fl_id=person_id AND person_position='FL' WHERE b_name='" + barangay + "' AND fl_id IS NOT NULL GROUP BY fl_id";
                    break;
                case "fm":
                    query = "SELECT COUNT(payment_id) as 'count' FROM barangay LEFT JOIN brgy_leader ON b_id=barangay_b_id LEFT JOIN fam_leader ON bl_id=brgy_leader_bl_id LEFT JOIN fam_member ON fl_id=fam_leader_fl_id LEFT JOIN payment ON fm_id=person_id AND person_position='FM' WHERE b_name='" + barangay + "' AND fm_id IS NOT NULL GROUP BY fm_id";
                    break;
            }

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add((Int32.Parse(dataReader["count"] + "")));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
       
        public double SumPaymentAmount(string barangay, string position)
        {
            string query = "";
            double Count = 0;
            switch (position)
            {
                case "bl":
                    query = "SELECT IFNULL(SUM(amount), 0) as 'amount' FROM barangay LEFT JOIN brgy_leader ON b_id=barangay_b_id LEFT JOIN payment ON bl_id=person_id AND person_position='BL' WHERE b_name= '" + barangay + "'";
                    break;
                case "fl":
                    query = "SELECT IFNULL(SUM(amount), 0) as 'amount' FROM barangay LEFT JOIN brgy_leader ON b_id=barangay_b_id LEFT JOIN fam_leader ON bl_id=brgy_leader_bl_id LEFT JOIN payment ON fl_id=person_id AND person_position='FL' WHERE b_name= '" + barangay + "'";
                    break;
                case "fm":
                    query = "SELECT IFNULL(SUM(amount), 0) as 'amount' FROM barangay LEFT JOIN brgy_leader ON b_id=barangay_b_id LEFT JOIN fam_leader ON bl_id=brgy_leader_bl_id LEFT JOIN fam_member ON fl_id=fam_leader_fl_id LEFT JOIN payment ON fm_id=person_id AND person_position='FM' WHERE b_name= '" + barangay + "'";
                    break;
            }

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = double.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        /* THIS BLOCK IS FOR USER AUTHENTICATION*/
        //Select Statement
        public List<string> LoginAuth(string username, string password)
        {
            string query = "SELECT user_id, CONCAT(user_lastname, ', ', user_firstname, ' ', IF(user_middlename <> '', CONCAT(LEFT(user_middlename, 1), '. '), ''), IFNULL(user_suffix, '')) as  'user_name', username FROM user WHERE BINARY username = '" + username + "' AND password = '" + password + "'";
            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["user_id"] + "");
                    list.Add(dataReader["user_name"] + "");
                    list.Add(dataReader["username"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
