using DemoLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Contract
{
    public interface IUser
    {
        ///get all records
        List<User> getalluserdetails();

        ///get user by id
        User getuserbyid(long id);

        ///add user
        string adduser(User user);

        ///update user
        string updateuser(User user);

        ///delete user
        string deleteuser(long id);
    }
}
