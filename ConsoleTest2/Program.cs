using Crud.Infrastructure.Model.Entities;
using Crud.Infrastructure.Model.ValueObjects;
using Crud.Infrastructure.Persistence;


using (OrmContext db = new OrmContext())
{
    // создаем два объекта Products   
    Buyer product = new Buyer
    {
        Id = Random.Shared.Next(),
        Address = new Address() { City = "Moscow", ZipCode = 666666 },
        Basket = new Basket()
        {
            Id = Random.Shared.Next(),
            Products = new List<Product>()
            {
                new() { Name = "Мобильный телефон" }
            }
        }
    };  

    // добавляем их в бд
    db.Buyer.AddRange(product);
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

