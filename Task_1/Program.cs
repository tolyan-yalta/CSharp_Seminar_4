// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Не использовать функцию Math.Pow()

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if(B == 0)
{
    A = 1;
    Console.WriteLine("Результат = " + A);
}
else
{
    int temp = A;
    for( int i = 0; i < B-1 ; i++)
    {
        A = A * temp;
    }
Console.WriteLine("Результат = " + A);
}
