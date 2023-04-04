using System;

namespace Library
{
    public class Library
    {
        private List<ICheckoutable> items;

        public Library()
        {
            items = new List<ICheckoutable>();
        }

        public void AddItem(ICheckoutable item)
        {
            items.Add(item);
        }

        public void CheckoutItem(ICheckoutable item)
        {
            item.Checkout();
        }

        public void ReturnItem(ICheckoutable item)
        {
            item.Return();
        }
    }
}