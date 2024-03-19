using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW {
    public class Utilizator {
        private string nume;
        private string email;
        private string password;
        private string cnp;
        private DateTime dataNastere;

        public Utilizator() { }
        public Utilizator(string nume, string email, string password, string cnp) {
            this.nume = nume;
            this.email = email;
            this.password = password;
            this.cnp = cnp;
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
    }
}
