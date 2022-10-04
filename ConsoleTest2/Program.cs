using Crud.Infrastructure.Model.Entities;
using Crud.Infrastructure.Model.ValueObjects;
using Crud.Infrastructure.Persistence;

//Создаем продукты
using (OrmContext db = new OrmContext())
{
    // создаем два объекта Products   
    Product product1 = new Product { Name = "Мобильный телефон" };
    Product product2 = new Product { Name = "Автомобиль" };
    Product product3 = new Product { Name = "Аккумулятор" };

    // добавляем их в бд
    db.Product.AddRange(product1, product2, product3);
    db.SaveChanges();
}

//Создаем корзину
using (OrmContext db = new OrmContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = db.Product.ToList();
    Console.WriteLine("Users list:");
    foreach (Product u in users)
    {
        Console.WriteLine($"{u.Name}");
    }
}

using (OrmContext db = new OrmContext())
{
    // создаем два объекта Products   
    Buyer product1 = new Buyer { Id = 2 };
    Buyer product2 = new Buyer { Id = 1 };
    Buyer product3 = new Buyer { Id = 3 };

    // добавляем их в бд
    db.Buyer.AddRange(product1, product2, product3);
    db.SaveChanges();
}


//using (OrmContext db = new OrmContext())
//{
//    // получаем объекты из бд и выводим на консоль
//    var users = db.Product.ToList();
//    Console.WriteLine("Users list:");
//    foreach (Product u in users)
//    {
//        Console.WriteLine($"{u.Name}");
//    }
//}

