using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RecipeBE
    {
        #region Singleton
        private RecipeBE()
        {
        }

        private static readonly Lazy<RecipeBE> _instance =
            new Lazy<RecipeBE>(() => new RecipeBE());

        /// <summary>
        /// Singleton instance of LookupService.
        /// </summary>        
        public static RecipeBE Instance
        {
            get { return _instance.Value; }
        }

        #endregion
    }
}
