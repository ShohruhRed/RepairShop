namespace RepairShop
{
    public partial class FormPersonalInfo : Form
    {
        FormPersonal form;

        public FormPersonalInfo()
        {
            InitializeComponent();
            form = new FormPersonal(this);
        }

        public void Display()
        {
            DbContacts.DisplayAndSearch("SELECT ID, Name, LastName, Email, Number, Post, Subdivision, Birth FROM personal", dataGridView);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void FormPersonalInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbContacts.DisplayAndSearch("SELECT ID, Name, LastName, Email, Number, Post, Subdivision, Birth FROM personal WHERE Name LIKE'%" + txtSearch.Text + "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Редактироваение
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.lastname = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.email = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.number = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.post = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.subdivision = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.birth = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
                
            }
            //Удаление
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись о сотруднике?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbContacts.DeleteContacts(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return ;

            }
        }
    }
}