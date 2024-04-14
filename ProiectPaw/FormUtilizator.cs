using System.Windows.Forms;

namespace ProiectPaw {
    public partial class FormUtilizator : Form {
        public Utilizator uFormUtilizator;
        public string numeGrupF;
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

            uFormUtilizator.Nume = tbNume.Text;
            uFormUtilizator.Email = tbEmail.Text;
            uFormUtilizator.Password = Utils.ComputeSHA256Hash(tbPassword.Text);
            uFormUtilizator.CNP = tbCnp.Text;
            uFormUtilizator.DataNastere = dateDataNast.Value;
            numeGrupF = cbGroup.Text;

        }

        private void tbCnp_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (tbCnp.Text.Length < 13) {
                errorProvider1.SetError(tbCnp, "CNP nu este valid!");
                e.Cancel = true;
            }
            else errorProvider1.SetError(tbCnp, "");
        }

        private void tbEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!Utils.IsValidEmail(tbEmail.Text)) {
                errorProvider1.SetError(tbEmail, "Email-ul nu este valid!");
                e.Cancel = true;
            }
            else errorProvider1.SetError(tbEmail, "");
        }


        private void tbPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")) {
                errorProvider1.SetError(tbPassword, "Parola nu este suficient de puternica!");
                e.Cancel = true;
            }
            else errorProvider1.SetError(tbPassword, "");
        }
    }
}
