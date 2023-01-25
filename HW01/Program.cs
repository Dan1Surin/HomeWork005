// Домашняя работа:

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится
// при помощи нажатия Enter

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

bool B = false;
int count = 0;
while (B != true)
{
    Console.WriteLine("Your number");
    string? number = Console.ReadLine();
    if (number != "stop")
    {
        int a = Convert.ToInt32(number);
        if (a > 0)
        {
            count++;
        }
    }
    else B = true;
}
Console.WriteLine($"положительных чисел - {count}");
