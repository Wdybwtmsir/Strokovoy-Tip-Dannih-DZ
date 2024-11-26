using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите любой текст:");
        string input = Console.ReadLine(); 

        bool containsDigit = false;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                containsDigit = true;
                break;
            }
        }
     
        if (containsDigit)
        {
            Console.WriteLine("Ну типа вроде как есть цифра хэ прикол");
        }
        else
        {
            Console.WriteLine("Нету тут ничего Андрей Валентинович ну ёмаё");
        }
    }
}