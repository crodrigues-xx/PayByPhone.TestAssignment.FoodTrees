using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PayByPhone.TestAssignment.FoodTrees.Models;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;

namespace PayByPhone.TestAssignment.FoodTrees.Services
{
    public class FoodSearchAmazonDynamo : IFoodSearch
    {
        private string _awsAccessKey;
        private string _awsRegion;
        private string _awsSecretKey;

        public FoodSearchAmazonDynamo(string awsAccessKey, string awsSecretKey, 
                                      string awsRegion)
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

            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            Table table = Table.LoadTable(client, "hire-foodtrees");
            Document item = table.GetItem("FA085", null);

            return foodGardens;
        }
    }
}
