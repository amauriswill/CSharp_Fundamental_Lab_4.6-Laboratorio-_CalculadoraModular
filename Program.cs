using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Módulo de operaciones matemáticas inicializado.");

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
