using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RecipiesIngerdientsRepository
    {
		public static List<RecipesIngredient> GetAll()
		{
			List<RecipesIngredient> result = null;
			try
			{
				using (var context = new HealtyLineContext())
				{
					result = context.RecipesIngredients.ToList();
				}
			}
			catch (Exception ex)
			{

				throw ex;
			}

			return result;
		}

		public static RecipesIngredient GetRecipeIngredientById(int id)
		{
			RecipesIngredient result = null;
			try
			{
				using (var context = new HealtyLineContext())
				{
					result = context.RecipesIngredients.Where(x => x.Id == id).FirstOrDefault();
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
