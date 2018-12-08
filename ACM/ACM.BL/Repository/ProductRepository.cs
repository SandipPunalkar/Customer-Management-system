using System;

namespace ACM.BL.Repository
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            Object myObject = new Object();

            Console.WriteLine("Object: " + myObject.ToString());
            Console.WriteLine("Product: " + product.ToString());

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    // Call an Insert Stored Procedure

                }
                else
                {
                    // Call an Update Stored Procedure
                }
            }
            return success;
        }
    }
}
