using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket1.Models;

namespace StockMarket1.Repository.Admin
{
    public class AdminRepository : AdminLoginInterface
    {
        public StockMarketDBContext db = new StockMarketDBContext();
        //public AdminLogin(StockMarketDBContext SmDb)
        //{
        //    this.SmDb = SmDb;
        //}
        public bool check(UserEntity u)
        {
           
            
            UserEntity cUser = db.UserEntity.FirstOrDefault(i => i.Username == u.Username && i.Password == u.Password && i.UserType == u.UserType);
            if (cUser == null)
                return false;
            return true;
        }

        public void create(UserEntity u)
        {
            db.UserEntity.Add(u);
            db.SaveChanges();
        }

        public List<UserEntity> getall()
        {
            return db.UserEntity.Where(x => x.UserType == "Admin").ToList();
        }

    }
}
