using System.Globalization;
using System.Text;

ConfigurarConsola();
EjecutarCalculadora();

static void ConfigurarConsola()
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.InputEncoding = Encoding.UTF8;
}

static void EjecutarCalculadora()
{
    bool continuar = true;

    do
    {
        MostrarMenu();
        int opcion = LeerOpcion();

        switch (opcion)
        {
            case 1:
                EjecutarSuma();
                break;
            case 2:
                EjecutarResta();
                break;
            case 3:
                EjecutarMultiplicacion();
                break;
            case 4:
                EjecutarDivision();
                break;
            case 5:
                MostrarDespedida();
                continuar = false;
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Error: Opción no válida. Ingrese un número entre 1 y 5.");
                break;
        }

        if (continuar)
        {
            Console.WriteLine();
        }

    } while (continuar);
}

static void MostrarMenu()
{
    Console.WriteLine("========================================");
    Console.WriteLine("          CALCULADORA MODULAR           ");
    Console.WriteLine("========================================");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.WriteLine("========================================");
}

static int LeerOpcion()
{
    Console.Write("Seleccione una opción (1-5): ");
    string entrada = Console.ReadLine()?.Trim() ?? string.Empty;

    if (int.TryParse(entrada, out int opcion))
    {
        return opcion;
    }

    return -1;
}

static decimal LeerNumero(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine()?.Replace(',', '.').Trim() ?? string.Empty;

        if (decimal.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor))
        {
            return valor;
        }

        Console.WriteLine("Error: Debe ingresar un valor numérico válido.");
    }
}

static void EjecutarSuma()
{
    Console.WriteLine("\n--- Operación: Suma ---");
    decimal a = LeerNumero("Ingrese el primer número: ");
    decimal b = LeerNumero("Ingrese el segundo número: ");
    decimal resultado = Sumar(a, b);
    MostrarResultado("+", a, b, resultado);
}

static void EjecutarResta()
{
    Console.WriteLine("\n--- Operación: Resta ---");
    decimal a = LeerNumero("Ingrese el primer número: ");
    decimal b = LeerNumero("Ingrese el segundo número: ");
    decimal resultado = Restar(a, b);
    MostrarResultado("-", a, b, resultado);
}

static void EjecutarMultiplicacion()
{
    Console.WriteLine("\n--- Operación: Multiplicación ---");
    decimal a = LeerNumero("Ingrese el primer número: ");
    decimal b = LeerNumero("Ingrese el segundo número: ");
    decimal resultado = Multiplicar(a, b);
    MostrarResultado("×", a, b, resultado);
}

static void EjecutarDivision()
{
    Console.WriteLine("\n--- Operación: División ---");
    decimal a = LeerNumero("Ingrese el primer número (dividendo): ");
    decimal b = LeerNumero("Ingrese el segundo número (divisor): ");

    if (b == 0)
    {
        Console.WriteLine();
        Console.WriteLine("Error: No es posible dividir entre cero.");
        return;
    }

    decimal resultado = Dividir(a, b);
    MostrarResultado("/", a, b, resultado);
}

static decimal Sumar(decimal a, decimal b)
{
    return a + b;
}

static decimal Restar(decimal a, decimal b)
{
    return a - b;
}

static decimal Multiplicar(decimal a, decimal b)
{
    return a * b;
}

static decimal Dividir(decimal a, decimal b)
{
    return a / b;
}

static void MostrarResultado(string operador, decimal a, decimal b, decimal resultado)
{
    Console.WriteLine();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Resultado: {a} {operador} {b} = {resultado}");
    Console.WriteLine("----------------------------------------");
}

static void MostrarDespedida()
{
    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("¡Gracias por usar la Calculadora Modular!");
    Console.WriteLine("========================================");
}
