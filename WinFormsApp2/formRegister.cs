using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HashLogin
{
    public partial class FormRegister : Form
    {
        static Validation textValidation = new Validation();
        public FormRegister()
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

            /*System.Diagnostics.Debug.WriteLine(textUsername.Text);
            System.Diagnostics.Debug.WriteLine(textPassword.Text);
            System.Diagnostics.Debug.WriteLine(textRenterPassword.Text);*/

            try
            {
                textValidation.checkStringLength(textUsername, "Username can not be empty.", 1)// check if username is empty
                    .checkStringLength(textPassword, "Password can not be empty.", 1)// check if password is empty
                    .checkStringLength(textRenterPassword, "Password can not be empty.", 1);// check if password reentry is empty
                            if (textValidation.checkUsernameCharacters(textUsername))// check if username starts with a letter and then contains only alphanumeric characters
                                if (textValidation.checkPasswordCharacters(textPassword))
                                    if (textValidation.checkPasswordReenterCharacters(textRenterPassword))
                                        if (textValidation.checkMatchingPasswords(textPassword, textRenterPassword));//checks if passwords match
            }
            catch(Exception e) 
            {
                  
                        MessageBox.Show(e.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                      
                  
            }

        }
    }
}
