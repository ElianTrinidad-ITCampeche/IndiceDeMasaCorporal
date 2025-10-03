using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiceDeMasaCorporal.Console
{
    // Clase que representa a una persona con peso y estatura y operaciones para el calculo del IMC y Estado Nutricional
    internal class Persona
    {
        public double Peso;
        public double Estatura;

        public Persona(double PesoPersona, double EstaturaPersona)
        {
            Peso = PesoPersona;
            Estatura = EstaturaPersona;
        }
    
        // Procedimiento para el calculo del IMC
        public double CalcularIMC()
        {
            return Peso / (Estatura * Estatura);
        }

        // Devuelve el estado nutricional según la OMS
        public string ObtenerEstadoNutricional()
        {
            double IMC = CalcularIMC();

            if (IMC < 18.5)
                return "Peso bajo";
            if (IMC >= 18.5 && IMC < 25.0)
                return "Peso normal";
            if (IMC >= 25 && IMC < 30.0)
                return "Sobrepeso";
            if (IMC >= 30 && IMC < 40.0)
                return "Obesidad";
            if (IMC >= 40.0)
                return "Obesidad extrema";
            return "Datos inválidos";
        }
    }
}

