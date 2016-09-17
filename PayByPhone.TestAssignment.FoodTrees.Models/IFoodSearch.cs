using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayByPhone.TestAssignment.FoodTrees.Models
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public interface IFoodSearch
    {
        IList<FoodGarden> GetFoodGardensByFoodTreeVarieties(string foodTreeVariety,
                                                            string sortHoistedFoodTreeVariety,
                                                            IList<string> excludedJurisdictions,
                                                            IList<string> excludedMapIds);

    }
}
