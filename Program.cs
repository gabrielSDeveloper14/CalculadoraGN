

/* 
 PROGRAMACION 1 (Lunes a las 6:00pm)
Nombre: Gabriel Alexander Nuñez Peña
Matricula: 2024-1671
*/

//TODO: aqui estoy creando mi clase calculadora 
class Calculadora
{
    private double ultimoResultado;

    public double UltimoResultado
    {
        get { return ultimoResultado; }
        private set { ultimoResultado = value; }

    }

    public double Sumar(double a, double b)

    {
        UltimoResultado = a + b;
        return UltimoResultado;
    }

    public double Restar(double a, double b)

    {
        UltimoResultado = a - b;
        return UltimoResultado;
    }

    public double Multiplicar(double a, double b)

    {
        UltimoResultado = a * b;
        return UltimoResultado;
    }

    public double Dividir(double a, double b)

    {
        if (b == 0)
        {

            throw new DivideByZeroException("No se puede dividir entre cero.");
        }

        UltimoResultado = a / b;
        return UltimoResultado;
    }
}

//TODO: aqui tengo mi clase program


public class Program
{
    public static void Main()
    {
        Calculadora calculadora = new Calculadora();
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("    Calculadora   ");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Ultimo Resultado");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opcion: ");

            string opcion = Console.ReadLine();

            if (opcion == "6")
            {
                continuar = false;
                break;
            }

            if (opcion == "5")
            {
                Console.WriteLine($"El ultimo resultado es: {calculadora.UltimoResultado}");
                Console.ReadKey();
                continue;
            }

            Console.Write("Ingresa el primer numero: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            double b = Convert.ToDouble(Console.ReadLine());

            try
            {
                double resultado = opcion switch
                {
                    "1" => calculadora.Sumar(a, b),
                    "2" => calculadora.Restar(a, b),
                    "3" => calculadora.Multiplicar(a, b),
                    "4" => calculadora.Dividir(a, b),
                    _ => double.NaN
                };

                if (!double.IsNaN(resultado))
                {
                    Console.WriteLine($"El resultado es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Opcion no valida.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("¡Hasta luego!");
    }
}





