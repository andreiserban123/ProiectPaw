using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ProiectPaw {
    public partial class FormMain : Form {

        Utilizator u1;
        List<Grup> grupuri;
        public FormMain() {
            InitializeComponent();
            u1 = new Utilizator("Andrei", "andyspeed2003@gmail.com",
                Utils.ComputeSHA256Hash("pisica123"), "5031009467119", new System.DateTime(2003, 06, 02));
            grupuri = new List<Grup>();
            Grup grup = new Grup("Admin");
            Grup grup2 = new Grup("User");
            Grup grup3 = new Grup("Guest");
            grupuri.Add(grup);
            grupuri.Add(grup2);
            grupuri.Add(grup3);

            grupuri[0].drepturi.Add("Read");
            grupuri[0].drepturi.Add("Update");
            grupuri[0].drepturi.Add("Delete");
            grupuri[0].drepturi.Add("Admin");
            grupuri[1].drepturi.Add("Read");
            grupuri[1].drepturi.Add("Update");
            grupuri[1].drepturi.Add("Delete");
            grupuri[2].drepturi.Add("Read");
            grupuri[0].listaUtilizatori.Add(u1);
            ListViewItem lvItem = new ListViewItem(u1.Nume);
            lvItem.SubItems.Add(u1.CNP);
            lvItem.SubItems.Add(u1.Email);
            lvItem.SubItems.Add(u1.Password);
            lvItem.SubItems.Add(u1.DataNastere.ToString());
            lvItem.Tag = u1;
            lvUtilizatori.Items.Add(lvItem);
        }

        private void lvUtilizatori_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvUtilizatori.SelectedItems.Count > 0) {
                tbSelectedUtilizator.Text = "";
                ListViewItem lv = lvUtilizatori.SelectedItems[0];
                tbSelectedUtilizator.Text += lv.Text + "," + lv.SubItems[1].Text + "," + lv.SubItems[2].Text +
                                              "," + lv.SubItems[3].Text + "," + lv.SubItems[4].Text;
                Utilizator u = lv.Tag as Utilizator;

                lvGrupuri.Items.Clear();

                foreach (Grup grup in grupuri) {
                    foreach (Utilizator utilizator in grup.listaUtilizatori) {
                        if (utilizator == u) {
                            ListViewItem lvGrup = new ListViewItem(grup.Nume);
                            if (grup.drepturi.Count > 0) {
                                lvGrup.SubItems.Add(grup.drepturi[0]);
                            }
                            lvGrupuri.Items.Add(lvGrup);
                            for (int i = 1; i < grup.drepturi.Count; i++) {
                                lvGrup = new ListViewItem("");
                                lvGrup.SubItems.Add(grup.drepturi[i]);
                                lvGrup.Tag = u;
                                lvGrupuri.Items.Add(lvGrup);
                            }
                        }
                    }
                }
            }
        }


        private void adaugaToolStripMenuItem_Click(object sender, System.EventArgs e) {
            Utilizator u = null;
            FormUtilizator form = new FormUtilizator(u);
            if (form.ShowDialog() == DialogResult.OK) {
                u = form.uFormUtilizator;

                Grup selectedGrup = grupuri.Find(grup => grup.Nume == form.numeGrupF);
                if (selectedGrup == null) {
                    selectedGrup = new Grup(form.numeGrupF);
                    grupuri.Add(selectedGrup);
                }

                selectedGrup.listaUtilizatori.Add(u);

                ListViewItem lvItem = new ListViewItem(u.Nume);
                lvItem.SubItems.Add(u.CNP);
                lvItem.SubItems.Add(u.Email);
                lvItem.SubItems.Add(u.Password);
                lvItem.SubItems.Add(u.DataNastere.ToString());
                lvItem.Tag = u;
                lvUtilizatori.Items.Add(lvItem);


            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e) {
            if (lvUtilizatori.SelectedItems.Count > 0) {
                ListViewItem lv = lvUtilizatori.SelectedItems[0];
                Utilizator u = (Utilizator)lv.Tag;
                Grup currentGroup = null; // To store the current group of the user

                // Save the current group of the user
                foreach (Grup grup in grupuri) {
                    if (grup.listaUtilizatori.Contains(u)) {
                        currentGroup = grup;
                        break;
                    }
                }

                FormUtilizator form = new FormUtilizator(u);
                if (form.ShowDialog() == DialogResult.OK) {
                    lv.Text = u.Nume;
                    lv.SubItems[1].Text = u.CNP;
                    lv.SubItems[2].Text = u.Email;
                    lv.SubItems[3].Text = u.Password;
                    lv.SubItems[4].Text = u.DataNastere.ToString();

                    Grup selectedGroup = grupuri.Find(grup => grup.Nume == form.numeGrupF);
                    if (selectedGroup != null) {
                        // Remove the user from the current group and add to the selected group
                        if (currentGroup != null && currentGroup != selectedGroup) {
                            currentGroup.listaUtilizatori.Remove(u);
                            selectedGroup.listaUtilizatori.Add(u);
                        }
                    }
                    else {
                        // If the selected group doesn't exist, create a new group
                        selectedGroup = new Grup(form.numeGrupF);
                        grupuri.Add(selectedGroup);
                        // Add the user to the new group
                        selectedGroup.listaUtilizatori.Add(u);
                    }

                }
            }
        }


        private void stergeToolStripMenuItem_Click(object sender, System.EventArgs e) {
            if (lvUtilizatori.SelectedItems.Count > 0) {
                if (MessageBox.Show("Sigur doriti sa stergeti utilizatorul?", "Stergere", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    lvUtilizatori.Items.Remove(lvUtilizatori.SelectedItems[0]);
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e) {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisier grup (*.grp)|*.grp";
            fd.CheckPathExists = true;
            if (fd.ShowDialog() == DialogResult.OK) {
                try {
                    BinaryFormatter serizator = new BinaryFormatter();
                    Stream fisier = File.Create(fd.FileName);
                    serizator.Serialize(fisier, grupuri);
                    fisier.Close();
                    MessageBox.Show("Lista de grupuri a fost serializata");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void restaurareBinarToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere grup(*.grp)|*.grp";
            fd.CheckFileExists = true;
            if (fd.ShowDialog() == DialogResult.OK) {
                grupuri = new List<Grup>();
                Stream fisier = File.OpenRead(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                grupuri.AddRange((List<Grup>)serializator.Deserialize(fisier));
                lvUtilizatori.Items.Clear();

                foreach (Grup g in grupuri) {
                    foreach (Utilizator u in g.listaUtilizatori) {
                        ListViewItem lvi = new ListViewItem(
                            new string[] {
                                u.Nume, u.CNP, u.Email, u.Password, u.DataNastere.ToString(),
                            }
                            );
                        lvi.Tag = u;
                        lvUtilizatori.Items.Add(lvi);
                    }
                }

            }
        }
    }
}
