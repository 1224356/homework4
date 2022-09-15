int NumLength(int num)
{
    int i = 1;
    while (num / 10 != 0)
    {
        i++;
        num = num / 10;
    }
    return i;
}

int[] Int2Mas (int num, int NumLen)
{
    int[] result = new int[NumLen];
    while (NumLen > 0)
    {
        result[NumLen-1] = num%10;
        num = num/10;
        NumLen--;
    }
    return result;
}

void sumNums(int[] NumMas)
{
    int sum = 0;
    foreach (int numb in NumMas)
    {
        sum = sum + numb;
    }
    Console.Write(sum);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
sumNums(Int2Mas(num, NumLength(num)));





