using System;
using System.Collections.Generic;
using System.Linq;

namespace proiectPAW {
    public class Grup {
        
        private List<string> drepturi;
        private List<Utilizator> listaUtilizatori;

        public Grup() {
            drepturi = new List<string>();
            listaUtilizatori = new List<Utilizator>();
        }

        public List<string> GetDrepturi() {
            return new List<string>(drepturi);
        }

        public void SetDrepturi(List<string> drepturi) {
            this.drepturi = new List<string>(drepturi);
        }

        public List<Utilizator> GetListaUtilizatori() {
            List<Utilizator> copieUtilizatori = new List<Utilizator>();
            foreach (Utilizator utilizator in listaUtilizatori) {
                copieUtilizatori.Add(new Utilizator(utilizator.Nume, utilizator.Email, utilizator.Password, utilizator.CNP));
            }
            return copieUtilizatori;
        }

        public void SetListaUtilizatori(List<Utilizator> listaUtilizatori) {
            this.listaUtilizatori = new List<Utilizator>();
            foreach (Utilizator utilizator in listaUtilizatori) {
                this.listaUtilizatori.Add(new Utilizator(utilizator.Nume, utilizator.Email, utilizator.Password, utilizator.CNP));
            }
        }
    }
}
