namespace GrupparbeteFoodapplication.Classes
{
    internal class Felhantering
    {
        string errorLogFilePath;
        public Felhantering(string errorLogfilePath)
        {
            errorLogFilePath = errorLogfilePath;
        }

        // Metod för att logga fel till filen
        public void LogError(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}";
            try
            {
                File.AppendAllText(errorLogFilePath, logMessage + "\n"); //  loggar fel till errorlog
            }
            catch (Exception) // Fånga fel som uppstår under loggning
            {
                // Om man vill kan man lägga till en seperat filväg som fångar upp felen och loggar i en ytterligare 
                //databas eller så kan man skriva ut ett till meddelande (messagebox) om felmeddelande 
            }

        }
    }
}
