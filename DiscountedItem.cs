using Item = ItemNamespace.Item;
namespace ItemNamespace;

class DiscountedItem : Item
{
    private double itemDiscount;
    private double discountedPrice;
    private double paymentAmount;
    private double change;

    public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
    {
        itemDiscount = discount;
        getTotalPrice();
    }

    public override double getTotalPrice()
    {
        this.discountedPrice = (itemPrice * itemQuantity) * (itemDiscount * 0.01);
        this.discountedPrice = (itemPrice * itemQuantity) - this.discountedPrice;
        return discountedPrice;
    }

    public override void setPayment(double amount)
    {
        paymentAmount = amount;
    }

    public double getChange()
    {
        double totalPrice = discountedPrice;
        change = paymentAmount - totalPrice;
        return change;
    }
}
