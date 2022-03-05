using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficinaProject.model.veicolo.camion.util;

namespace OfficinaProject.model.veicolo.camion
{
    class Telepass
    {
        public Telepass(string id, TipoTelepass tipo)
        {
            Id = id;
            Tipo = tipo;
            
        }

        public String Id { get; set; }
        public TipoTelepass Tipo { get; set; }
        public DateTime Scadenza { get; set; }

        public override string ToString()
        {
            return "Id -> "+Id +" tipo Telepass -> " +Tipo;
        }
    }
}
