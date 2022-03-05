using System.Collections;
using System.Collections.Generic;

namespace OfficinaProject.model.veicolo
{
    class VeicoliComparator : IComparer<Veicolo>        //attenzione! mettere il tipo!!!! <Veicolo>
    {

        public int Compare(Veicolo x, Veicolo y)
        {
            if(x.km < y.km)
            {
                return -1;
            }
            else if(x.km > y.km)
            {
                return +1;
            }
            else if(x.cilindrata < y.cilindrata)
            {
                return -1;
            }
            else if(x.cilindrata > y.cilindrata)
            {
                return +1;
            }
            else
            {
                return 0;
            }
        }
    }
}
