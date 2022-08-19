// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine($"\n27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

  int SumNum (int numN)
  {
    int counter = Convert.ToString(numN).Length;
    int a = 0;
    int r = 0;

    for (int i = 0; i < counter; i++){
      a = numN - numN % 10;
      r = r + (numN - a);
      numN = numN / 10;
    }
   return r;
  }

int sumNum = SumNum(numN);
Console.WriteLine("Сумма цифр в числе: " + sumNum);

