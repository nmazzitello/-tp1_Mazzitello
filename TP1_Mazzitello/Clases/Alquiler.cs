using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Mazzitello
{
    class Alquiler
    {
        private int id;
        private int numCliente;
        private DateTime iniCont;   //fecha en que se firma el contrato
        private DateTime finCont;   //fecha finalizacion contrato
        private int[] precioAlq;       //tamaño de 4, ya que las actualizacion del alq es cada 6 meses y los contratos de 2 años
    }
}
