int m = 1;
int n = 5;

Console.Clear();
PrintNaturalNumbers(m, n);

void PrintNaturalNumbers(int m, int n)
{
    if (m > n)
        return;
    Console.WriteLine(m);
    PrintNaturalNumbers(m + 1, n);
}