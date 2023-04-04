

namespace HashLogin
{
    public partial class FormHome : Form
    {

        static Validation textValidation = new Validation();
        static HashInput hashInput = new HashInput();
        public FormHome()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click_1(object sender, EventArgs e)
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

            try
            {
                textValidation.checkStringLength(textUsername, "Username can not be empty.", 1)
                    .checkStringLength(textPassword, "Password can not be empty.", 1);
                //need a username matches one on file error check
                /*if (!hashInput.verifyPassword(textPassword))
                {
                    throw new InvalidOperationException(
                        "Password does not match one on file. Please re-enter your password and try again.");
                }*/

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error",//show user error message
        MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }


    }
}