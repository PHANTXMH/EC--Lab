using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gamora
{
    public class Game
    {
        private int id;
        private string name;
        private string description;
        private string category;
        private string imageUrl;
        private int unitPrice;

        public Game(int id, string name, string description, string category, string imageUrl, int unitPrice)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.category = category;
            this.imageUrl = imageUrl;
            this.unitPrice = unitPrice;
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

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public string ImageUrl
        {
            get
            {
                return imageUrl;
            }
            set
            {
                imageUrl = value;
            }
        }

        public int Price
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }
    }
}