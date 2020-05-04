using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FoodMainCategoriesRepository
    {
        public static List<FoodMainCategory> GetAll()
        {
            List<FoodMainCategory> result = null;
            try
            {
                using (var context = new HealtyLineContext())
                {
                    result = context.FoodMainCategories.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public static FoodMainCategory GetFoodMainCategoryById(int id)
        {
            FoodMainCategory result = null;
            try
            {
                using (var context = new HealtyLineContext())
                {
                    result = context.FoodMainCategories.Where(x => x.Id == id).FirstOrDefault();
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
