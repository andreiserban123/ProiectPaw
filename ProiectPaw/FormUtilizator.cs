using System.Windows.Forms;

namespace ProiectPaw {
    public partial class FormUtilizator : Form {
        public Utilizator uFormUtilizator;
        public FormUtilizator(Utilizator u) {
            InitializeComponent();
            if (u == null) {
                btnAdauga.Text = "Adauga";
                u = new Utilizator();
            }
            else {
                btnAdauga.Text = "Modifica";
                tbNume.Text = u.Nume;
                tbEmail.Text = u.Email;
                tbPassword.Text = u.Password;
                tbCnp.Text = u.CNP;
                dateDataNast.Value = u.DataNastere;
            }
            uFormUtilizator = u;
        }

        private void btnAdauga_Click(object sender, System.EventArgs e) {
            // check if all fields are filled
            if (tbNume.Text == "" || tbEmail.Text == "" || tbPassword.Text == "" || tbCnp.Text == "") {
                MessageBox.Show("Completati toate campurile!");
                return;
            }

            uFormUtilizator.Nume = tbNume.Text;
            uFormUtilizator.Email = tbEmail.Text;
            uFormUtilizator.Password = Utils.ComputeSHA256Hash(tbPassword.Text);
            uFormUtilizator.CNP = tbCnp.Text;
            uFormUtilizator.DataNastere = dateDataNast.Value;
        }
    }
}
