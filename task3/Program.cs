bool checkLength(string[] arrL)
{
    if (arrL.Length <= 8 is true)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Введите через запятую не более 8 чисел:");
        return false;
    }
}

bool identifyNums(string[] arrNums)
{
    bool flag = true; 
    for (int i = 0; i < arrNums.Length; i++)
    {
        if ((int.TryParse(arrNums[i], out int NumInt) | double.TryParse(arrNums[i], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double NumDouble)) == false)
            {
                Console.WriteLine("Введите через запятую не более 8 ТОЛЬКО чисел:");
                flag = false;                
                break;
            }
    }
    return flag;
}

void printArr(string[] arrP)
{
    Console.Write("[");
    for (int iArrP = 0; iArrP < arrP.Length; iArrP++)
    {
        Console.Write(arrP[iArrP]);
        if (iArrP == arrP.Length - 1) 
            Console.Write("]");
        else
            Console.Write(", ");
    }
}

string[] arr;
Console.WriteLine("Введите через запятую не более 8 чисел:");
do
{
    string strIn = Convert.ToString(Console.ReadLine());
    arr = strIn.Replace(" ", "").Split(new char[] {','});
}
while((checkLength(arr) && identifyNums(arr)) == false);
printArr(arr);