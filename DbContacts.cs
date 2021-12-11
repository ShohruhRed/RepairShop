using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RepairShop
{
    internal class DbContacts
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=contacts";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddContacts(Contacts cont)
        {
            string sql = "INSERT INTO personal VALUES(NULL, @ContactsName, @ContactsLastName, @ContactsEmail, @ContactsNumber, NULL)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con); 
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ContactsID", MySqlDbType.VarChar).Value = con;
            cmd.Parameters.Add("@ContactsName", MySqlDbType.VarChar).Value = cont.Name;
            cmd.Parameters.Add("@ContactsLastName", MySqlDbType.VarChar).Value = cont.LastName;
            cmd.Parameters.Add("@ContactsEmail", MySqlDbType.VarChar).Value = cont.Email;
            cmd.Parameters.Add("@ContactsNumber", MySqlDbType.VarChar).Value = cont.Number;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено!" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Сотрудник не добавлен" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateContacts(Contacts cont, string id)
        {
            string sql = "UPDATE personal SET Name = @ContactsName, LastName = @ContactsLastName, Email = @ContactsEmail, Number = @ContactsNumber WHERE ID = @ContactsID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ContactsID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ContactsName", MySqlDbType.VarChar).Value = cont.Name;
            cmd.Parameters.Add("@ContactsLastName", MySqlDbType.VarChar).Value = cont.LastName;
            cmd.Parameters.Add("@ContactsEmail", MySqlDbType.VarChar).Value = cont.Email;
            cmd.Parameters.Add("@ContactsNumber", MySqlDbType.VarChar).Value = cont.Number;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно обновлен!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось обновить" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteContacts(string id)
        {
            string sql = "DELETE FROM personal WHERE ID = @ContactsID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ContactsID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно удален", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd  = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();

        }


    }
}

