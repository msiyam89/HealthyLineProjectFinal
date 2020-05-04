using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FoodMainCategoriesBE
    {
        #region Singleton
        private FoodMainCategoriesBE()
        {
        }

        private static readonly Lazy<FoodMainCategoriesBE> _instance =
            new Lazy<FoodMainCategoriesBE>(() => new FoodMainCategoriesBE());

        /// <summary>
        /// Singleton instance of LookupService.
        /// </summary>        
        public static FoodMainCategoriesBE Instance
        {
            get { return _instance.Value; }
        }

        #endregion


        #region Method
        public static List<FoodMainCategory> GetAll()
        {
            return DataAccessLayer.FoodMainCategoriesRepository.GetAll();
        }

        public static FoodMainCategory GetFoodMainCategoryById(int id)
        {
            return DataAccessLayer.FoodMainCategoriesRepository.GetFoodMainCategoryById(id);
        }
        #endregion
    }
}
