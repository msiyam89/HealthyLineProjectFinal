using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RecipiesIngerdientsBE
    {
        #region Singleton
        private RecipiesIngerdientsBE()
        {
        }

        private static readonly Lazy<RecipiesIngerdientsBE> _instance =
            new Lazy<RecipiesIngerdientsBE>(() => new RecipiesIngerdientsBE());

        /// <summary>
        /// Singleton instance of LookupService.
        /// </summary>        
        public static RecipiesIngerdientsBE Instance
        {
            get { return _instance.Value; }
        }

        #endregion


    }
}
