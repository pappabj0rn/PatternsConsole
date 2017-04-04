using System.Collections.Generic;

namespace PatternsConsole.Creational.FactoryMethod
{
    public abstract class Creator
    {
        private readonly List<Product> _products;

        protected Creator()
        {
            _products = new List<Product>();
        }

        protected abstract Product InstanciateProduct(string productName);

        public Product CreateProduct(string productName = null)
        {
            var product = InstanciateProduct(productName);
            _products.Add(product);
            return product;
        }

        public void DeleteProduct(Product p)
        {
            _products.Remove(p);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}