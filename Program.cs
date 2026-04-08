int a = 10;
int b = 6;

static int penjumlahan(int a, int b)
{
    return a + b;
}
static int pengurangan(int a, int b)
{
    return a - b;
}
static int perkalian(int a, int b)
{
    return a * b;
}
static int pembagian(int a, int b)
{
    return a / b;
}

Console.WriteLine("penjumlahan: " + a + " + " + b + " = " + penjumlahan(a, b));
Console.WriteLine("pengurangan: " + a + " - " + b + " = " + pengurangan(a, b));
Console.WriteLine("perkalian: " + a + " * " + b + " = " + perkalian(a, b));
Console.WriteLine("pembagian: " + a + " / " + b + " = " + pembagian(a, b));
