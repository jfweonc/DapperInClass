// See https://aka.ms/new-console-template for more information

using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using DapperInClass;
using Dapper;

Console.WriteLine("Hello, World!");

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

conn.Execute("INSERT INTO DEPARTMENTS (Name) VALUES ('DellLaptop');"); 
/*
var repo = new DapperDepartmentRepository(conn);

Console.WriteLine("Type a new Department name"); 

var newDepartment = Console.ReadLine();

repo.InsertDepartment(newDepartment);

var departments = repo.GetAllDepartments();

foreach(var dept in departments)
{
    Console.WriteLine(dept.Name);
}
Console.WriteLine("Type a new Product name, price, and category ID:");

var repo1 = new DapperProductRepository(conn);

var newProduct = Console.ReadLine();

repo1.CreateProduct(newProduct,0,0);

repo1.GetAllProducts(); 
*/