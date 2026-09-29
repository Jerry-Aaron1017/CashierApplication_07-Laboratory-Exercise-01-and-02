using System.Runtime.InteropServices;

namespace ItemNamespace;

abstract class Item
{
    protected string itemName;
    protected double itemPrice;
    protected int itemQuantity;
    private double totalPrice;

    public Item(string name, double price, int quantity)
    {
        itemName = name;
        itemPrice = price;
        itemQuantity = quantity;
        totalPrice = itemPrice * itemQuantity;
    }
    public abstract double getTotalPrice();

    public abstract void setPayment(double amount);

}