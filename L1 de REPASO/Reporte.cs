using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_de_REPASO
{
    class Reporte
    {
        int codigo;
        string nombre;
        string mes;
        float salario;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        
        public string Mes { get => mes; set => mes = value; }
        public float Salario { get => salario; set => salario = value; }
    }
}
