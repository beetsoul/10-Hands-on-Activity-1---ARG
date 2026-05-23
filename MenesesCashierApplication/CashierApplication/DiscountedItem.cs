using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount, discounted_price, payment_amount, change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.item_discount = discount * 0.01;
        }

        public override double getTotalPrice()
        {
            discounted_price = item_price - (item_price * item_discount);
            total_price = discounted_price * item_quantity;
            return total_price;
        }

        public void setPayment(double amount)
        {
            this.payment_amount = amount;
            change = payment_amount - total_price;
        }

        public double getChange()
        {
            return change;
        }
    }
}