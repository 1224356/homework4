int readNum(int iletter)
{
    string[] letters = {"A", "B"};
    int result = 1;
    do
    {
        if (result <= 0)
        {
            Console.Write("Число B должно быть больше 0! ");
        }
        Console.Write($"Введите число {letters[iletter]}:");
        result = Convert.ToInt32(Console.ReadLine());
    }
    while (iletter == 1 && result <= 0);
    return result;
}

int Exponentiation(int num, int degree)
{
    int resultExp = 1;
    for (int i = 0; i < degree; i++)
    {
        resultExp = resultExp * num;
    }
    return resultExp;
}

int A = readNum(0), B = readNum(1);
Console.Write(Exponentiation(A,B));

