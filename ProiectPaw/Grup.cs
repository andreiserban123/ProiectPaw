using System.Collections.Generic;

namespace ProiectPaw {
    public class Grup {
        private string nume;
        public List<string> drepturi;
        public List<Utilizator> listaUtilizatori;

        public Grup(string nume) {
            this.nume = nume;
            drepturi = new List<string>();
            listaUtilizatori = new List<Utilizator>();
        }

        public string Nume {
            get { return nume; }
            set { nume = value; }
        }
    }
}
