using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FoodSubCategoriesRepository
    {
        public static List<FoodSubCategory> GetAll()
        {
            List<FoodSubCategory> result = null;
            try
            {
                using (var context = new HealtyLineContext())
                {
                    result = context.FoodSubCategories.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public static FoodSubCategory GetFoodSubCategoryById(int id)
        {
            FoodSubCategory result = null;
            try
            {
                using (var context = new HealtyLineContext())
                {
                    result = context.FoodSubCategories.Where(x => x.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }
}
