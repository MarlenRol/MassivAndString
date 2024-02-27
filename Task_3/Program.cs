// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
void Main()
{
    string str = "шалаш";  
    Console.WriteLine(IsPalindrome(str)?"Да":"Нет");
}

bool IsPalindrome(string str)
{
    int countStr = str.Length;
    string palindrom = "";
    for (int i = 0; i < str.Length; i++)
    {  countStr--;
        palindrom += str[countStr];      
    }
    if (palindrom == str)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Main();