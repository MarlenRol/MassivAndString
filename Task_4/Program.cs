// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, 
// в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

void Main()
{
    string str = "Привет Марлен как дела";
    Console.WriteLine(ReverceStr(str));
}

static string ReverceStr(string str)
{
    string[] arrStr = str.Split(' ');
    string reversStr = "";
    for (int i = arrStr.Length-1; i >= 0; i--)
    {
        reversStr += arrStr[i] + " ";
    }
    return reversStr;
}
Main();