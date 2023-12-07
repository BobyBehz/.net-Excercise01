
Console.WriteLine("Hello, Alireza!");

Console.WriteLine("Practice 1: display stars");
Console.WriteLine("please enter a number");

int inputNumber = Convert.ToInt32(Console.ReadLine());
string star = "";

for (int i = 0; i < inputNumber; i++)
{
    Console.WriteLine(star += "*");
}

Console.WriteLine("Practice 2: first bigger prime number");
Console.WriteLine("please enter a number");
inputNumber = Convert.ToInt32(Console.ReadLine());
int primeNumber = 0;

if (inputNumber <= 2)
{
    primeNumber = 2;
    Console.WriteLine($"first bigger prime numbert is {primeNumber}");
}
else
{
    for (int number = inputNumber + 1; number > 0; number++)
    {
        for (float i = 2; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (i < number)
                {
                    break;
                }
                else
                {
                    primeNumber = number;
                    Console.WriteLine($"first bigger prime number is {primeNumber}");

                }
            }
        }
        if (primeNumber > 0)
        {
            break;
        }
    }
}
Console.WriteLine("practice 3: integer multiples of a number");
Console.WriteLine("please enter a number");
inputNumber = Convert.ToInt32(Console.ReadLine());
int[] integerMultiples = {1};
var integerMultiplesList = integerMultiples.ToList();

for (int i = 2; i <= inputNumber; ++i)
{
    if (inputNumber % i == 0)
    {
        integerMultiplesList.Add(i);
    }
}
integerMultiples = integerMultiplesList.ToArray();
Console.WriteLine($"here are the integer multiples: {string.Join("-", integerMultiples)}");

Console.WriteLine("practice 4: check if the number is pallindrum");
Console.WriteLine("please enter a number");
string myNumber = Console.ReadLine();

char[] numberDigits = myNumber.ToCharArray();
string reversedNumber = string.Join("", numberDigits.Reverse());

if (myNumber == reversedNumber)
{
    Console.WriteLine($"{myNumber} IS A PALLINDRUM NUMBER");
} else
{
    Console.WriteLine($"{myNumber} IS NOT A PALLINDRUM NUMBER");
}

Console.WriteLine("FINNISHED");