// Console.ReadLine()-получение данных из терминала
// Convert.ToInt32()- из строки преобразовываем в число
// Console.WriteLine()- выводит текст на экран
// Создание переменных состоит из типа данных(int floar string bool double) и названия переменной


// int number1=Convert.ToInt32(Console.ReadLine());
// int number2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number1+number2);

int secretnumber=new Random().Next(1,11);
int popytki = 3;
 bool flagwin=false;
 while(popytki>0)
 {
      Console.WriteLine("Введите число от 1 до 10");
      int usernumber=Convert.ToInt32(Console.ReadLine());
      popytki--; // 2 1 0
    if(usernumber > secretnumber)
   {
      Console.WriteLine("Секретное число меньше");
      Console.WriteLine("Попыток осталось" + popytki);
   }
   else if(usernumber < secretnumber)
   {
      Console.WriteLine("Секретное число больше");
      Console.WriteLine("Попыток осталось" + popytki);  
   }
   else
   {
      Console.WriteLine("Мы выиграли");
      flagwin=true;
      break;
   }
   
 }
if(!flagwin)
{
   Console.WriteLine("Мы проиграли.Число было"+ secretnumber);
}

