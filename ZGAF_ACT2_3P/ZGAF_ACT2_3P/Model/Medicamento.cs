using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZGAF_ACT2_3P.Model
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string NombreGeneral { get; set; }
        public string FormaFarmaceutica { get; set; }
        public string Concentracion { get; set; }
        public string PricipalIndicacion { get; set;}
        public int PrecioUnidad { get; set; }
        public int Activo { get; set; }
        public int UnidadesEnvase { get; set; }
        public string UnidadMedida { get; set; }
        public int Categoria { get; set; }
    }
}
