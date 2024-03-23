using System.Windows.Forms;

namespace ProiectPaw {
    public partial class FormMain : Form {

        Utilizator u1;
        public FormMain() {
            InitializeComponent();
            u1 = new Utilizator("Andrei", "andyspeed2003@gmail.com",
                Utils.ComputeSHA256Hash("pisica123"), "5031009467119", new System.DateTime(2003, 06, 02));
            ListViewItem lvItem = new ListViewItem(u1.Nume);
            lvItem.SubItems.Add(u1.CNP);
            lvItem.SubItems.Add(u1.Email);
            lvItem.SubItems.Add(u1.Password);
            lvItem.SubItems.Add(u1.DataNastere.ToString());
            lvItem.Tag = u1;
            lvUtilizatori.Items.Add(lvItem);
        }

        private void lvUtilizatori_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (lvUtilizatori.SelectedItems.Count > 0) {
                tbSelectedUtilizator.Text = "";
                ListViewItem lv = lvUtilizatori.SelectedItems[0];
                tbSelectedUtilizator.Text += lv.Text + " " + lv.SubItems[1].Text + " " + lv.SubItems[2].Text +
                    " " + lv.SubItems[3].Text + " " + lv.SubItems[4].Text;
            }
        }
    }
}
