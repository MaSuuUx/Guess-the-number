int myNum = 0, attempts = 0;

Random num = new Random();
int numRan = num.Next(1, 101);


Console.WriteLine("Guess the number");

Console.WriteLine("Enter a number from 1 to 100");

while (myNum != numRan)
{
    attempts++;

    myNum = Int32.Parse(Console.ReadLine());
    if (myNum < numRan) Console.WriteLine("The number is higher");
    if (myNum > numRan) Console.WriteLine("The number is lower:");

}
Console.WriteLine($"You got the number right, it was {numRan}, congratulations.");
Console.WriteLine($"The number of attempts was :{attempts}");
