// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
void Main()
{
    char[,] arrChar = { { 'a', 'b' }, { 'd', 's' } };
    Console.WriteLine(NewString(arrChar));
}
static string NewString(char[,] arrChar)
{
    string res = "";
    for (int i = 0; i < arrChar.GetLength(0); i++)
    {
        for (int j = 0; j < arrChar.GetLength(1); j++)
        {
            res += arrChar[i, j];
        }
    }
    return res;
}
Main();
