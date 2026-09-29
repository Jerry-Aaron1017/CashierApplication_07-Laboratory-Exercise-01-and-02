using System.Windows.Forms.Design;
using Cashier = UserAccountNamespace.Cashier;
using UserAccount = UserAccountNamespace.UserAccount;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void clearFields()
        {
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";

        }

        private void submitButtonClick(Object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            Cashier cashier = new Cashier("Jerry Aaron P. Saquibal", "Finance", "Jeron17", "286117");

            if (cashier.validateLogin(userName, password))
            {
                MessageBox.Show($"Welcome {cashier.getFullName} of {cashier.getDepartment()}");
                this.Hide();
                frmPurchaseDiscountedItem frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem();
                frmPurchaseDiscountedItem.Show();
            }
            else
            {
                MessageBox.Show($"Wrong username or password.");
                clearFields();
            }
        }
    }
}
