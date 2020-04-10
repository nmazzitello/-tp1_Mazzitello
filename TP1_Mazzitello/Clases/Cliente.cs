using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Mazzitello
{
    class Cliente: Persona
    {
        private int numCliente;
        private DateTime fechaRegistro;     //fecha que se registra cliente nuevo
        private string identificacion;      //particular--> dni / empresa u organizacion --> cuit 
        private List<Producto> productos;
    }
}
