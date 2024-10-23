using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupparbeteFoodapplication
{
    public partial class FormLogin : Form
    {

        private readonly FormStart _formStart;


        public FormLogin(FormStart formStart)
        {
            InitializeComponent();
            _formStart = formStart;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (IsValidAdmin(username, password))
            {
                Formcrud crudForm = new Formcrud();
                crudForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord.");
            }
        }

        private bool IsValidAdmin(string username, string password)
        {
            
            return username == "admin" && password == "password"; 
        }
    }
}
