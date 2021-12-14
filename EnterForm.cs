using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RepairShop
{
    public partial class EnterForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=;database=contacts");
        FormPersonalInfo fpi = new FormPersonalInfo();
        int i;
        public EnterForm()
        {
            InitializeComponent();
           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
                                
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM admin WHERE login='"+txtUser.Text+"' AND password='"+txtLog.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i == 0)
            {
                MessageBox.Show("Не правильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                fpi.ShowDialog();
            }
        }
    }
}
