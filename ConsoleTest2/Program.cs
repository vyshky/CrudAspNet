using Crud.Infrastructure.Model.Entities;
using Crud.Infrastructure.Model.ValueObjects;
using Crud.Infrastructure.Persistence;

// Добавить продукты
//using (OrmContext db = new OrmContext())
//{
//    //создаем Products
//    List<Product> product = new List<Product>()
//            {
//                new() { Name = "Монитор" },
//                new() { Name = "Мышка" },
//                new() { Name = "Автомобиль" },
//                new() { Name = "Клавиатура" },
//                new() { Name = "Ананас" },
//                new() { Name = "Банан" },
//            };
//    // добавляем их в бд
//    db.Product.AddRange(product);
//    db.SaveChanges();
//}


// Добавить покупателя
using (OrmContext db = new OrmContext())
{    
    Buyer buyer = new Buyer
    {
        Id = Random.Shared.Next(),
        Address = new Address() { City = "Moscow", ZipCode = 666666 },
        Basket = new Basket()
        {
            Id = Random.Shared.Next(),
            ProductsId = new List<long>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
            }
        }
    };
    db.Buyer.AddRange(buyer);
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

