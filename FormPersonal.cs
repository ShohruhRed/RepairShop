namespace RepairShop
{
    public partial class FormPersonal : Form
    {

        private readonly FormPersonalInfo _parent;
        public string id, name, lastname, email, number, post, subdivision, birth;
        public FormPersonal(FormPersonalInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            label1.Text = "Изменить информацию о сотруднике";
            btnSave.Text = "Изменить";

            txtName.Text = name;
            txtLastName.Text = lastname;
            txtEmail.Text = email;
            txtNumber.Text = number;
            txtPost.Text = post;
            txtSub.Text = subdivision;
            txtBirth.Text = birth;
        }
        public void Clear()
        {
            txtName.Text = txtLastName.Text = txtEmail.Text = txtNumber.Text = txtPost.Text = txtSub.Text = txtBirth.Text = string.Empty;
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
            
            if (txtPost.Text.Trim().Length < 0)
            {
                MessageBox.Show("Должность сотрудника пусто ( > 1).");
                return;
            }

            if (txtSub.Text.Trim().Length < 0)
            {
                MessageBox.Show("Номер сотрудника пусто ( > 1).");
                return;
            }
            if (txtBirth.Text.Trim().Length < 0)
            {
                MessageBox.Show("Номер сотрудника пусто ( > 1).");
                return;
            }
            if (btnSave.Text == "Сохранить")
            {
                Contacts cont = new Contacts(txtName.Text.Trim(), txtLastName.Text.Trim(), txtEmail.Text.Trim(), txtNumber.Text.Trim(), txtPost.Text.Trim(), txtSub.Text.Trim(), txtBirth.Text.Trim());
                DbContacts.AddContacts(cont);
                Clear();
            }
            if (btnSave.Text == "Изменить")
            {
                Contacts cont = new Contacts(txtName.Text.Trim(), txtLastName.Text.Trim(), txtEmail.Text.Trim(), txtNumber.Text.Trim(), txtPost.Text.Trim(), txtSub.Text.Trim(), txtBirth.Text.Trim());
                DbContacts.UpdateContacts(cont, id);              

            }
            _parent.Display();
        }
    }
}
