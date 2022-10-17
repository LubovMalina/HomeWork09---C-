/* Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8

*/

Console.Clear();

Console.WriteLine("Введите первое число (M)");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (N)");
int N = Convert.ToInt32(Console.ReadLine());
if (M>N)
    {
       Console.WriteLine("Введите первое число меньше чем второе");
    }
else
    {
       Recurs(M,N);
    }

void Recurs(int M, int N)
    {
        if (M <= N)
        {
            if (M%2 == 0)
            {           
            Console.Write(" " + M);
            M = M+2;
            Recurs(M,N);
            }
            else
            {
            M++; 
            Recurs(M,N);  
            }
            
        }
        else  return;
    }