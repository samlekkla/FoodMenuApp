using GrupparbeteFoodapplication.Classes;

namespace GrupparbeteFoodapplication
{
    public partial class FormAdmin : Form
    {
        private readonly FormStart _formStart;
        public FormAdmin(FormStart formStart)
        {

             InitializeComponent();
            _formStart = formStart;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Inloggningsknapp med textbox för användarnamn och lösenord
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Skapa en instans av Adminlogin-klassen
            AdminLogin adminLogin = new AdminLogin();

            // Validera inloggning med användarnamn och lösenord
            string loginResult = adminLogin.ValidateAdmin(username, password);

            // Visa resultatet för användaren med en MessageBox
            MessageBox.Show(loginResult, "Inloggningsstatus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (loginResult == "Inloggningen lyckades!")
            {
                this.DialogResult = DialogResult.OK; // Indikera lyckad inloggning
                this.Close();
            }
        }
    }

}
