using DemoLayer.Model;
using RepositoryLayer;
using ServiceLayer.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Implementation
{
    public class UserService : IUser
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
           this._dbContext = dbContext;
        }
        public string adduser(User user)
        {
            try
            {
                this._dbContext.tblUser.Add(user);
                this._dbContext.SaveChanges();
                return "User added successfully";
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                return $"Error adding user: {ex.Message}";

            }
        }

        public string deleteuser(long id)
        {
            try
            {
                var user = this._dbContext.tblUser.Find(id);
                this._dbContext.tblUser.Remove(user);
                this._dbContext.SaveChanges();
                return "User deleted successfully";
            }
            catch (Exception ex)
            {
                return $"Error deleting user: {ex.Message}";
            }

        }

        public List<User> getalluserdetails()
        {
            return _dbContext.tblUser.ToList();
        }

        public User getuserbyid(long id)
        {
            return _dbContext.tblUser.Find(id);
        }

        public string updateuser(User user)
        {
            try
            {
                var existingUser = this._dbContext.tblUser.Find(user.userId);
                if (existingUser == null)
                {
                    return "User not found";
                }
                else
                {
                    existingUser.userName = user.userName;
                    existingUser.userPhoneNumber = user.userPhoneNumber;
                    existingUser.userEmail = user.userEmail;
                    existingUser.userAddress = user.userAddress;
                    this._dbContext.tblUser.Update(existingUser);

                }
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                return $"Error updating user: {ex.Message}";
            }
            finally
            {
                this._dbContext.SaveChanges();
                

            }
            return "User updated successfully";
        }
    }
}
