// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра этого числа "+ stringNumber[1]);