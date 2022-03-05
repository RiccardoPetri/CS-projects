    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficinaProject.model.veicolo.macchina
{
    class Macchina : Veicolo, IRevisionabile
    {
        public Macchina(string marca, string modello, double cilindrata, double km) : base(marca, modello, cilindrata, km)
        {
        }

        public string Revisione(string marca, string modello, double cilindrata, double km)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Veicolo: Macchina -> " + base.ToString();
        }






    }
}
