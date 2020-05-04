using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class DiseasesRepository
	{
		public static Disease GetById(int id)
		{
			Disease result = null;
			try
			{
				using (var context = new HealtyLineContext())
				{
					result = context.Diseases.Where(x => x.Id == id).FirstOrDefault();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}
		public static List<Disease> GetAll()
		{
			try
			{
				using (var context = new HealtyLineContext())
				{
					return context.Diseases.ToList();
				}
			}
			catch (Exception ex)
			{
				return null;
				throw ex;
			}
		}

		public static bool CreateDisease(Disease disease)
		{
			var result = false;
			try
			{
				using (var context = new HealtyLineContext())
				{
					context.Diseases.Add(disease);
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

		public static bool UpdateDisease(Disease disease)
		{
			var result = false;
			try
			{
				using (var context = new HealtyLineContext())
				{
					var Updatedisease = context.Diseases.First<Disease>();
					Updatedisease = disease;
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

		public static bool IsExist(string nameArabic , string nameEnglish)
		{
			var result = false;
			try
			{
				using (var context = new HealtyLineContext())
				{
					var isExist = context.Diseases.Where(x => x.NameArabic == nameArabic && x.NameEnglish == nameEnglish).FirstOrDefault();
					if (isExist != null)
					{
						result = true;
					}
					
				}
			}
			catch (Exception ex)
			{
				result = false;
				throw ex;
			}

			return result;
		}
    }
}
