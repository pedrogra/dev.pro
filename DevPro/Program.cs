using DevPro.Code.Task1;
using DevPro.Code.Task2;
/*TASK 1*/
var logger = new Logger();
logger.log_message("application.log", "this is a test 1", LogsEnum.Info);
Thread.Sleep(10000);
logger.log_message("test.txt", "this is a test 3", LogsEnum.Error);
Thread.Sleep(10000);
logger.log_message("application.log", "this is a test 2", LogsEnum.Fatal);
/*TASK 2*/
var sorter = new Sorter();
List<Product> products =
[
    new Product()
    {
        Name = "Product A",
        Price = 100,
        Stock = 5
    },
    new Product()
    {
        Name = "Product B",
        Price = 200,
        Stock = 3
    },
    new Product()
    {
        Name = "Product C",
        Price = 5,
        Stock = 10
    }
];
sorter.sort_products(products, "name", false);
sorter.sort_products(products, "name", true);
sorter.sort_products(products, "price", false);
sorter.sort_products(products, "price", true);
sorter.sort_products(products, "stock", false);
sorter.sort_products(products, "stock", true);
sorter.sort_products(products, "brand", false);
sorter.sort_products(products, "brand", true);