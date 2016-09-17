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
        public string Get(string foodName)
        {
            string sortHoistedFoodTreeVariety;
            IList<string> excludedJurisdictions;
            IList<string> excludedMapIds;

            sortHoistedFoodTreeVariety = _config.Retrieve(AppKeys.SortHoistedFoodTreeVariety);
            sortHoistedFoodTreeVariety = _config.Retrieve(AppKeys.ExcludedJurisdictions);
            sortHoistedFoodTreeVariety = _config.Retrieve(AppKeys.ExcludedMapIds);

            sortHoistedFoodTreeVariety = _config.Retrieve(AppKeys.AWSAccessKey);
            sortHoistedFoodTreeVariety = _config.Retrieve(AppKeys.AWSSecretKey);
            sortHoistedFoodTreeVariety = _config.Retrieve(AppKeys.AWSRegion);

            _foodSearch.GetFoodGardensByFoodTreeVarieties(foodName, sortHoistedFoodTreeVariety,
                excludedJurisdictions, excludedMapIds);

            return foodName;
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
