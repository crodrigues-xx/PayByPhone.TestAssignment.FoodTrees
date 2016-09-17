using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PayByPhone.Infrastructure;
using PayByPhone.TestAssignment.FoodTrees.Models;

namespace PayByPhone.TestAssignment.FoodTrees.Controllers
{
    public class FoodController : ApiController
    {
        private IFoodSearch _foodSearch;
        private IConfig _config;

        public FoodController(IFoodSearch foodSearch, IConfig config)
        {
            _foodSearch = foodSearch;
            _config = config;
        }

        [HttpGet]
        public IList<FoodGarden> Get(string foodName)
        {
            string sortHoistedFoodTreeVariety = null;

            string excludedJurisdictionsString = null;
            IList<string> excludedJurisdictions = null;

            string excludedMapIdsString = null;
            IList<string> excludedMapIds = null;

            IList<FoodGarden> foodGardens = null;

            sortHoistedFoodTreeVariety = _config.Retrieve(AppKeys.SortHoistedFoodTreeVariety);
            excludedJurisdictionsString = _config.Retrieve(AppKeys.ExcludedJurisdictions);
            excludedMapIdsString = _config.Retrieve(AppKeys.ExcludedMapIds);

            excludedJurisdictions = excludedJurisdictionsString.Split(',');
            excludedMapIds = excludedMapIdsString.Split(',');

            foodGardens = _foodSearch.GetFoodGardensByFoodTreeVarieties(foodName, 
                sortHoistedFoodTreeVariety, excludedJurisdictions, excludedMapIds);

            return foodGardens;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
