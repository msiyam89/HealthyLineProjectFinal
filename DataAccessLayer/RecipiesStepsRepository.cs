using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RecipiesStepsRepository
    {
        public static List<RecipesStep> GetAll()
        {
            List<RecipesStep> result = null;
            try
            {
                using (var context = new HealtyLineContext())
                {
                    result = context.RecipesSteps.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public static RecipesStep GetRecipeStepById(int id)
        {
            RecipesStep result = null;
            try
            {
                using (var context = new HealtyLineContext())
                {
                    result = context.RecipesSteps.Where(x => x.Id == id).FirstOrDefault();
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
