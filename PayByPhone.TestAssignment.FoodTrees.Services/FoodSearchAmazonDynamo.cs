using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PayByPhone.TestAssignment.FoodTrees.Models;

namespace PayByPhone.TestAssignment.FoodTrees.Services
{
    public class FoodSearchAmazonDynamo : IFoodSearch
    {
        private string _awsAccessKey;
        private string _awsRegion;
        private string _awsSecretKey;

        public FoodSearchAmazonDynamo(string awsAccessKey, string awsSecretKey, string awsRegion)
        {
            _awsAccessKey = awsAccessKey;
            _awsSecretKey = awsSecretKey;
            _awsRegion = awsRegion;
        }

        public IList<FoodGarden> GetFoodGardensByFoodTreeVarieties(string foodTreeVariety, 
                                                                   string sortHoistedFoodTreeVariety, 
                                                                   IList<string> excludedJurisdictions, 
                                                                   IList<string> excludedMapIds)
        {
            IList<FoodGarden> foodGardens = null;


            return foodGardens;
        }
    }
}
