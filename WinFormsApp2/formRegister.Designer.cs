namespace HashLogin
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRegisterUsername = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textRegisterPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelReenterPassword = new System.Windows.Forms.Label();
            this.textRegisterPasswordReenter = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRegisterAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "USERNAME";
            // 
            // textRegisterUsername
            // 
            this.textRegisterUsername.Location = new System.Drawing.Point(58, 93);
            this.textRegisterUsername.Name = "textRegisterUsername";
            this.textRegisterUsername.Size = new System.Drawing.Size(236, 23);
            this.textRegisterUsername.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(129, 154);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 15);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "PASSWORD";
            // 
            // textRegisterPassword
            // 
            this.textRegisterPassword.Location = new System.Drawing.Point(58, 182);
            this.textRegisterPassword.Name = "textRegisterPassword";
            this.textRegisterPassword.Size = new System.Drawing.Size(236, 23);
            this.textRegisterPassword.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // labelReenterPassword
            // 
            this.labelReenterPassword.AutoSize = true;
            this.labelReenterPassword.Location = new System.Drawing.Point(104, 249);
            this.labelReenterPassword.Name = "labelReenterPassword";
            this.labelReenterPassword.Size = new System.Drawing.Size(123, 15);
            this.labelReenterPassword.TabIndex = 16;
            this.labelReenterPassword.Text = "RE-ENTER PASSWORD";
            // 
            // textRegisterPasswordReenter
            // 
            this.textRegisterPasswordReenter.Location = new System.Drawing.Point(58, 279);
            this.textRegisterPasswordReenter.Name = "textRegisterPasswordReenter";
            this.textRegisterPasswordReenter.Size = new System.Drawing.Size(236, 23);
            this.textRegisterPasswordReenter.TabIndex = 15;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(120, 382);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(77, 28);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRegisterAccount
            // 
            this.buttonRegisterAccount.Location = new System.Drawing.Point(58, 348);
            this.buttonRegisterAccount.Name = "buttonRegisterAccount";
            this.buttonRegisterAccount.Size = new System.Drawing.Size(219, 28);
            this.buttonRegisterAccount.TabIndex = 18;
            this.buttonRegisterAccount.Text = "Register Account";
            this.buttonRegisterAccount.UseVisualStyleBackColor = true;
            this.buttonRegisterAccount.Click += new System.EventHandler(this.buttonRegisterAccount_Click);
            // 
            // formRegister
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 478);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegisterAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelReenterPassword);
            this.Controls.Add(this.textRegisterPasswordReenter);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textRegisterPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRegisterUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textRegisterUsername;
        private PictureBox pictureBox3;
        private Label labelPassword;
        private TextBox textRegisterPassword;
        private PictureBox pictureBox1;
        private Label labelReenterPassword;
        private TextBox textRegisterPasswordReenter;
        private Button buttonExit;
        private Button buttonRegisterAccount;
    }
}