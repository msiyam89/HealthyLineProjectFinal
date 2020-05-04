using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RecipeRepository
    {

        public static List<Recipe> GetAll()
        {
			List<Recipe> result = null;
			try
			{
				using (var context = new HealtyLineContext())
				{
					result = context.Recipes.ToList();
				}
			}
			catch (Exception ex)
			{

				throw ex;
			}

			return result;
        }

		public static Recipe GetRecipeById(int id)
		{
			Recipe result = null;
			try
			{
				using (var context = new HealtyLineContext())
				{
					result = context.Recipes.Where(x => x.Id == id).FirstOrDefault();
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
