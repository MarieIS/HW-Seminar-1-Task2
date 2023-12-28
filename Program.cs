Console.Write("Insert number 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Insert number 2: ");
int number2 = int.Parse(Console.ReadLine());
 if (number1 > number2)
 {
    Console.WriteLine($"{number1} is greater than {number2}");
 }
 else if (number1 < number2)
 {
    Console.WriteLine($"{number2} is greater than {number1}");
 }
  else
  {
    Console.WriteLine($"{number1} is equal to {number2}");
  }