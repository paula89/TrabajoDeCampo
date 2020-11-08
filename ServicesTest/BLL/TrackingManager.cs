using ServicesTest.DAL.Factory;
using ServicesTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.BLL
{
    public class TrackingManager
    {
        #region Singleton
        private readonly static TrackingManager _instance = new TrackingManager();

        public static TrackingManager Current
        {
            get
            {
                return _instance;
            }
        }

        private TrackingManager()
        {
        }
        #endregion

        /// <summary>
        /// get all the tracking database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tracking> ObtenerTracking()
        {
            return FactoryDAL.Current.GetTrackingRepository().GetAll();
        }
    }
}
