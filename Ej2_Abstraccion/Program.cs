namespace Ej2_Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente()
            {
                Nombre = "Citelli",
                Antiguedad = 16,
                Salario = 150000,
            };
            Programador programador = new Programador()
            {
                Nombre = "Pedro",
                Antiguedad = 9,
                Salario = 900000,
            };
            Diseñador diseñador = new Diseñador() 
            {
            Nombre = "Juan",
            Antiguedad = 5,
            Salario = 50000,
            };

            Console.WriteLine($"El gerente {gerente.Nombre} tiene una antiguedad de" +
                $" {gerente.Antiguedad}  años y su salario es de {gerente.CalcularSalario()}");

            Console.WriteLine($"El programador{programador.Nombre} tiene una antiguedad de" +
                $" {programador.Antiguedad} años y su salario es de {programador.CalcularSalario()}");

            Console.WriteLine($"El diseñador {diseñador.Nombre} tiene una antiguedad de" +
                $" {diseñador.Antiguedad} años y su salario es de {diseñador.CalcularSalario()}");
        }
    }
}