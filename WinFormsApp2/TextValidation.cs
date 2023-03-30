using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TextValidation
{
    public class Validation
    {
        public bool checkEmptyUsername(TextBox textUsername)
        {
            System.Diagnostics.Debug.WriteLine("Username :" + textUsername.Text);
            //check is username has nothing in it
            if (textUsername.Text.Length.Equals(0))
            {
                
                //error message for not having any text
                MessageBox.Show("The Username field is empty. Please enter a Username", "Empty Username",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
        
        public bool checkEmptyPassword(TextBox textPassword)
        {
            //check is password has nothing in it
            if (textPassword.Text.Length.Equals(0))
            {
                //System.Diagnostics.Debug.WriteLine("Password :" + textPassword.Text);
                //error message for not having any text
                MessageBox.Show("The Password field is empty. Please enter a Password", "Empty Password",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool checkEmptyPasswordReenter(TextBox textPassword)
        {
            //check is password has nothing in it
            if (textPassword.Text.Length.Equals(0))
            {
                //error message for not having any text
                MessageBox.Show("The Re-enter Password field is empty. Please enter a Password", "Empty Password",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool checkPasswordReenterCharacters(TextBox textRenterPassword)
        {
            string regexPasswordPattern = "^(?=.*?[A-Za-z])(?=.*?[\\d])(?=.*?[#?!@$%^&*-]).{8,}$";
            Regex regex = new Regex(regexPasswordPattern);

            if (!regex.IsMatch(textRenterPassword.Text))
            {
                //System.Diagnostics.Debug.WriteLine("Getting here");
                MessageBox.Show("Your password must contain a minimum of eight characters, at least one letter, one number and one special character.", 
                    "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool checkPasswordCharacters(TextBox textPassword)
        {
            string regexPasswordPattern = "^(?=.*?[A-Za-z])(?=.*?[\\d])(?=.*?[#?!@$%^&*-]).{8,}$";
            Regex regex = new Regex(regexPasswordPattern);

            if (!regex.IsMatch(textPassword.Text))
            {
                //System.Diagnostics.Debug.WriteLine("Getting here");
                MessageBox.Show("Your password must contain a minimum of eight characters, at least one letter, one number and one special character.", 
                    "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool checkMatchingPasswords(TextBox textPassword, TextBox textPasswordReentry)
        {

            //System.Diagnostics.Debug.WriteLine("Password 1: " + textPassword);
            //System.Diagnostics.Debug.WriteLine("Password 2: " + textPasswordReentry);

            if (textPassword.Text != textPasswordReentry.Text)
            {
                MessageBox.Show("Both passwords do not match. Please enter matching passwords.", "Password Mismatch",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool checkUsernameCharacters(TextBox textUsername)
        {
            string regexUsernamePattern = "[a-zA-Z][a-zA-Z0-9]";
            Regex regex = new Regex(regexUsernamePattern);

            if (!regex.IsMatch(textUsername.Text))
            {
                System.Diagnostics.Debug.WriteLine("Getting here");
                MessageBox.Show("Your username must include characters : A-Z, 0-9", "Incorrect Username",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
            
}

    
}
