

namespace HashLogin
{
    public partial class FormHome : Form
    {
        static DatabaseConnection conn = new DatabaseConnection();
        static Validation textValidation = new Validation();
        static HashInput hashInput = new HashInput();
        public FormHome()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                //check if forms are empty
                ValidationCheck(textUsername, textPassword);
                System.Diagnostics.Debug.WriteLine("Successfully logged in.");

            }
            catch (Exception ex)
            {

            }

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
                conn.compareUsernameAndPass(textUsername, textPassword, "Username or password does not match.");
                

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error",//show user error message
        MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }


    }
}