namespace RepairShop
{
    public partial class FormPersonalInfo : Form
    {
        public FormPersonalInfo()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DbPersonal.DisplayAndSearch("SELECT ID, Name, LastName, Email, Number FROM personal",dataGridView);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FormPersonal form = new FormPersonal(this);
            form.ShowDialog();  
        }

        private void FormPersonalInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}