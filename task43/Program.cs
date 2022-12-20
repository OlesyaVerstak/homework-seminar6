// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int b1 = inputNumber("Введите b1");
int b2 = inputNumber("Введите b1");
int k1 = inputNumber("Введите k1");
int k2 = inputNumber("Введите k2");

double x = (b2 - b1)/(k1-k2);
double y = k1 * x + b1;
Console.WriteLine ($"Точка пересечения двух прямых = [{x};{y}]");

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

