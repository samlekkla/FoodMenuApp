public static class Logger
{
    private static string logFilePath = @"C:\Users\harit\Source\Repos\GrupparbeteFoodapplicationlocalcopy\log.txt";

    public static void Log(string message)
    {
        // Kontrollera om loggmappen finns, annars skapa den
        string logDirectory = Path.GetDirectoryName(logFilePath);
        if (!Directory.Exists(logDirectory))
        {
            Directory.CreateDirectory(logDirectory);
        }

        // Logga meddelandet till filen
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    public static void LogError(string message)
    {
        Log($"Error: {message}");
    }
}
