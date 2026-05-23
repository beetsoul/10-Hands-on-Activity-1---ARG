using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {

        private DiscountedItem discountedItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            string itemName = itemTextBox.Text;
            double price = Convert.ToDouble(priceTextBox.Text);
            double discount = Convert.ToDouble(discountTextBox.Text);
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            discountedItem = new DiscountedItem(itemName, price, quantity, discount);

            double totalAmount = discountedItem.getTotalPrice();

            totalLabel.Text = "Total Amount: " + totalAmount.ToString("0.00");
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(receivedTextBox.Text);

            discountedItem.setPayment(payment);

            changeLabel.Text = "Change: " + discountedItem.getChange().ToString("0.00");
        }
    }
}
