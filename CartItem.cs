using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gamora
{
    public class CartItem
    {
        int id;
        string name;
        int price;
        int quantity;
        int itemtotal;
        int productid;

        public CartItem(int id, string name, int price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.itemtotal = price * quantity;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public int ItemTotal
        {
            get
            {
                return itemtotal;
            }
            set
            {
                itemtotal = value;
            }
        }
    }
}