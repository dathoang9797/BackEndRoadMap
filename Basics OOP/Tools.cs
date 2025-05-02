namespace Basics_OOP;

public static class Tools
{
    public static void ColorWriteLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}