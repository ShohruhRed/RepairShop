using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RepairShop
{
    internal class DbPersonal
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
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }


        public static void AddPersonal(CPersonal per)
        {
            string sql = "INSERT INTO personal VALUES(NULL, @CPersonalName, @CPersonalLastName, @CPersonalEmail, @CPersonalNumber, Null)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CPersonalName", MySqlDbType.VarChar).Value = per.Name;
            cmd.Parameters.Add("@CPersonalLastName", MySqlDbType.VarChar).Value = per.LastName;
            cmd.Parameters.Add("@CPersonalEmail", MySqlDbType.VarChar).Value = per.Email;
            cmd.Parameters.Add("@CPersonalNumber", MySqlDbType.VarChar).Value = per.Number;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Сотрудник не добавлен" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
            public static void UpdatePersonal(CPersonal per, string id)
        {
            string sql = "UPDATE personal SET Name = @CPersonalName, LastName = @CPersonalLastName, Email = @CPersonalEmail, Number = @CPersonalNumber WHERE ID = @CPersonalID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CPersonalName", MySqlDbType.VarChar).Value = per.Name;
            cmd.Parameters.Add("@CPersonalLastName", MySqlDbType.VarChar).Value = per.LastName;
            cmd.Parameters.Add("@CPersonalEmail", MySqlDbType.VarChar).Value = per.Email;
            cmd.Parameters.Add("@CPersonalNumber", MySqlDbType.VarChar).Value = per.Number;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Сотрудник не добавлен" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteCPersonal (string id)
        {
            string sql = "DELETE FROM personal WHERE ID = @CPersonalID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CPersonalName", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно удален", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Сотрудник не удален" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();
        }
           
            

    }
}

