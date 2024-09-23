Console.Write("Enter age to find out if you can go to study in shag:");
int age = int.Parse(Console.ReadLine());
if (age >= 15 && age <= 55)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("you fit SIGMA MEN");
    Console.ResetColor();
}


else
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("You not fit Skuf!!!!");
    Console.ResetColor();
}
