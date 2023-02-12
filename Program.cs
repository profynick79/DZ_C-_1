// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber<secondNumber)
// {
//     Console.Write("Число " + secondNumber + " больше числа " + firstNumber);
// }
// else
// {
//     Console.Write("Число " + firstNumber + " больше числа " + secondNumber);
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
// из этих чисел.

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());
// int max = firstNumber;
// if (secondNumber>firstNumber)
// {
//     max=secondNumber;
//     }
//     if (max<thirdNumber)
//     {
//         Console.Write("Максимальное число: " + thirdNumber);
//     }
//     else
//     {
//         Console.Write("Максимальное число: " + max);
//        }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// if (Number%2 == 0)
// {
//      Console.Write("Число " + Number + " является четным");
//      }
//      else
//      {
//          Console.Write("Число " + Number + " является НЕчетным");
//         }



// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int firstN = 1;
while (firstN <= N)
{
    if (firstN % 2 == 0)
    {
        Console.Write(firstN + " ");
        firstN++;
        }
    else
    {
        firstN++;
        }   
    }