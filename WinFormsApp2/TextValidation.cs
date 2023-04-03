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
            //check if username has nothing in it
            if (len < min || len > max)     
            {
                //error message for not having any text
                throw new Exception(errorMessage);
            }

            return this;
        }

        public Validation checkPasswordCharacters(TextBox textPassword, string errorMessage = "Invalid password.")
        {
            string regexPasswordPattern = "^(?=.*?[A-Za-z])(?=.*?[\\d])(?=.*?[#?!@$%^&*-]).{8,}$";//check to make sure password 
            Regex regex = new Regex(regexPasswordPattern);

            if (!regex.IsMatch(textPassword.Text))
            {
                //System.Diagnostics.Debug.WriteLine("Getting here");
                throw new Exception(errorMessage);
            }

            return this;
        }

        public Validation checkMatchingPasswords(TextBox textPassword, TextBox textPasswordReentry, string errorMessage = "Passwords dont match.")
        {

            if (textPassword.Text != textPasswordReentry.Text)//check if passwords match
            {
                throw new Exception(errorMessage);
            }

            return this;
        }

        public Validation checkUsernameCharacters(TextBox textUsername, string errorMessage = "Invalid username.")
        {
            string regexUsernamePattern = "[A-Za-z0-9]{3,32}";//username must be alphanumeric characters 3-32
            Regex regex = new Regex(regexUsernamePattern);

            if (!regex.IsMatch(textUsername.Text))
            { 
                throw new Exception(errorMessage);
            }

            return this;
        }
            
}

    
}
