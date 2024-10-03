// See https://aka.ms/new-console-template for more information

Suma1(0, 0);
Console.WriteLine("La suma es: " + Suma2(0,0));
Suma3();
Console.WriteLine("La suma es: " + Suma4());
void Suma1(int num1, int num2)
{
    Console.Write("Ingrese Número 1: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese Número 2: ");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("\nLa suma es: " + (num1 + num2));
}


static int Suma2(int num1, int num2)
{
    Console.Write("Ingrese Número 1: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese Número 2: ");
    num2 = int.Parse(Console.ReadLine());
    return num1 + num2;
}

static void Suma3()
{
    Console.Write("Ingrese Número 1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese Número 2: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("\nLa suma es: " + (num1 + num2));
}


static int Suma4()
{
    int num1, num2;
    Console.Write("Ingrese Número 1: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese Número 2: ");
    num2 = int.Parse(Console.ReadLine());

    return num1 + num2;
}