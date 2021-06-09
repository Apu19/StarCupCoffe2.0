using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class ClienteDAL
    {
        private static List<Cliente> clientes = new List<Cliente>();

        private void Add (Cliente c)
        {
            clientes.Add(c);
        }
        public List<Cliente> GetAll(int nivel)
        {
            return clientes.FindAll(c => c.Nivel == nivel);
        }
        public void remove(String rut)
        {
            clientes.Remove(clientes.Find(c => c.Rut == rut));
        }
    }
}
