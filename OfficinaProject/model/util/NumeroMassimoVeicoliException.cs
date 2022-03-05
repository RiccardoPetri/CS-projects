using System;

namespace OfficinaProject.model.util
{
    class NumeroMassimoVeicoliException : Exception
    {
        public NumeroMassimoVeicoliException(string message) : base(message)
        {
            Console.WriteLine(Message);
        }
    }
}
