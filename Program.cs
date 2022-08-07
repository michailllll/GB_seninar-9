// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.WriteLine("введите N");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// Print(n, i);

// void Print(int n, int i)
// {
//   if (i > n) return;
//   Print(n, i + 1);
//   Console.Write(i + ", ");
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("введите N");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите M");
// int m = Convert.ToInt32(Console.ReadLine());
// int temp = m;

// if (m > n) 
// {
//   m = n; 
//   n = temp;
// }
// int summ = 0;
// Sum(m, n, summ);

// void Sum(int m, int n, int summ)
// {
//   summ = summ + n;
//   if (n <= m)
//   {
//     Console.Write($"{summ} ");
//     return;
//   }
//   Sum(m, n - 1, summ);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("введите N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите M");
int m = Convert.ToInt32(Console.ReadLine());


int Akk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akk(m - 1, 1);
  else return Akk(m - 1, Akk(m, n - 1));
}


int FuncAkk = Akk(m, n);

Console.Write($"Функция Аккермана = {FuncAkk} ");

