using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Group13_KrishanSingh_GouriSankar_Pradeep_Assignment2
{
    [TestFixture]
    public class ProductTest
    {
        // Tests for product id

        // Check product id for value 5
        [Test]
        public void Product_ID_5_5()
        {
            int expected = 5;

            // Arrange
            int prodId = 5;
            string prodName = "Assignment 2";
            double itemPrice = 23;
            int stockAmount = 4500;
            Product product = new Product(prodId, prodName, itemPrice, stockAmount);

            // Act
            int actual = product.ProdId;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        // Check product id for value 20000
        [Test]
        public void Product_ID_20000_20000()
        {
            int expected = 20000;

            // Arrange
            int prodId = 20000;
            string prodName = "Assignment 2";
            double itemPrice = 43;
            int stockAmount = 50000;
            Product product = new Product(prodId, prodName, itemPrice, stockAmount);

            // Act
            int actual = product.ProdId;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        // Check product id for value 50000
        [Test]
        public void Product_ID_50000_50000()
        {
            int expected = 50000;

            // Arrange
            int prodId = 50000;
            string prodName = "Assignment 2";
            double itemPrice = 3201;
            int stockAmount = 70040;
            Product product = new Product(prodId, prodName, itemPrice, stockAmount);

            // Act
            int actual = product.ProdId;

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        // Tests for product name

        // TODO
        // Product name not null
        // Do not test for failing results. Adhere to Boundary Value Analysis
        [Test]
        public void Product_Name_Not_Null() { }

        // Stock amount alteration

        // Increase stock amount by 5000
        [Test]
        public void Stock_2000Add5000_7000() {
            int expected = 7000;

            // Arrange
            int prodId = 5000;
            string prodName = "Assignment 2";
            double itemPrice = 3000;
            int stockAmount = 2000;

            Product product = new Product(prodId, prodName, itemPrice, stockAmount);
            product.IncreaseStock(5000);

            // Act
            int actual = product.StockAmount;
            Assert.That(expected, Is.EqualTo(actual));
        }

        // Decrease stock amount by 5000
        [Test]
        public void Stock_7000Minus5000_2000() {
            int expected = 2000;

            // Arrange
            int prodId = 5000;
            string prodName = "Assignment 2";
            double itemPrice = 3000;
            int stockAmount = 7000;

            Product product = new Product(prodId, prodName, itemPrice, stockAmount);
            product.DecreaseStock(5000);

            // Act
            int actual = product.StockAmount;
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
