// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите элементы(через пробел): ");

int[] MyArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
System.Console.WriteLine(FindNumber(MyArr));

string FindNumber(int[] arr)
{
    int count = 0;
   for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count ++;
    }
    return $"Количество чисел больше ноля: {count}";
}

