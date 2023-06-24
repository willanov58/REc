Console.Clear();
void PrintNumber(int n, int count)
{
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int InputNumbers(string mes)
{
    Console.Write(mes);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int n = InputNumbers("Введите N: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

