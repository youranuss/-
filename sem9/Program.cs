using System;
					
public class Program
{
	public static void Main()
	{
		// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
		// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
		// M = 4; N = 8. -> ""4, 6, 7, 8""
		
		void PrintInterval(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			for(int i = start; i <= end; i++)
			{
				Console.Write($"{i} ");
			}
		}
		PrintInterval(4, 8);
		
		Console.WriteLine();
		
		// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
		// M = 1; N = 15 -> 120
		// M = 4; N = 8. -> 30
		
		int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
		}
		
		Console.WriteLine(CalculateSumm(4, 8));
	}
}
