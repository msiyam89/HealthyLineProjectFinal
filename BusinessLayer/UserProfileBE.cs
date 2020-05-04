using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserProfileBE
    {
        #region Singleton
        private UserProfileBE()
        {
        }

        private static readonly Lazy<UserProfileBE> _instance =
            new Lazy<UserProfileBE>(() => new UserProfileBE());

        /// <summary>
        /// Singleton instance of LookupService.
        /// </summary>        
        public static UserProfileBE Instance
        {
            get { return _instance.Value; }
        }

        #endregion


        #region Methods
        public UserProfile GetUserProfile(int id)
        {
            return DataAccessLayer.UserProfileRepository.GetUserProfile(id);
        }
       
        public Tuple<bool,string> CreateUserProfile(UserProfile userProfile)
        {
            var result = new Tuple<bool, string>(false,"");
            userProfile.CreateDate = DateTime.Now;
            userProfile.CreateBy = userProfile.UserName;
            var isExist = DataAccessLayer.UserProfileRepository.IsUserExist(userProfile.UserName, userProfile.MobileNumber);
            if (isExist)
            {
                result = new Tuple<bool, string>(false, "User Is Already Exist");
            }
            else
            {
                var createResult = DataAccessLayer.UserProfileRepository.CreateUserProfile(userProfile);
                result = new Tuple<bool, string>(createResult, "");
            }
            return result;
        }
        public bool UpdateUserProfile(UserProfile userProfile)
        {
            userProfile.UpdateDate = DateTime.Now;
            userProfile.UpdatedBy = "";
            return DataAccessLayer.UserProfileRepository.UpdateUserProfile(userProfile);
        }
        #endregion
    }
}
