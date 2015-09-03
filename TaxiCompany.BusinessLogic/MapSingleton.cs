using System;
using TaxiCompany.Model;

namespace TaxiCompany.BusinessLogic
{
    /// <summary>
    /// It loads map. It's used for finding coordinates for address and calculate distance
    /// </summary>
    public class MapSingleton
    {
        private static MapSingleton instance;

        // Note: Constructor is 'protected' 
        protected MapSingleton()
        {
        }

        public static MapSingleton Instance()
        {
            // Use 'Lazy initialization' 
            if (instance == null)
            {
                instance = new MapSingleton();
                LoadMap();
            }

            return instance;
        }

        /// <summary>
        /// return path from address1 to address 2
        /// </summary>
        /// <param name="address1"></param>
        /// /// <param name="address2"></param>
        /// <returns></returns>
        public static Coordinate[] GetPath(string address1, string address2)
        {
            return new Coordinate[10];
        }

        /// <summary>
        /// get distance in km from address1 to address2
        /// </summary>
        /// <param name="address1"></param>
        /// <param name="address2"></param>
        /// <returns></returns>
        public static decimal GetDistance(string address1, string address2)
        {
            return 10;
        }

        private static void LoadMap()
        {
            
        }
    }
}
