using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public partial class Cliente
    {
        private String rut;
        private String nombre;
        private int nivel;
        private String codBebida;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public string CodBebida { get => codBebida; set => codBebida = value; }
    }
}
