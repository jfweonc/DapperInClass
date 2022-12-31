using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperInClass
{
    public class DapperProductRepository: IProductRepository
    {        
        private readonly IDbConnection _connection;

        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM products;");
        }
        public void CreateProduct(string newProduct,double price, int categoryID)
        {
            _connection.Execute("INSERT INTO products (Name) VALUES (@productName);",
        new { productName = newProduct });
        }
    }
}
    