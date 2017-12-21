using System;
class Calculator {
    static void Main() {
        try
        {
            int x, y;
            int result;
            string z;
            Console.WriteLine("Первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оператор: ");
            z = Console.ReadLine();
            switch (z)
            {
                case "+":
                    result = x + y;
                    Console.WriteLine("Cумма " + x + " и " + y + " равна " + result + ".");
                    break;
                case "-":
                    result = x - y;
                    Console.WriteLine("Разность " + x + " и " + y + " равна " + result + ".");
                    break;
                case "/":
                    result = x / y;
                    Console.WriteLine("Частное " + x + " и " + y + " равна " + result + ".");
                    break;
                case "*":
                    result = x * y;
                    Console.WriteLine("Произведение " + x + " и " + y + " равна " + result + ".");
                    break;
                default:
                    Console.WriteLine("LOL");
                    break;
            }
        }
        catch (DivideByZeroException)
        { Console.WriteLine("Делить на ноль нельзя!");
        } catch (Exception)
        { Console.WriteLine("Ошибка"); }
        {
            Console.ReadLine();
        }
    }
}