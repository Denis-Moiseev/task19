string GetInput(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string num = GetInput("Введите пятизначное число: ");
if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine($"Число {num} является палиндромом.");
}
 else
    Console.WriteLine($"Число {num} не является палиндромом.");