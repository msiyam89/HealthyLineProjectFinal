using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RecipiesStepsBE
    {
        #region Singleton
        private RecipiesStepsBE()
        {
        }

        private static readonly Lazy<RecipiesStepsBE> _instance =
            new Lazy<RecipiesStepsBE>(() => new RecipiesStepsBE());

        /// <summary>
        /// Singleton instance of LookupService.
        /// </summary>        
        public static RecipiesStepsBE Instance
        {
            get { return _instance.Value; }
        }

        #endregion


        #region Methods
        public List<RecipesStep> GetAll()
        {
            return DataAccessLayer.RecipiesStepsRepository.GetAll();
        }

        public static RecipesStep GetRecipeStepById(int id)
        {

            return DataAccessLayer.RecipiesStepsRepository.GetRecipeStepById(id);

        }
        #endregion
    }
}
