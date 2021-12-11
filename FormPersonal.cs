using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairShop
{
    public partial class FormPersonal : Form
    {

        private readonly FormPersonalInfo _parent;
        public FormPersonal(FormPersonalInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void Clear()
        {
            txtName.Text = txtLastName.Text = txtEmail.Text = txtNumber.Text = string.Empty;    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Имя сотрудника пусто ( > 3).");
                return;
            }
            if (txtLastName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Фамилия сотрудника пусто ( > 1).");
                return;
            }
            if (txtEmail.Text.Trim().Length < 0)
            {
                MessageBox.Show("Email сотрудника пусто ( > 1).");
                return;
            }
            if (txtNumber.Text.Trim().Length < 0)
            {
                MessageBox.Show("Номер сотрудника пусто ( > 1).");
                return;
            }
            if (btnSave.Text == "Save")
            {
                Contacts cont = new Contacts(txtName.Text.Trim(), txtLastName.Text.Trim(), txtEmail.Text.Trim(), txtNumber.Text.Trim());
                DbContacts.AddContacts(cont);
                Clear();
            }
            _parent.Display();
        }
    }
}
