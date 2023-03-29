// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
uint UserNumberN = GetNumberFromUser("Задайте целое неотрицательное n: ","Ошибка ввода!");
uint UserNumberM = GetNumberFromUser("Задайте целое неотрицательное m: ","Ошибка ввода!");
Console.Write($"N = {UserNumberN}, M = {UserNumberM}-> A({UserNumberN}, {UserNumberM}) = ");
uint Akkerman = 0;
Akkerman = GetAkkerman(UserNumberN, UserNumberM);

Console.WriteLine(Akkerman);

///////

// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа uint.
// В случае ошибки выводит в консоль сообщение errorMessage
uint GetNumberFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint userNumber);
        if(isCorrect) return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

/// Функция Аккермана
uint GetAkkerman(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return GetAkkerman(n - 1, 1);
    else
      return GetAkkerman(n - 1, GetAkkerman(n, m - 1));
}
