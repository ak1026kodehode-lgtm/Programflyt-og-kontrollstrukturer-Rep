bool hasSuit = true;
int oxygenPercent = 44;
int pressure = 101;
bool alarmActive = false;

bool canOpenAirlock = false;

if (hasSuit && oxygenPercent >= 30 && pressure > 90 && pressure < 110 && !alarmActive)
    canOpenAirlock = true;

if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
