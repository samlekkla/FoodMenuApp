using System.Text.Json;

namespace GrupparbeteFoodapplication.Classes
{
    public class AdminLogin
    {

        // Metod för att representera administratörsuppgifter
        private class AdminCredentials
        {
            public string? username { get; set; }
            public string? password { get; set; }
        }
        private class AdminFile
        {
            public List<AdminCredentials> Admins { get; set; } = new List<AdminCredentials>();

        }

        Felhantering loginFelhantering; // Felhantering-instans
        string errorLogFilePath = @"C:\Users\Admin\Desktop\Error.txt"; // Error-logg-filväg
        string adminLogFilePath = @"C:\Users\Admin\Desktop\Adminlog.json.txt"; // Admin-logg-filväg


        //Metod för Adminlogin med instans 
        public AdminLogin()
        {
            loginFelhantering = new Felhantering(errorLogFilePath);
        }
        private List<AdminCredentials> LoadAdminsFromFile()
        {
            try
            {
                string jsonContent = File.ReadAllText(adminLogFilePath); // Läser filen
                AdminFile adminData = JsonSerializer.Deserialize<AdminFile>(jsonContent) ?? new AdminFile(); // Deserialisera JSON 
                                                                                          // omvandla JSON-struktur från ett textformat till ett objekt som kan användas C#,
                return adminData?.Admins ?? new List<AdminCredentials>(); // Returnera admin-listan
                                                                          // ?? är ett sätt att enkelt hantera null-värden och tillhandahålla ett standardvärde om något är null.
                                                                          // Alternativet utan ?? innebär att du använder en if-else -sats för att göra kontrollen mer explicit/detaljerad.
            }
            catch (Exception ex)
            {
                loginFelhantering.LogError($"Fel vid läsning av adminfilen: {ex.Message}"); // Logga fel till errorlog
                return new List<AdminCredentials>();
            }

        }
        public string ValidateAdmin(string username, string password)
        {
            try
            {
                var admins = LoadAdminsFromFile(); // Ladda admins
                foreach (var admin in admins)
                {
                    if (admin.username == username && admin.password == password)
                    {
                        return "Inloggning lyckades!";
                    }
                }
                loginFelhantering.LogError($"Misslyckad inloggning för Admin: {username}");
                return "Fel användarnamn eller lösenord."; // Felmeddelande vid felaktig inloggning som loggas till errorlog
            }
            catch (Exception ex)
            {
                loginFelhantering.LogError($"Ett fel inträffade under valideringen: {ex.Message}");
                return "Ett oväntat fel inträffade. Försök igen senare.";
            }
        }



        // Hantering av inloggningsuppgifter för administratörer.
        // Validerar användarnamn och lösenord mot hårdkodade värden.
        //Loggar felmeddelanden med hjälp av Felhantering-klassen om något går fel under inloggningsprocessen.
        //Koden är användbar för applikationer som kräver inloggning av administratörer och som behöver spåra eventuella fel under denna process.

    }

}
