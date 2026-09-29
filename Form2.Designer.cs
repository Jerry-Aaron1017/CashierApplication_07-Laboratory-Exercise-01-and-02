namespace CashierApplication
{
    partial class frmLoginAccount
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmLoginAccount
            // 
            this.components = new System.ComponentModel.Container();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(34, 29);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(38, 15);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name: ";
            this.userNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(34, 109);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(38, 15);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password: ";
            // 
            // textBox1
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(34, 47);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(350, 23);
            this.userNameTextBox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(34, 127);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(350, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(158, 177);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(102, 31);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButtonClick);
            this.submitButton.BackColor = System.Drawing.Color.Goldenrod;


            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            CenterToScreen();
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "frmLoginAccount";
            this.Text = "User Login";
            this.BackColor = System.Drawing.Color.BlanchedAlmond;




            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}
