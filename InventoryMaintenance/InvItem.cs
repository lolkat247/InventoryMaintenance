using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        private int itemNo;
        public int ItemNo
        {
            get { return itemNo; }
            set { itemNo = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string GetDisplayText()
        {
            string formattedItemNo = Convert.ToString(itemNo);
            while (formattedItemNo.Length < 7)
            {
                formattedItemNo = "0" + formattedItemNo;
            }

            return (
                formattedItemNo +
                "    " +
                description +
                " (" + string.Format("{0:C}", price) + ")"
                );
        }

        public InvItem()
        {
            itemNo = 0;
            description = "New Item";
            price = 0.0m;
        }

        public InvItem(int _itemNo, string _description, decimal _price)
        {
            itemNo = _itemNo;
            description = _description;
            price = _price;
        }
    }
}
