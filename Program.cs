//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.Write("Past the number A -> ");
int number_A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Past the number B -> ");
int number_B = Convert.ToInt32(Console.ReadLine());

if(number_A > number_B)
{
    System.Console.WriteLine($"max = {number_A}");
}
else System.Console.WriteLine($"max = {number_B}");