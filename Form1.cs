using System;
using DiscountedItem = ItemNamespace.DiscountedItem;

namespace CashierApplication;

public partial class frmPurchaseDiscountedItem : Form
{
    public frmPurchaseDiscountedItem()
    {
        InitializeComponent();
    }

    private void ClearFields(object sender, EventArgs e)
    {
        itemTextbox.Text = "";
        priceTextbox.Text = "";
        quantityTextbox.Text = "";
        resultOfDiscount.Text = "";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string itemName = itemTextbox.Text;
        double itemPrice = priceTextbox.Text != "" ? Convert.ToDouble(priceTextbox.Text) : 0.0;
        int itemQuantity = quantityTextbox.Text != "" ? Convert.ToInt32(quantityTextbox.Text) : 1;
        double discountPercentage = discountTextbox.Text != "" ? Convert.ToDouble(discountTextbox.Text) : 0.0;

        DiscountedItem discountedItem = new DiscountedItem(itemName, itemPrice, itemQuantity, discountPercentage);
        discountedItem.getTotalPrice();
        resultOfDiscount.Text = $"{discountedItem.getTotalPrice():C}";
    }

    private void submit_Click(object sender, EventArgs e)
    {
        string itemName = itemTextbox.Text;
        double itemPrice = priceTextbox.Text != "" ? Convert.ToDouble(priceTextbox.Text) : 0.0;
        int itemQuantity = quantityTextbox.Text != "" ? Convert.ToInt32(quantityTextbox.Text) : 1;
        double discountPercentage = discountTextbox.Text != "" ? Convert.ToDouble(discountTextbox.Text) : 0.0;

        DiscountedItem discountedItem = new DiscountedItem(itemName, itemPrice, itemQuantity, discountPercentage);
        discountedItem.getTotalPrice();

        double paymentReceived = paymentReceivedTextBox.Text != "" ? Convert.ToDouble(paymentReceivedTextBox.Text) : 0.0;
        discountedItem.setPayment(paymentReceived);

        changeResultLabel.Text = $"{discountedItem.getChange():C}";
    }

    private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedOption = toolStripComboBox1.SelectedItem?.ToString() ?? "File";

        if (selectedOption == "Logout")
        {
            frmLoginAccount frmLoginAccount = new frmLoginAccount();
            this.Hide();
            frmLoginAccount.Show();
        }
        else if (selectedOption == "Exit Application")
        {
            this.Hide();
            MessageBox.Show("Application Closed.");
            Application.Exit();
        }
    }


}
