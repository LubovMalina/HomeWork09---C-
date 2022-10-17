/* Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7
*/

Console.Clear();

Console.WriteLine("Введите первое число (M)");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число (N)");
int N = Convert.ToInt32(Console.ReadLine());
    
int a = CommonDivisor(M,N);
   
if (M < N)
    {
       Console.WriteLine("Введите первое число большe чем второе");
    }
else
    {
        Console.WriteLine($"НОД ({M}, {N}) равен {a}");
    }

int CommonDivisor(int M, int N)
{
    if (M % N == 0) 
    {   
        return N;
    }
    else
    {
        return CommonDivisor (N, (M % N));
    }
}    
