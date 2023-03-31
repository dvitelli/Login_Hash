using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HashLogin
{
    public class Validation
    {
        public Validation checkStringLength(TextBox text, string errorMessage = "Invalid string length.", int min = 0, int max = int.MaxValue)
        {
            int len = text.TextLength;
            //System.Diagnostics.Debug.WriteLine("Username :" + textUsername.Text);
            //check is username has nothing in it
            if (len < min || len > max)     
            {
                //error message for not having any text
                throw new Exception(errorMessage);
            }

            return this;
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
            string regexUsernamePattern = "[a-zA-Z][a-zA-Z0-9].{5,}";
            Regex regex = new Regex(regexUsernamePattern);

            if (!regex.IsMatch(textUsername.Text))
            {
                System.Diagnostics.Debug.WriteLine("Getting here");
                MessageBox.Show("Your username must start with a letter and then contain only alphanumeric characters of length at least 5.", "Incorrect Username",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
            
}

    
}
