using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Model
{
    public class Usuario
    {
        public string UserName { get; set; }
        public string Contrasenia { get; set; }
        public Usuario()
        {

        }

        public Usuario(string userName, string contrasenia)
        {
            UserName = userName;
            Contrasenia = contrasenia;
        }
    }
}
