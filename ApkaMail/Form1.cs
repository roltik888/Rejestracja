using System.Text.RegularExpressions;
namespace ApkaMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Haslopis.PasswordChar = '*';;
            Lista.View = View.Details;
            Lista.FullRowSelect = true;
            Lista.Columns.Add("Nazwa użytkownika", 120);
            Lista.Columns.Add("E-mail", 120);
            Lista.Columns.Add("Haslo", 120);
            Zatwierdz.Click += Zatwierdz_Click;
            Usun.Click += Usun_Click;
        }
        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            string email = Emailpis.Text.Trim();
            string nazwa = Nazwapis.Text.Trim();
            string haslo = Haslopis.Text.Trim();
            if (string.IsNullOrWhiteSpace(nazwa) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(haslo))
            {
                MessageBox.Show("Uzupełnij wszystkie pola.");
                return;
            }
            if (!Regulamin.Checked)
            {
                MessageBox.Show("Musisz zaakceptować regulamin.");
                return;
            }
            if (!CzyPoprawnyEmail(email))
            {
                MessageBox.Show("Podany adres e-mail jest niepoprawny.");
                return;
            }
            ListViewItem item = new ListViewItem(nazwa);
            item.SubItems.Add(email);
            item.SubItems.Add(new string('*', haslo.Length));
            Lista.Items.Add(item);
            Emailpis.Clear();
            Nazwapis.Clear();
            Haslopis.Clear();
            Regulamin.Checked = false;
            Cookies.Checked = false;
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedItems.Count > 0)
            {
                Lista.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Najpierw zaznacz użytkownika do usunięcia.");
            }
        }

        private bool CzyPoprawnyEmail(string email)
        {
            string wzorzec = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, wzorzec);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
