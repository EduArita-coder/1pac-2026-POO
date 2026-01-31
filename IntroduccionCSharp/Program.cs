/*Persona persona1 = new Persona("Juan", "Pérez", "Masculino", 30);
Console.WriteLine("Hola "+ persona1.Nombres + " "+ persona1.Apellidos + ", usted tiene  "+persona1.Edad + " años");
Console.WriteLine(persona1.Nombres + " " + persona1.Apellidos + " " + persona1.Genero + " " + persona1.Edad); // Salida: Juan Pérez Masculino 30*/
using System.Linq.Expressions;
using IntroduccionCSharp.Ejemplos;

Calculadora calculadora = new Calculadora();
Console.WriteLine("======Calculadora======");
Console.WriteLine("");
string operacion = "";
int n1 = 0;
int n2 = 0;
try
{
    Console.WriteLine("Ingrese la operación a realizar (+,-,*,÷):");
    operacion = Console.ReadLine();

    Console.WriteLine("Ingrese el primero número:");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número:");
    n2 = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Error: Debe ingresar números válidos.");
}
int resultado = 0; 
    switch (operacion)
    {
        case "+":
             resultado = calculadora.sumar(n1, n2);
            break;

        case "-":
             resultado = calculadora.restar(n1, n2);
            break;

        case "*":
             resultado = calculadora.multiplicar(n1, n2);
            break;

        case "÷":
            resultado = calculadora.dividir(n1, n2);
            break;
        default:
        throw new Exception("No ingreso una operación válida");
    }
   Console.WriteLine("el resultado de la operación es: " + resultado);
    


