int opcion, x = 0, y = 0;
do
{
    Console.WriteLine("**************************************");
    Console.WriteLine("\tBienvenidos al sistema \n\t de Funciones Básicas\n");
    Console.WriteLine("\t1. Suma");
    Console.WriteLine("\t2. Resta");
    Console.WriteLine("\t3. Multiplicación");
    Console.WriteLine("\t4. Division");
    Console.WriteLine("\t0. Salir");
    Console.WriteLine(" ");
    Console.WriteLine("**************************************");
    Console.Write("\nIngrese una opción: ");
    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

} while (opcion < 0 || opcion > 4);
if (opcion != 0)
{
    Console.Write("Ingresar x: ");
    x = int.Parse(Console.ReadLine());
    Console.Write("Ingresar y: ");
    y = int.Parse(Console.ReadLine());
}
switch (opcion)
{
    case 0: Environment.Exit(0); break;
    case 1: Console.Write("\nLa suma es: "); suma(x,y); break;
    case 2: Console.Write("\nLa resta es: "); resta(x, y); break;
    case 3: Console.Write("\nLa multiplicación es: "); multi(x, y);  break;
    case 4: Console.Write("\nLa división es: "); divi(x, y);  break;
}
void suma(int x, int y)
{
    Console.WriteLine(x + y);
}
void resta(int x, int y)
{
    Console.Write(x - y);
}
void multi(int x, int y)
{ 
    Console.Write(x * y);
}
void divi(int x, int y)
{
    if (y == 0) 
        Console.WriteLine("Indeterminado");
    else 
        Console.WriteLine(x / y);

}