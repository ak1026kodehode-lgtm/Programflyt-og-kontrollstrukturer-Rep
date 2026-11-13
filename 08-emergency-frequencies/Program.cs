string signal = "Yellow";
string output = "";

switch (signal)
{
    case "RED":
    case "CRIMSON":
    case "SCARLET":
        output = "Evacuate deck";
        break;
    case "Amber":
    case "Yellow":
        output = "Prepare Crew";
        break;
    case "GREEN":
        output = "No emergency";
        break;
    default:
        output = "Unknown signal";
        break;
}

Console.WriteLine(output);