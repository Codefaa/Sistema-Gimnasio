using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_BE
{
    public class BELogin : Entidad
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public BELogin()
        {

        }
        public BELogin(string usuario, string contraseña)
        {
            this.Usuario = usuario;
            this.Contraseña = contraseña;
        }
    }
}
