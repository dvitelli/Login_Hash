using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextValidation;

namespace HashLogin
{
    public partial class formRegister : Form
    {
        static Validation textValidation = new Validation();
        public formRegister()
        {
            InitializeComponent();
        }

        private void buttonRegisterAccount_Click(object sender, EventArgs e)
        {
            ValidationCheckRegister(textRegisterUsername, textRegisterPassword, textRegisterPasswordReenter);//sends entered information through validation
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidationCheckRegister(TextBox textUsername, TextBox textPassword, TextBox textRenterPassword)
        {

            System.Diagnostics.Debug.WriteLine(textUsername.Text);
            System.Diagnostics.Debug.WriteLine(textPassword.Text);
            System.Diagnostics.Debug.WriteLine(textRenterPassword.Text);


            if (textValidation.checkEmptyUsername(textUsername)) // check if username is empty
                if (textValidation.checkEmptyPassword(textPassword))// check if password is empty
                    if (textValidation.checkEmptyPasswordReenter(textRenterPassword))// check if password reentry is empty
                        if (textValidation.checkUsernameCharacters(textUsername))// check if username starts with a letter and then contains only alphanumeric characters
                            if (textValidation.checkPasswordCharacters(textPassword))
                                if (textValidation.checkPasswordReenterCharacters(textRenterPassword))
                                    if (textValidation.checkMatchingPasswords(textPassword, textRenterPassword)) ;//checks if passwords match

        }
    }
}
