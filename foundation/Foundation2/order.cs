using System;
using System.Collections.Generic;

namespace OrderingSystem
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var product in _products)
            {
                totalCost += product.GetTotalCost();
            }

            // Add shipping cost based on the customer's location
            totalCost += _customer.LivesInUSA() ? 5 : 35;
            return totalCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (var product in _products)
            {
                packingLabel += $"{product.GetPackingLabel()}\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        }
    }
}
