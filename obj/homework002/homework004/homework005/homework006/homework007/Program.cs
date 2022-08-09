// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) 
if (i % 2 == 0) 
{
    Console.WriteLine(i);
}
