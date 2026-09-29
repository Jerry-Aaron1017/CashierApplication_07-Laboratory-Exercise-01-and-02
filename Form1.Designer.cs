namespace CashierApplication;

partial class frmPurchaseDiscountedItem
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.SuspendLayout();
        components = new System.ComponentModel.Container();
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(600, 500);
        this.Name = "frmPurchaseDiscountedItem";
        Text = "Purchased Discounted Items";
        CenterToScreen();

        this.itemLabel = new System.Windows.Forms.Label();
        this.itemLabel.Location = new System.Drawing.Point(32, 25);
        this.itemLabel.Name = "itemLabel";
        this.itemLabel.Size = new System.Drawing.Size(200, 23);
        this.itemLabel.Text = "Item:";
        this.itemLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.itemLabel.ForeColor = System.Drawing.Color.Black;
        this.itemLabel.TabIndex = 0;

        this.itemTextbox = new System.Windows.Forms.TextBox();
        this.itemTextbox.Location = new System.Drawing.Point(32, 48);
        this.itemTextbox.Size = new System.Drawing.Size(264, 24);
        this.itemTextbox.Name = "itemTextbox";
        this.itemTextbox.TabIndex = 0;
        this.itemTextbox.Text = "";

        this.priceLabel = new System.Windows.Forms.Label();
        this.priceLabel.Text = "Price:";
        this.priceLabel.Location = new System.Drawing.Point(304, 25);
        this.priceLabel.Name = "priceLabel";
        this.priceLabel.Size = new System.Drawing.Size(200, 23);
        this.priceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.priceLabel.TabIndex = 1;

        this.priceTextbox = new System.Windows.Forms.TextBox();
        this.priceTextbox.Location = new System.Drawing.Point(304, 48);
        this.priceTextbox.Size = new System.Drawing.Size(264, 23);

        this.button1 = new System.Windows.Forms.Button();
        this.button1.Text = "Compute";
        this.button1.Location = new System.Drawing.Point(196, 160);
        this.button1.Size = new System.Drawing.Size(200, 32);
        this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.button1.Click += new System.EventHandler(this.button1_Click);
        this.button1.BackColor = System.Drawing.Color.Goldenrod;

        this.discountLabel = new System.Windows.Forms.Label();
        this.discountLabel.Text = "Discount (%):";
        this.discountLabel.Location = new System.Drawing.Point(32, 89);
        this.discountLabel.Name = "discountLabel";
        this.discountLabel.Size = new System.Drawing.Size(200, 23);
        this.discountLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.discountLabel.TabIndex = 2;

        this.discountTextbox = new System.Windows.Forms.TextBox();
        this.discountTextbox.Location = new System.Drawing.Point(32, 112);
        this.discountTextbox.Size = new System.Drawing.Size(264, 23);
        this.discountTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

        this.quantityLabel = new System.Windows.Forms.Label();
        this.quantityLabel.Text = "Quantity:";
        this.quantityLabel.Location = new System.Drawing.Point(304, 89);
        this.quantityLabel.Name = "quantityLabel";
        this.quantityLabel.Size = new System.Drawing.Size(200, 23);
        this.quantityLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.quantityLabel.TabIndex = 3;

        this.quantityTextbox = new System.Windows.Forms.TextBox();
        this.quantityTextbox.Location = new System.Drawing.Point(304, 112);
        this.quantityTextbox.Size = new System.Drawing.Size(264, 23);

        this.totalAmountDiscountedLabel = new System.Windows.Forms.Label();
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.BackColor = System.Drawing.Color.BlanchedAlmond;
        this.totalAmountDiscountedLabel.Text = "Total Amount:";
        this.totalAmountDiscountedLabel.Location = new System.Drawing.Point(124, 208);
        this.totalAmountDiscountedLabel.Name = "totalAmountDiscountedLabel";
        this.totalAmountDiscountedLabel.Size = new System.Drawing.Size(300, 23);
        this.totalAmountDiscountedLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

        this.resultOfDiscount = new System.Windows.Forms.Label();
        this.resultOfDiscount.AutoSize = true;
        this.resultOfDiscount.Location = new System.Drawing.Point(250, 204);
        this.resultOfDiscount.Name = "resultOfDiscount";
        this.resultOfDiscount.Size = new System.Drawing.Size(50, 21);
        this.resultOfDiscount.TabIndex = 10;
        this.resultOfDiscount.Text = "";
        this.resultOfDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.resultOfDiscount.Font = new System.Drawing.Font("Segoe UI", 12F);

        this.paymentReceivedLabel = new System.Windows.Forms.Label();
        this.paymentReceivedLabel.Text = "Payment Received:";
        this.paymentReceivedLabel.Location = new System.Drawing.Point(88, 280);
        this.paymentReceivedLabel.Name = "paymentReceivedLabel";
        this.paymentReceivedLabel.Size = new System.Drawing.Size(162, 23);
        this.paymentReceivedLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

        this.paymentReceivedTextBox = new System.Windows.Forms.TextBox();
        this.paymentReceivedTextBox.Location = new System.Drawing.Point(250, 278);
        this.paymentReceivedTextBox.Size = new System.Drawing.Size(264, 23);
        this.paymentReceivedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

        this.changeResultLabel = new System.Windows.Forms.Label();
        this.changeResultLabel.AutoSize = true;
        this.changeResultLabel.Location = new System.Drawing.Point(268, 371);
        this.changeResultLabel.Name = "changeResultLabel";
        this.changeResultLabel.Size = new System.Drawing.Size(50, 21);
        this.changeResultLabel.TabIndex = 10;
        this.changeResultLabel.Text = "";
        this.changeResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.changeResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F);

        this.changeLabel = new System.Windows.Forms.Label();
        this.changeLabel.Text = "Change:";
        this.changeLabel.Location = new System.Drawing.Point(188, 373);
        this.changeLabel.Name = "changeLabel";
        this.changeLabel.Size = new System.Drawing.Size(87, 23);
        this.changeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

        this.submit = new System.Windows.Forms.Button();
        this.submit.Text = "Submit";
        this.submit.Location = new System.Drawing.Point(196, 321);
        this.submit.Size = new System.Drawing.Size(200, 32);
        this.submit.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.submit.Click += new System.EventHandler(this.submit_Click);
        this.submit.BackColor = System.Drawing.Color.Goldenrod;

        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
        this.toolStripComboBox1.Name = "toolStripComboBox1";
        this.toolStripComboBox1.Text = "File";
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripComboBox1 });
        this.menuStrip1.Name = "menuStrip1";
        string[] mnenuOpts = { "Logout", "Exit Application" };
        this.toolStripComboBox1.Items.AddRange(mnenuOpts);
        this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);

        this.menuStrip1.Location = new System.Drawing.Point(0, 2);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.TabIndex = 16;


        this.Controls.Add(this.menuStrip1);
        this.Controls.Add(this.resultOfDiscount);
        this.Controls.Add(this.itemLabel);
        this.Controls.Add(this.itemTextbox);
        this.Controls.Add(this.priceLabel);
        this.Controls.Add(this.priceTextbox);
        this.Controls.Add(this.discountLabel);
        this.Controls.Add(this.discountTextbox);
        this.Controls.Add(this.quantityLabel);
        this.Controls.Add(this.quantityTextbox);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.totalAmountDiscountedLabel);
        this.Controls.Add(this.paymentReceivedLabel);
        this.Controls.Add(this.paymentReceivedTextBox);
        this.Controls.Add(this.changeResultLabel);
        this.Controls.Add(this.changeLabel);
        this.Controls.Add(this.submit);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label itemLabel;
    private System.Windows.Forms.TextBox itemTextbox;
    private System.Windows.Forms.Label priceLabel;
    private System.Windows.Forms.TextBox priceTextbox;
    private System.Windows.Forms.Label discountLabel;
    private System.Windows.Forms.TextBox discountTextbox;
    private System.Windows.Forms.Label quantityLabel;
    private System.Windows.Forms.TextBox quantityTextbox;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label totalAmountDiscountedLabel;
    #endregion

    private System.Windows.Forms.Label resultOfDiscount;
    private System.Windows.Forms.Label paymentReceivedLabel;
    private System.Windows.Forms.TextBox paymentReceivedTextBox;
    private System.Windows.Forms.Label changeResultLabel;
    private System.Windows.Forms.Label changeLabel;
    private System.Windows.Forms.Button submit;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
}
