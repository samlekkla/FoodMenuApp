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

        private readonly FormSearch _formSearch;


        public FormLogin(FormSearch formSearch)
        {
            InitializeComponent();
            _formSearch = formSearch;
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
                MessageBox.Show("Felaktigt användarnamn eller lösenord.", "Felaktigt infomration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValidAdmin(string username, string password)
        {

            return username == "admin" && password == "password";
        }
    }
}
