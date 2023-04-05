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
        static HashInput hashInput = new HashInput();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegisterAccount_Click(object sender, EventArgs e)
        {
            try
            {
                ValidationCheckRegister(textRegisterUsername, textRegisterPassword, textRegisterPasswordReenter);//sends entered information through validation
                hashInput.hashInput(textRegisterUsername, textRegisterPassword, out byte[] salt);
                successfulRegister(textRegisterUsername, textRegisterPassword);
                this.Close();//close register tab when successful}
            }
            catch (Exception ex)
            {

            }
            

        }

        private void successfulRegister(TextBox textRegisterUsername, TextBox textRegisterPassword)
        {
            MessageBox.Show("Account successfully registerd.", "Account Registered",//alert user that registration was successful
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();//Close register tab
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
                textValidation.checkUsernameCharacters(textUsername, "Username must start with a letter and contain only aphanumeric characters. Usernames must be at least 5 characters long.");//Username must be alphanumeric values from 3-32 characters
                textValidation.checkPasswordCharacters(textPassword, "Your password must contain a minimum of eight characters, at least one letter, one number and one special character.")
                    .checkPasswordCharacters(textRenterPassword, "Your reentered password must contain a minimum of eight characters, at least one letter, one number and one special character.");
                textValidation.checkMatchingPasswords(textPassword, textRenterPassword, "Both passwords do not match. Please enter matching passwords.");//checks if passwords match
            }
            catch(Exception e) 
            {
                  
                        MessageBox.Show(e.Message, "Error",//show user error message
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
                      
                  
            }



        }
    }
}
