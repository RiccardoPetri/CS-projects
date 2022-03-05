using System;
using System.Collections.Generic;
using OfficinaProject.model.util;
using OfficinaProject.model.veicolo;

namespace OfficinaProject
{
    internal class Officina
    {
        public string Nome { get; set; }
        
        public int MaxVeicoli { get; set; }

        public int VeicoliInseriti { get; set; }
        public List<Veicolo> VeicoliList  { get; set; } //non mappa (non ho un identificativo)

        public Officina(string nome, int maxVeicoli)
        {
            this.Nome = nome;
            this.MaxVeicoli = maxVeicoli;
            this.VeicoliInseriti = 0;
            VeicoliList = new List<Veicolo>();
        }

        public bool AggiungiVeicolo(Veicolo nuovo)
        {
            try
            {
                if(nuovo != null)
                {
                    if(VeicoliList.Count < MaxVeicoli)
                    {
                        VeicoliInseriti++;
                        Console.WriteLine("Inserito veicolo: " + nuovo.modello);
                        VeicoliList.Add(nuovo);
                        return true;
                    }
                    throw new NumeroMassimoVeicoliException("Numere veicoli inseribili esaurito");

                }
                throw new NullReferenceException("nuovo è null");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NumeroMassimoVeicoliException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return false;
        }

        internal bool RimuoviVeicolo(Veicolo remove)
        {
            VeicoliList.Remove(remove);
            VeicoliInseriti--;
            return true;
        }


        public override string ToString()
        {
            string listString = "";
            foreach(var item in VeicoliList)
            {
                listString += item.ToString() + "\n";
            }
            return listString;
        }
    }
}