using Crud.Infrastructure.Model.Entities;
using Crud.Infrastructure.Persistence;
using System.Diagnostics;

namespace Crud.Infrastructure.Repositories.Implementation
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        public bool AutorizationUser(string login, string password)
        {
            using (OrmContext db = new OrmContext())
            {
                var user = from u in db.Authentication
                           where u.Login.Equals(login)
                           where u.Password.Equals(password)
                           select u;
                if (user.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool CreateUser(string login, string password)
        {
            using (OrmContext db = new OrmContext())
            {
                var user = from u in db.Authentication
                           where u.Login.Equals(login)
                           select u;

                if (user.Any())
                {
                    return false;
                }
                else
                {
                    Authentication newUser = new Authentication()
                    {
                        Login = login,
                        Password = password
                    };
                    db.Authentication.Add(newUser);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool DeleteUser(string login, string password)
        {
            using (OrmContext db = new OrmContext())
            {
                var user = from u in db.Authentication
                           where u.Login.Equals(login)
                           where u.Password.Equals(password)
                           select u;
                if (user.Any())
                {
                    db.Authentication.Remove(user.First());
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public bool UpdatePassword(string login, string password, string newPassword)
        {

            using (OrmContext db = new OrmContext())
            {
                var user = (from u in db.Authentication
                            where u.Login.Equals(login)
                            where u.Password.Equals(password)
                            select u);
                if (user.Any())
                {
                    //var updateUser = user.Select(x => new Authentication() { Id = x.Id, Login = x.Login, Password = newPassword }).First();     
                    var updateUser = user.First();
                    updateUser.Password = newPassword;
                    db.Authentication.Update(updateUser);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
