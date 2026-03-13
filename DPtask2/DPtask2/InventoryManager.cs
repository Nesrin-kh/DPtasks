using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    internal class InventoryManager
    {

        public void CheckProduct()
        {
            Console.WriteLine("Product available");
        }
    }

    class PaymentManager
    {
        public void Pay()
        {
            Console.WriteLine("Payment processed");
        }
    }

    class ShippingManager
    {
        public void Ship()
        {
            Console.WriteLine("Shipping started");
        }
    }

    class StoreFacade
    {
        private InventoryManager inventory = new InventoryManager();
        private PaymentManager payment = new PaymentManager();
        private ShippingManager shipping = new ShippingManager();

        public void PlaceOrder()
        {
            inventory.CheckProduct();
            payment.Pay();
            shipping.Ship();
        }
    }
}