using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using FoodAppModels.Models;
using Dapper;


namespace FoodAppRepository.ProductRepository
{
    public class ProductRepository
    {
        private readonly MySqlConnection _conn;

        private string connectionString = "Server=127.0.0.1;Database=foodapp;Uid=root;Pwd=root;";

        public ProductRepository()
        {
            _conn = new MySqlConnection(connectionString);
        }
        public IEnumerable<Product> GetProduct()
        {
            var sql = "SELECT * FROM foodapp.product;";
            var result = this._conn.Query<Product>(sql);
            return result;
        }
    }
    
}
