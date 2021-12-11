namespace RepairShop
{
    public partial class FormPersonal : Form
    {

        private readonly FormPersonalInfo _parent;
        public string id, name, lastname, email, number;
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
            if (btnSave.Text == "Сохранить")
            {
                Contacts cont = new Contacts(txtName.Text.Trim(), txtLastName.Text.Trim(), txtEmail.Text.Trim(), txtNumber.Text.Trim());
                DbContacts.AddContacts(cont);
                Clear();
            }
            if (btnSave.Text == "Изменить")
            {
                Contacts cont = new Contacts(txtName.Text.Trim(), txtLastName.Text.Trim(), txtEmail.Text.Trim(), txtNumber.Text.Trim());
                DbContacts.UpdateContacts(cont, id);

                

            }
            _parent.Display();
        }
    }
}
