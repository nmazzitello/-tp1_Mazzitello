using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Mazzitello
{
    class Compartimiento
    {
        private long id;
        private int numeroCompartimiento;
        private bool estatus;   // si esta en true, significa que esta ocupado
        private char lado;      //identifica que lado del pasillo se encuenta (A/B)
        private Producto prod;
        private Alquiler alqui;
    }
}
