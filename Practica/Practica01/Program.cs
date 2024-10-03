// See https://aka.ms/new-console-template for more information

int Suma(int d1, int d2)
{
    int x = d1 + d2;
    return x;
}

void Imprime (int texto)
{
    Console.WriteLine(texto);
}

int a = 5;
int b = 6;

//int c = a + b;
int c = Suma(a, b);

Imprime(c);
//Console.WriteLine(c);

b = 10;

    int d = a + b;

Console.WriteLine(d);

double z = 100.0;
float y = (float)100.0;