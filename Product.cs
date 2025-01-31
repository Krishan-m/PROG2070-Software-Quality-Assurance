using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group13_KrishanSingh_GouriSankar_Pradeep_Assignment2
{
    public class Product
    {
        private int prodId;
        private string prodName;
        private double itemPrice;
        private int stockAmount;

        public int ProdId { get => prodId; set => prodId = value; }
        public string ProdName { get => prodName; set => prodName = value; }
        public double ItemPrice { get => itemPrice; set => itemPrice = value; }
        public int StockAmount { get => stockAmount; set => stockAmount = value; }

        public Product(int prodId, string prodName, double itemPrice, int stockAmount)
        {
            //if (prodId == 0) throw new Exception("Product id can not be 0");
            //if (prodName == "") throw new Exception("Product name can not be null");
            //if (itemPrice <= 0) throw new Exception("Item price has to realistic");
            //if (stockAmount == 0) throw new Exception("Atleast have some stock");

            ProdId = prodId;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public void IncreaseStock(int value)
        {
            stockAmount += value;
        }

        public void DecreaseStock(int value)
        {
            stockAmount -= value;
        }
    }
}
