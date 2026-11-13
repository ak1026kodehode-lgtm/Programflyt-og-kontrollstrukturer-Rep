int charge = 100;
int drainPerCycle = 5;

// TODO: Bruk while til å simulere utladingen.

while (charge > 0)
{
    Console.WriteLine($"Charge: {charge}");
    charge -= drainPerCycle;
}

Console.WriteLine("Power cell offline.");
