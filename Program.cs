/*
FizzBuzz Coding Challenge written in C# to determine what numbers in the range from 1 - 100 are divisible by 3
and / or by 5, printing "Fizz" beside those divisible by 3, "Buzz" by those divisible by 5, and
"FizzBuzz" by those divisible by both.
*/

for (int i = 1; i <= 100; i++)
{
    int testThree = i % 3;
    int testFive = i % 5;
    string output = "";

    if (testThree == 0 && testFive == 0)
        output = "FizzBuzz";
    else if (testThree == 0)
        output = "Fizz";
    else if (testFive == 0)
        output = "Buzz";

    Console.WriteLine($"{i} - {output}");
}