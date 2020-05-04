using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserProfileRepository
    {

        #region Operations 

        public static UserProfile GetUserProfile(int id)
        {
            using (var context = new HealtyLineContext())
            {
                return context.UserProfiles.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public static bool IsUserExist(string name, string mobileNumber)
        {
            bool isExist;
            using (var context = new HealtyLineContext())
            {
                var result = context.UserProfiles.Where(x => x.UserName == name || x.MobileNumber == mobileNumber).FirstOrDefault();
                if (result != null)
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
                return isExist;
            }
        }
        public static bool CreateUserProfile(UserProfile userProfile)
        {
            bool result = false;
            try
            {
                using (var context = new HealtyLineContext())
                {
                    context.UserProfiles.Add(userProfile);
                    context.SaveChanges();

                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }

            return result;
        }
        public static bool UpdateUserProfile(UserProfile userProfile)
        {
            var result = false;
            try
            {
                using (var context = new HealtyLineContext())
                {
                    var user = context.UserProfiles.First<UserProfile>();
                    user = userProfile;
                    context.SaveChanges();

                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }

            return result; 
        }

        public static bool IsUserExist(string userName)
        {
            using (var context = new HealtyLineContext())
            {
                return context.UserProfiles.Where(x => x.UserName == userName || x.MobileNumber == mobileNumber).FirstOrDefault();
            }
        }
        #endregion
    }
}
