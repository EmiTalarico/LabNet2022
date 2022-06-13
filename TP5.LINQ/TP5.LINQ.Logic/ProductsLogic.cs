using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.LINQ.Entities;

namespace TP5.LINQ.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public void Add(Products newObject)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Update(Products newObject)
        {
            throw new NotImplementedException();
        }

        public string FirstProduct()
        {
            var query = _context.Products.Take(1);
            var product = query.FirstOrDefault();

            return $"ID) {product.ProductID} - Name: '{product.ProductName}'\n";
        }
        public string ProductsByCategory()
        {
            var query = from product in _context.Products
                        join idCategory in _context.Categories
                        on product.CategoryID equals idCategory.CategoryID
                        group idCategory by idCategory.CategoryName into newGroup
                        select newGroup.Key;

            string categoryData = "";
            foreach (var category in query)
            {
                categoryData += $"Category: {category} - Products in this category: {category.Count()}\n";
            }
            return categoryData;
        }
        public string ProductOrderByStock()
        {
            var query = _context.Products.OrderByDescending(p => p.UnitsInStock);

            string productsData = "";
            foreach (var product in query)
            {
                productsData += $" ID){product.ProductID} - Product name: {product.ProductName} - " +
                    $"Unit Stock: {product.UnitsInStock}\n";
            }
            return productsData;
        }
        public string ProductOrderByName()
        {
            var query = _context.Products.OrderBy(p => p.ProductName);

            string productsData = "";
            foreach (var product in query)
            {
                productsData += $" ID){product.ProductID} - Product name: {product.ProductName} - " +
                    $"Unit price: ${product.UnitPrice}\n";
            }
            return productsData;
        }
        public string ProductByIdWhere(int id)
        {
            //var query = from product in _context.Products
            //            where product.ProductID == id
            //            select product;


            var query = _context.Products.Where(p => p.ProductID == id);
            var product = query.FirstOrDefault();
            string productData = "";

            if (product == null)
            {
                return productData += $"No existe ningún producto con el id: {id}\n";
            }
            else
            {

                productData += $" ID):{product.ProductID} - Product name: '{product.ProductName}' -" +
                    $" Stock:{product.UnitsInStock}\n";

                return productData;
            }
        }

        public string OutStock()
        {
            var query = from product in _context.Products
                        where product.UnitsInStock == 0 || product.UnitsInStock == null
                        select product;

            //var query = _context.Products.Where(p => p.UnitsInStock == 0 || p.UnitsInStock == null);

            string productData = "";
            foreach (var product in query)
            {
                productData += $" ID){product.ProductID} - Name: {product.ProductName} " +
                    $"- Unit Price: ${product.UnitPrice} - Unit Stock: {product.UnitsInStock}\n";
            }
            return productData;



        }

        public string StockAndUnitePrice()
        {
            var query = _context.Products.Where(p => p.UnitPrice >= 3 && p.UnitsInStock != 0 && p.UnitsInStock != null);

            //var query2 = from product in _context.Products
            //            where product.UnitsInStock != 0 && product.UnitsInStock != null && product.UnitPrice >= 3
            //            select product;

            string productData = "";
            foreach (var product in query)
            {
                productData += $" ID){product.ProductID} - Name: {product.ProductName} - Unit Price: ${product.UnitPrice} - " +
                    $"Stock: {product.UnitsInStock}\n";
            }
            return productData;
        }
    }
}
