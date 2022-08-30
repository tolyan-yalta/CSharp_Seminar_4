// Назовём число «интересным» если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 
// (Каждый эл-т массива должен быть сгенерирован случайно)

int Interesting_number(int limit)
{
    bool result = false;
    int number;
    do
    {
        number = new Random().Next(22, limit); // Меньше 22 не существует "интересных" чисел.

        int temp = number;
        int multiplication = 1;
        int sum = 0;
        while(temp > 0)
        {
            int digit = temp % 10;
            temp = temp / 10;

            multiplication = multiplication * digit;
            sum = sum + digit;
        }
      
        if(multiplication != 0 && multiplication % sum == 0)
        {
            result = true;
        }
    }
    while(result == false);

    return number;
}

Console.Write("Введите верхний предел генерируемых чисел (22 и выше): ");
int limit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размер массива N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for(int i = 0; i < n; i++) 
{
    array[i] = Interesting_number(limit);
    Console.WriteLine("Элементы массива [ " + i + " ]" + "   " + array[i]);
}
