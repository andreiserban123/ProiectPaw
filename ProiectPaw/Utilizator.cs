using System;

namespace ProiectPaw {
    public class Utilizator {
        private string nume;
        private string email;
        private string password;
        private string cnp;
        private DateTime dataNastere;

        public Utilizator() { }
        public Utilizator(string nume, string email, string password, string cnp, DateTime dataNastere) {
            this.nume = nume;
            this.email = email;
            this.password = password;
            this.cnp = cnp;
            this.dataNastere = dataNastere;
        }

        public string Nume {
            get { return nume; }
            set { nume = value; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public string Password {
            get { return password; }
            set { password = value; }
        }

        public string CNP {
            get { return cnp; }
            set { cnp = value; }
        }
        public DateTime DataNastere {
            get { return dataNastere; }
            set { dataNastere = value; }
        }
    }
}
