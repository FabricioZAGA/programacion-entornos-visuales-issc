using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZGAF_07.Model;

namespace ZGAF_07.Controller
{
    public class ControllerUsuario
    {
        private Usuario usuario;

        public ControllerUsuario()
        {
            usuario = new Usuario();
            usuario.NombreUsuario = "JuanLopez";
            usuario.Contrasenia = "12345678";
        }

        public string GetNombreUsuario()
        {
            return usuario.NombreUsuario;
        }
        public string GetContrasenia()
        {
            return usuario.Contrasenia;
        }
    }
}
