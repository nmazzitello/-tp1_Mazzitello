using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Mazzitello
{
    class Deposito
    {
        private int id;
        private String nombre;
        private String mail;
        private String telefono;
        private String direccion;
        private Persona duenio;
        private Seguro seguro;
        private List <Empleado> listaEmpleado;
        private List<Pasillo> listaPasillo; 
    }
}
