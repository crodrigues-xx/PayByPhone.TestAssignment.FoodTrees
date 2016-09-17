using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PayByPhone.TestAssignment.FoodTrees.Models;

namespace PayByPhone.TestAssignment.FoodTrees.Services
{
    public class FoodSearchAmazonDynamo : IFoodSearch
    {
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
