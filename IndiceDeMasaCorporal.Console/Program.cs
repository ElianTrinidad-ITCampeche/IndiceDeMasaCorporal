using IndiceDeMasaCorporal.Console;
using System;
using System.Globalization;

/*PROCESO PARA PROGRAMAR PSEUDOCÓDIGO (PPP)

1. Mostrar mensaje de bienvenida.
2. Pedir al usuario su peso en kilogramos.
3. Leer y validar el peso (debe ser número > 0).
4. Pedir al usuario su estatura en metros.
5. Leer y validar la estatura (debe ser número > 0).
6. Crear un objeto Persona con peso y estatura.
7. Calcular IMC = Peso / (Estatura * Estatura).
8. Determinar estado nutricional según OMS:
-IMC < 18.5 "Peso bajo"
- 18.5 <= IMC < 25.0 "Peso normal"
- 25.0 <= IMC < 30.0 "Sobrepeso"
- 30.0 <= IMC < 40.0 "Obesidad"
- IMC >= 40.0 "Obesidad extrema"
9.Mostrar IMC(4 decimales) y el estado nutricional.
10. Terminar programa. 

 ANÁLISIS DEL PROBLEMA
a) Datos de entrada:
- Peso en kilogramos 
- Estatura en metros
b) Datos de salida:
- Índice de Masa Corporal (IMC), valor numérico (double)
- Estado nutricional (string) según clasificación OMS
c) Datos temporales:
- IMC (double)
- Mensajes temporales para mostrar en consola
d) Métodos / cálculos necesarios:
- CalcularIMC(peso, estatura): devuelve double
- ObtenerEstadoNutricional (imc): devuelve string 
e) Casos de prueba a utilizar para validar la solución:
- Validación de entradas
- Cálculos correctos del IMC
- Clasificación según OMS en todos los límites
- Comportamiento del flujo del programa
- Formato de salida correcto. */

double PesoPersona;
double EstaturaPersona;
double IMC;
string EstadoNutricional;
string opcion;

Console.WriteLine("Bienvenido al Calculo de IMC y Estado Nutricional");

do {
    Console.WriteLine();

    // Leer y validar Peso
    while (true) 
    {
        Console.Write("Ingresa tu peso en kilogramos (kg): ");
        string? entrada = Console.ReadLine();

        // Validamos que no esté vacío y que sea número mayor que 0
        if (double.TryParse(entrada, out PesoPersona) && PesoPersona > 0) 
            {
                break; // Salimos del ciclo si es válido
            }

        Console.WriteLine("Entrada inválida. Por favor ingresa un número mayor que 0.\n"); 
    }

    // Leer y validar Estatura
    while (true) 
    {
        Console.Write("Ingresa tu estatura en metros (m): ");
        string? entrada = Console.ReadLine();

        // Validamos que no esté vacío y que sea número mayor que 0
        if (double.TryParse(entrada, out EstaturaPersona) && EstaturaPersona > 0)
            {
                break; // Salimos del ciclo si es válido
            }

        Console.WriteLine("Entrada inválida. Por favor ingresa un número mayor que 0.\n"); 
    }

    // Crear objeto Persona y calcular IMC y Estado Nutricional
    var persona = new Persona(PesoPersona, EstaturaPersona);
    IMC = persona.CalcularIMC();
    EstadoNutricional = persona.ObtenerEstadoNutricional();


    Console.WriteLine();
    Console.WriteLine($"IMC calculado: {IMC:F4}");
    Console.WriteLine($"Estado nutricional: {EstadoNutricional}");

    // Preguntar si desea repetir el calculo de IMC y Estado Nutricional
    Console.WriteLine();
    Console.Write("\n¿Deseas calcular otro IMC? (s/n): ");
    opcion = Console.ReadLine()!.Trim().ToLower();

} while (opcion == "s" || opcion == "si");


