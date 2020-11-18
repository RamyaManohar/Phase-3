using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket1.Models;

namespace StockMarket1.Repository.User
{
    interface UserLoginInterface
    {
        public void create(UserEntity u);

        public bool check(UserEntity userEntity);

        public List<UserEntity> getall();
    }
}
