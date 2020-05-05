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
       
        public Tuple<bool,string> CreateUserProfile(string userName, UserProfile userProfile)
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

        public object Signup(DateTime birthDate, string confirm, string email, string fullNameArabic, string fullNameEnglish, bool gender, string mobileNumber, string password, string userName)
        {
            UserProfile userProfile = new UserProfile
            {
                Birthdate = birthDate,
                Gender = gender,
                MobileNumber = mobileNumber,
                FullNameArabic = fullNameArabic,
                FullNameEnglish = fullNameEnglish,
                UserName = userName,
                Password = password


            };

            var creatResult = CreateUserProfile(userName, userProfile);
            bool success = creatResult.Item1;
            string message = creatResult.Item2;


            if (success)
                return userProfile;

            return null;
        }

        public object SignIn(DateTime birthDate, string confirm, string email, string fullNameArabic, string fullNameEnglish, byte gender, string mobileNumber, string password, string userName)
        {
            throw new NotImplementedException();
        }

        public object CreateUserProfile(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserProfile(UserProfile userProfile)
        {
            userProfile.UpdateDate = DateTime.Now;
            userProfile.UpdatedBy = "";
            return DataAccessLayer.UserProfileRepository.UpdateUserProfile(userProfile);
        }

        public  UserProfile SignIn(string username, string passwword)
        {
            return DataAccessLayer.UserProfileRepository.SignIn(username, passwword);
        }
        #endregion
    }
}
