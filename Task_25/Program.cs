// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine($"\n25. Возведение числа A в натуральную степень B");

int Exponentiation(int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; i++){
    result = result * numA;
  }
    return result;
}

Console.Write("Введите A - число, которое нужно возвести в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B - степень, в которую нужно возвести число А: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);

