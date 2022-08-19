// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine($"\nЗадача 29. Ряд чисел в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? Numbs = Console.ReadLine();

Numbs = Numbs + ","; 

string RemSp (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

void СheckNumbs (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода.");

      }
}

int[] ArrayOfNumbs(string seriesNew){ 

  int[] arrayOfNumbs = new int[1];

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumbs(seriesNew[i]);
      i++;
    }
    arrayOfNumbs[j] = Convert.ToInt32(seriesNew1);
    if (i < seriesNew.Length-1)
    {
      arrayOfNumbs = arrayOfNumbs.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return arrayOfNumbs;
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

string seriesNew = RemSp(Numbs);

int[] arrayOfNumbs =  ArrayOfNumbs(seriesNew);

PrintArry(arrayOfNumbs);