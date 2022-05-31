using Rehber.API.Concrate;
using Rehber.API.Data;
using Rehber.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API.Abstract
{
    public class EfUserRepository : Repository<User, Context>
    {
        public User Login(string UMail, string pass)
        {

            return Get(x => x.userMail == UMail && x.password == pass);
          
        }

        public User LoginW(string UMail, string Pass)
        {
            return GetWrong(x => x.userMail == UMail && x.password!= Pass);
        }

    }
}