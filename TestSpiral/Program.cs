using System;

namespace TestSpiral
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = 1;//счетчик для заполнения значениями
			int a =0, c = 0, s = 0;//a - размер массива, c - номер столбца, s - номер строки
			int end;//счетчик до конца строки/столбца
			int ci = 1, si = 1; //ni - множитель для столбцов, mi - множитель для строк
			while (a < 1)
			{
				Console.WriteLine("Введите размер стороны квадрата и нажмите Enter:");
				if (!Int32.TryParse(Console.ReadLine(), out a) || a==0)
				{
					Console.WriteLine("Значение введено некорректно, повторите ввод");
				}				
				
			}
			end = a;
			int[,] ar = new int[a, a];
			
			while (x<=Math.Pow(a,2))
			{
				//проход по строкам
				str();
				s = s + si;
				ci = -1 * ci;
				end--;
				if (x > Math.Pow(a, 2)) break;
				//проход по столбцам
				col();
				si = -1 * si;
				c = c + ci;
			}
			//вывод на печать
			print_array(ar);
			//проход в рамках одной строки
			void str()
			{
				for (int i = c, f = 0; f < end; i=i+ci, f++)
				{
					ar[s, i] = x;
					x = x + 1;
					c = i;
				}
			}
			//проход в рамках одного столбца 
			void col()
			{
				for (int i = s, f = 0; f < end; i=i+si, f++)
				{
					ar[i, c] = x;
					x = x + 1;
					s = i;
				}
			}
			//вывод массива в консоль
			void print_array(int[,] arr)
			{
				for (int i = 0; i < a; i++)
				{
					Console.WriteLine();
					for (int j = 0; j < a; j++)
					{
						Console.Write($"{arr[i, j]}\t");
					}
				}
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine("-----------------------");
				Console.ReadKey();
			}
			
        }
    }
}
