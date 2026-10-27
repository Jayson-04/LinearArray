using System;
using System.Diagnostics;

bool LinearSearch(int[] array, int target)
{
    foreach (int element in array)
    {
        if (element == target)
            return true;
    }
    return false;
}

Random random = new Random();
int[] numbers = new int[10000];
for (int i = 0; i < numbers.Length; i++)
    numbers[i] = random.Next(1, 10001);

Array.Sort(numbers);

Console.Write("Welk getal zoek je (1 t/m 10000)? ");
int target = int.Parse(Console.ReadLine());

Stopwatch timer = Stopwatch.StartNew();
bool found = LinearSearch(numbers, target);
timer.Stop();

Console.WriteLine($"Target {target} gevonden: {found}");
Console.WriteLine($"Tijd: {timer.Elapsed.TotalMilliseconds} ms");