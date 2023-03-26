// // Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
int UserNumberN = GetNumberFromUser("Задайте целое чисел M: ","Ошибка ввода!");
int UserNumberM = GetNumberFromUser("Задайте целое чисел N: ","Ошибка ввода!");
Console.Write($"M = {UserNumberM}, N = {UserNumberN} -> ");
int SumInterval = 0;
if (UserNumberM == UserNumberN) SumInterval = UserNumberM;
if (UserNumberM > UserNumberN)
{
    SumInterval = GetSumInterval(UserNumberM, UserNumberN);
}
else
{
    SumInterval = GetSumInterval(UserNumberN, UserNumberM);
}

Console.Write($"N = {UserNumberN}; M = {UserNumberM} -> { SumInterval}");

///////

// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

int GetSumInterval(int M, int N)
{
    if(M == N-1) return 0;
    else return M + GetSumInterval(M-1, N);
}
