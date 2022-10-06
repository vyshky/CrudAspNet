using Crud.Infrastructure.Repositories.Implementation;

AuthenticationRepository repository = new AuthenticationRepository();
repository.AutorizationUser("Alexandr", "1234456");
repository.CreateUser("Alexandr5", "0000");
//repository.UpdatePassword("123123124", "23123123", "23123123");
//repository.DeleteUser("123123124", "23123123");



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