using System;
class DAL : IDAL
{
    public List<Product> GetProducts()
    {
        return new List<Product>()
        {
            new Product{Id = 1, Name = "Pencil 1", Price = 100, Stock = 200},
            new Product{Id = 2, Name = "Pencil 2", Price = 200, Stock = 200},
            new Product{Id = 3, Name = "Pencil 3", Price = 300, Stock = 200},
            new Product{Id = 4, Name = "Pencil 4", Price = 400, Stock = 200},
        };
    }
}