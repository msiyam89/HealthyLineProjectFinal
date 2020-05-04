using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FoodSubCategoriesBE
    {
        #region Singleton
        private FoodSubCategoriesBE()
        {
        }

        private static readonly Lazy<FoodSubCategoriesBE> _instance =
            new Lazy<FoodSubCategoriesBE>(() => new FoodSubCategoriesBE());

        /// <summary>
        /// Singleton instance of LookupService.
        /// </summary>        
        public static FoodSubCategoriesBE Instance
        {
            get { return _instance.Value; }
        }

        #endregion


        #region Method
        public  List<FoodSubCategory> GetAll()
        {
            return DataAccessLayer.FoodSubCategoriesRepository.GetAll();
        }

        public  FoodSubCategory GetFoodSubCategoryById(int id)
        {
            return DataAccessLayer.FoodSubCategoriesRepository.GetFoodSubCategoryById(id);
        }
        #endregion
    }
}
