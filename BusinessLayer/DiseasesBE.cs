using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DiseasesBE
    {
        #region Singleton
        private DiseasesBE()
        {
        }

        private static readonly Lazy<DiseasesBE> _instance =
            new Lazy<DiseasesBE>(() => new DiseasesBE());

        /// <summary>
        /// Singleton instance of LookupService.
        /// </summary>        
        public static DiseasesBE Instance
        {
            get { return _instance.Value; }
        }

		#endregion


		#region Methods

		public static Disease GetById(int id)
		{
			return DataAccessLayer.DiseasesRepository.GetById(id);
		}
		public  List<Disease> GetAll()
		{
			return DataAccessLayer.DiseasesRepository.GetAll();
		}

		public  Tuple<bool,string> CreateDisease(Disease disease)
		{
			var result = new Tuple<bool,string>(false,"");
			var isExist = DataAccessLayer.DiseasesRepository.IsExist(disease.NameArabic, disease.NameEnglish);
			if (isExist)
			{
				result = new Tuple<bool, string>(false, "Item Already Exist");
			}
			else
			{
				var createResult = DataAccessLayer.DiseasesRepository.CreateDisease(disease);
				result = new Tuple<bool, string>(createResult, "");
			}
			return result;
		}

		public bool UpdateDisease(Disease disease)
		{
			return DataAccessLayer.DiseasesRepository.UpdateDisease(disease);
		}
		#endregion
	}
}
