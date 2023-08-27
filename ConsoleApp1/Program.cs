int scrore = 86;

if (scrore >= 88 && scrore <= 100)
{
    Console.WriteLine("Success-AA");
}
else if (scrore >= 81 && scrore < 88)
{
    Console.WriteLine("Success-BA");
}
else if (scrore >= 74 && scrore < 81)
{
    Console.WriteLine("Success-BB");
}
else if (scrore >= 67 && scrore < 74)
{
    Console.WriteLine("Success-CB");
}
else if (scrore >= 60 && scrore < 67)
{
    Console.WriteLine("Success-CC");
}
else if (scrore >= 0 && scrore < 60)
{
    Console.WriteLine("Fail - FF");
}
else
{
    Console.WriteLine("Invalid score");
}



string command = "stop";
switch (command)
{
    case "start":
        Console.WriteLine("Game is starting");
        break;
    case "stop":
        Console.WriteLine("Game stopped");
        break;
    case "wait":
        Console.WriteLine("Game paused");
        break;
    default:
        Console.WriteLine("Command not found");
        break;
}