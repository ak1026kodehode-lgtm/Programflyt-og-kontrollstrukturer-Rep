string transmission = "AB#CD##EF";
int interferenceCount = 0;

char target = '#';

// TODO: Bruk foreach over transmission.

foreach (char c in transmission)
{
    if (c == target)
    {
        interferenceCount++;
    }
}

Console.WriteLine($"Interference markers: {interferenceCount}");
