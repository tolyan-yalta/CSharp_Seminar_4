// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, 
// которые являются делителями этого числа. 
// (для получения цифр числа операцию приведения числа к строке не использовать)

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 10)
{
    Console.WriteLine("Одна цифра, не соответствует постановке задачи");
}
else
{
    int result = 0;
    int temp = number;
    while(temp > 0)
    {
        int digit = temp % 10;
        temp = temp / 10;
        if(digit != 0)
        {
            if(number % digit == 0)
            {
                result = result + digit;
            }
        }
    }

    Console.WriteLine("Результат = " + result);
}

