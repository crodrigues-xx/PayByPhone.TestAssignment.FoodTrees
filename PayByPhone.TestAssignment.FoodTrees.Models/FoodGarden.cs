using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayByPhone.TestAssignment.FoodTrees.Models
{
    public class FoodGarden
    {
        public string MapId { get; set; }
        public int YearCreated { get; set; }
        public string Name { get; set; }
        public string MergedAddress { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int NumberOfPlots { get; set; }
        public int NumberOfFoodTrees { get; set; }
        public string Notes { get; set; }
        public string FoodTreeVarieties { get; set; }
        public string Jurisdiction { get; set; }
    }
}
