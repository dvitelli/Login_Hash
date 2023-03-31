

namespace HashLogin
{
    public partial class FormHome : Form
    {

        static Validation textValidation = new Validation();
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //check if forms are empty
            ValidationCheck(textUsername, textPassword);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //open a new register account window
            FormRegister registerAccount = new FormRegister();
            registerAccount.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //exits program
            this.Close();
        }

        private void ValidationCheck(TextBox textUsername, TextBox textPassword)
        {

            //if (textValidation.checkEmptyUsername(textUsername))
               // if (textValidation.checkEmptyUsername(textUsername))
                    //if (textValidation.checkEmptyPassword(textPassword))
                     //   if (textValidation.checkUsernameCharacters(textUsername)) ;

        }


    }
}