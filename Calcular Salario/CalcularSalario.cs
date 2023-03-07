using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Salario
{
    public class CalcularSalario
    {
        public string CPF { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public double ValorHora { get; set; }

        public int HorasTrabalhadas { get; set; }

        public double Salario { get; private set; }

        public void CalculoDoSalario()
        {
            Salario = ValorHora * HorasTrabalhadas;
        }

        
    }
}
